﻿using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoRealTimeApp.Hubs
{
    public enum Role
    {
        Admin = 1,
        Participant
    }
    public class ChatHub : Hub
    {
        //define a dictionary to store the userid.
        private static Dictionary<string, List<string>> NtoIdMappingTable = new Dictionary<string, List<string>>();
        private ApplicationDbContext _applicationDbContext;
        public readonly static List<ApplicationUser> _Users = new List<ApplicationUser>();
        private readonly static Dictionary<string, string> _ConnectionsMap = new Dictionary<string, string>();
        public readonly static List<ApplicationUser> _Connections = new List<ApplicationUser>();
        private Room room = new Room();
        private Room roomV2 = new Room();
        public ChatHub(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public override async Task OnConnectedAsync()
        {
            if (_Users.Count == 0)
            {
                foreach (ApplicationUser users in _applicationDbContext.Users.ToList())
                {
                    _Users.Add(users);
                }
            }
            var user = _applicationDbContext.Users.Where(u => u.UserName == Context.User.Identity.Name).FirstOrDefault();
            user.ConnectionId = Context.ConnectionId;
            user.CurrentRoomId = 0;
            _Connections.Add(user);
            _ConnectionsMap.Add(Context.User.Identity.Name, Context.ConnectionId);
            await Clients.All.SendAsync("UserConnected", _Connections);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            //await Clients.All.SendAsync("UserDisConnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }

        public int CreateRoom(string roomName, string userSelected)
        {
            try
            {
                // Create and save chat room in database
                var user = _applicationDbContext.Users.Where(u => u.UserName == Context.User.Identity.Name).FirstOrDefault();
                var room = new Room()
                {
                    Name = roomName
                };
                var result = _applicationDbContext.Rooms.Add(room);
                _applicationDbContext.SaveChanges();
                room.Id = room.Id;
                if (room != null)
                {
                    char[] spearatorElement = { ';' };
                    String[] arrayUserSelected = userSelected.Split(spearatorElement);
                    for (var i = 0; i < arrayUserSelected.Length; i++)
                    {
                        if (arrayUserSelected[0] == user.Id)
                        {
                            this.AddUserToRoom(arrayUserSelected[0], room.Id, (int)Role.Admin);
                        }
                        else
                        {
                            this.AddUserToRoom(arrayUserSelected[0], room.Id, (int)Role.Participant);
                        }


                        string userId;
                        if (_ConnectionsMap.TryGetValue(arrayUserSelected[1], out userId))
                        {
                            Clients.Client(userId).SendAsync("addChatRoom", room);
                        }
                    }
                }
                return room.Id;
            }
            catch (Exception ex)
            {
                Clients.Caller.SendAsync("onError", $"Couldn't create chat room:{ex.Message}");
            }
            return 0;
        }

        public void AddUserToRoom(string userId, int roomId, int role = 0)
        {
            try
            {
                // Create and save chat room in database
                // var user = _applicationDbContext.Users.Where(u => u.UserName == IdentityName).FirstOrDefault();
                var user = new UserRoom()
                {
                    UserId = userId,
                    RoomId = roomId,
                    Role = role,
                };
                _applicationDbContext.UserRooms.Add(user);
                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Clients.Caller.SendAsync("onError", $"Couldn't create chat room: {ex.Message} ");
            }
        }

        //public Task JoinGroup(string groupid)
        //{
        //    var user = _Connections.Where(u => u.UserName == Context.User.Identity.Name).FirstOrDefault();
        //    try
        //    {
        //        if (!user.CurrentRoomId.ToString().Equals(groupid))
        //        {
        //            // Remove user from others list
        //            if (!string.IsNullOrEmpty(user.CurrentRoomId.ToString()))
        //                Clients.OthersInGroup(user.CurrentRoomId.ToString()).SendAsync("RemoveUser",user.DisplayName);

        //            // Join to new chat room
        //            Leave(user.CurrentRoomId);
        //            Groups.AddToGroupAsync(Context.ConnectionId, groupid);
        //            user.CurrentRoomId = Convert.ToInt32(groupid);

        //            // Tell others to update their list of users
        //            Clients.OthersInGroup(groupid.ToString()).SendAsync("addUser",user.DisplayName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

        private void Leave(int roomId)
        {
            Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId.ToString());
        }

        public async Task GetMessageHistory(string receiver)
        {
            var userSender = _applicationDbContext.Users.Where(u => u.UserName == Context.User.Identity.Name).FirstOrDefault();
            var userReceiver = _applicationDbContext.Users.Where(u => u.UserName == receiver).FirstOrDefault();
            var roomName = Convert.ToBase64String(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes($"{userSender.Email}{receiver}")));
            var roomNamev2 = Convert.ToBase64String(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes($"{receiver}{userSender.Email}")));
            room = _applicationDbContext.Rooms.Where(room => (room.Name.Equals($"P{roomName}"))).FirstOrDefault();
            roomV2 = _applicationDbContext.Rooms.Where(r => r.Name.Equals($"P{roomNamev2}")).FirstOrDefault();
            var currentRoom = room != null ? room : roomV2;
            //get list msg by roomId
            var msgHistory = _applicationDbContext.Messages.Where(m => m.ToRoom == currentRoom).Select((message) => new Message { FromUserId = message.FromUserId, ToUserId = message.ToUserId, Content = message.Content }).ToList();
            await Clients.Caller.SendAsync("GetHistory", msgHistory, userSender.Id, userSender.Avatar, userReceiver.Id, userReceiver.Avatar);
        }

        public async Task SendPrivateMessage(string receiver, string message)
        {
            var userSender = _applicationDbContext.Users.Where(u => u.UserName == Context.User.Identity.Name).FirstOrDefault();
            var userReceiver = _applicationDbContext.Users.Where(u => u.UserName == receiver).FirstOrDefault();
            var roomName = Convert.ToBase64String(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes($"{userSender.Email}{receiver}")));
            var roomNamev2 = Convert.ToBase64String(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes($"{receiver}{userSender.Email}")));

            room = _applicationDbContext.Rooms.Where(room => (room.Name.Equals($"P{roomName}"))).FirstOrDefault();
            roomV2 = _applicationDbContext.Rooms.Where(r => r.Name.Equals($"P{roomNamev2}")).FirstOrDefault();

            if (room == null && roomV2 == null)
            {
                Room newRoom = new Room()
                {
                    Name = $"P{roomName}"
                };
                _applicationDbContext.Rooms.Add(newRoom);
                _applicationDbContext.SaveChanges();
                _applicationDbContext.UserRooms.AddRange(
                 new UserRoom()
                 {
                     UserId = userReceiver.Id,
                     RoomId = newRoom.Id,
                     Role = (int)Role.Participant
                 },

                  new UserRoom()
                  {
                      UserId = userSender.Id,
                      RoomId = newRoom.Id,
                      Role = (int)Role.Participant
                  }
               );
            }

            var currentRoom = room != null ? roomName : roomNamev2;

            Message msg = new Message()
            {
                Content = Regex.Replace(message, @"(?i)<(?!img|a|/a|/img).*?>", String.Empty),
                Timestamp = DateTime.Now.Ticks.ToString(),
                FromUser = userSender,
                ToUser = userReceiver,
                ToRoom = _applicationDbContext.Rooms.FirstOrDefault(r => r.Name.Equals($"P{currentRoom}"))
            };
            _applicationDbContext.Messages.Add(msg);
            _applicationDbContext.SaveChanges();
            string connectionId;
            if (_ConnectionsMap.TryGetValue(userReceiver.UserName, out connectionId))
            {

                // Send the message
                await Clients.Caller.SendAsync("SendMsg", msg.Content, msg.FromUser.Avatar);
            }
            // Send the message
            await Clients.Client(connectionId).SendAsync("ReceiveMessage", msg.Content, msg.FromUser.Avatar);
        }
    }
}
