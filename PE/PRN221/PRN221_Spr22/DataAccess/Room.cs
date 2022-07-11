﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221_Spr22.DataAccess
{
    public partial class Room
    {
        public Room()
        {
            Services = new HashSet<Service>();
        }

        public string Title { get; set; }
        public byte? Square { get; set; }
        public byte? Floor { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
