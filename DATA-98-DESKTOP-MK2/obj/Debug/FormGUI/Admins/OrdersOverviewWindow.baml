   M S B A M L   `   `   `  ����B  >DATA-98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DATA_98_DESKTOP_MK2.FormGUI.Admins"DATA_98_DESKTOP_MK2.FormGUI.Admins  5   	   =    7DATA_98_DESKTOP_MK2.FormGUI.Admins.OrdersOverviewWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:DATA_98_DESKTOP_MK2.FormGUI.Admins     5   	     � Title$  OrdersOverviewWindow��5   	   $	��450��6&   $	��800��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gdOrders��5      $��1��6%   $��2��65   $��6��6I   �� 5   
   -   5         ��Name$ btnEdit��5      $��3��68   .��5      (� .��5      �� $
��Edit��6   $��30 10 30 10q�6'   5      5      �� 5   
   -   5        $ 	btnRemove��5      $��3��6<   $��3��6M   .��5       (� .��5!      �� $��Remove��6   $��30 10 30 10q�6)   5"      5#      �� 5$   
   -   5        $ btnQuestionOrder��5$      $��3��6+   $��0��6;   .��5%      (� .��5&      �� $��Unverify��6   $��20 10 20 10q�6+   5'      5(      �� 5)   
   -   5        $ btnIdleOrder��5)      $��3��6'   $��1��67   .��5*      (� .��5+      �� $��Idlize��6   $��20 10 20 10q�6)   5,      5-      �� 5.   
   -   5        $ btnAcceptOrder��5.      $��3��6)   $��2��69   .��5/      (� .��50      �� $
��Take��6   $��20 10 20 10q�6'   51      52      �� 53   
   -   5        $ btnApproveOrder��53      $��3��6*   $��3��6:   .��54      (� .��55      �� $��Approve��6   $��20 10 20 10q�6*   56      57      �� 58   
   -   5        $ btnDisapproveOrder��58      $��3��6-   $��4��6=   .��59      (� .��5:      �� $��
Disapprove��6   $��20 10 20 10q�6-   5;      5<      �� 5=   
   -	   5        $ btnMarkDone��5=      $��3��6&   $��5��66   .��5>      (� .��5?      �� $
��Done��6   $��20 10 20 10q�6'   5@      5A      �� 5B   
   -
   5        $ btnGoToProfile��5B      $��4��6)   $��6��6=   .��5C      (� .��5D      �� $��
To profile��6   $��5 5 5 5q�6-   5E      5F      5G      5H      