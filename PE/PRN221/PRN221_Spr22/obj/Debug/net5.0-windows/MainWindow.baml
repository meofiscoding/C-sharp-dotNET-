   M S B A M L   `   `   `  ����G  CPRN221_Spr22, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PRN221_Spr22PRN221_Spr22  5   	       PRN221_Spr22.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PRN221_Spr22     5   	     � Title$  EmployeeWindow��5   	   $	��550��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $��3* �6   6*   .+�5   
   �� 
����ح� �� Orientation$ Vertical=�6-   $
��Left=�5      $	��400��64   .+�5      �� -   5        $��lblInstruction��5      
���  ��$��DemiBold"�6;   $��20(�5      $��Employee Information��6"   �� 5      -   5        $��lblEmployeeID��5      $��Employee Id��6*   �� 5      -   5        $��txtEmployeeID��5      $��Stretch=�6+   $��25��5      $	��400��6"   ${�False��5      ��5      ��  �� Path$ Id� �� Mode$ TwoWay=� � DataContext 5      ��  �� ElementName$ lvEmployees��$ SelectedItem��� 5      -   5        $��lbEmployeeName��5      $��Employee Name��6*   �� 5      -   5        $��txtEmployeeName��5      $��Stretch=�6-   $��25��5      $	��400��6"   ��6/   �� $
 Name�$ TwoWay=� 5      �� $ lvEmployees��$ SelectedItem��� 5      -   5        $��lbGender��5      $��Gender��6$   �� 5      $ 
Horizontal=�6   $��Stretch=�63   .+�5      	� -   5        $��radioButton1��5      $
��Male��62    d� 	IsChecked$
 TrueY�6A   	� 5       -   5        $��radioButton2��5       $��Female��62   5!      �� 5"      -	   5        $��lbDateofBirth��5"      $��Date of birth��6)   (  "System.Windows.Controls.DatePicker  5#      -
   5        $��tbDate��5#      $��Stretch=�6'   �� 5$      -   5        $��lbPhone��5$      $��Phone��6#   �� 5%      -   5        $��txtPhone��5%      $��Stretch=�6&   $��25��5&      $	��400��6"   ��6/   �� $ Phone�$ TwoWay=� 5'      �� $ lvEmployees��$ SelectedItem��� 5(      -   5        $��	lbIDNumer��5(      $��IDNumber��6%   �� 5)      -   5        $��txtIDNumber��5)      $��Stretch=�6)   $��25��5*      $	��400��6"   ��6/   �� $ Idnumber�$ TwoWay=� 5+      �� $ lvEmployees��$ SelectedItem�5,      �� 5-   
   $ 
Horizontal=�6   $
��Left=�6/   $��	0,331,0,0q�6J   $��2��6]   $	��400��6n   .+�5.      �� -   5         ��Name$ 
btnRefresh��5.      $��10q�6)   $��80��65   $��Refresh��6@   5/      �� 50      -   5        $ btnAdd��50      $��10q�6%   $��80��61   $	��Add��6<   51      �� 52      -   5        $ btnEdit��52      $��10q�6'   $��80��63   $
��Edit��6?   53      �� 54      -   5        $ 	btnDelete��54      $��10q�6(   $��80��65   $��Delete��6@   55      56      �� 57   
   -   5        $��lvEmployees��57       $��2��6   $
��Auto��63   $
��Auto��6@   $��0,1,0,0q�6N   	 �� View	 58      �� 59      .P�5:      �� $��
EmployeeID��6%   
 �� Width$	
 100��6:    �� DisplayMemberBinding 5;   %   �� $ Id��� 5<      $��Employee Name��6%   $	
 150��6<    5=   %   �� $
 Name��� 5>      $��Gender��6%   $	
 100��66    5?   %   �� $ Gender��� 5@      $��DateOfBirth��6%   $	
 150��6:    5A   %   �� $	 Dob��� 5B      $��Phone��6%   $	
 150��65    5C   %   �� $ Phone��� 5D      $��IDNumber��6%   $	
 150��67    5E   %   �� $ Idnumber�5F      5H      5I      5J      