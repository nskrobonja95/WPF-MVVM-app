   M S B A M L   `   `   `  ����I  EMenuNavigation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MenuNavigation.ViewsMenuNavigation.Views  5      /clr-namespace:MenuNavigationMenuNavigation  5      %    MenuNavigation.Views.AddStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MenuNavigation.Views     5      +nsclr-namespace:MenuNavigation     5        N� Title$  
AddStudent��5
       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      �� 5      �� 5      �� 5      $��30 �6   �� 5      �� 5      �� 5       .+�5"   
   �� $��5,5,5,5q�6-   $��1��6>   $��1��6K   ��6   !   MenuNavigation.LocExtension  *
NameText+6K   �� 5#   
   $��5,3,5,5q�6G   $��3��5$      $��1��6&   $��2��63   $��18(�5%      ��5#      ��  �� Path$ 	Stud.Name� �� Mode$ OneWayToSource=�5%      �� 5&   
   $��2��61   $��1��6>   $��5,5,5,5q�5'      ��5&        *LastnameText+5'      �� 5(   
   $��2��6K   $��2��6X   $��5,3,5,5q�5)      $��3��6#   $��18(�67   ��5(      �� $ Stud.Lastname�$ OneWayToSource=�5)   7   �� 5*   
   $��3��6.   $��1��6;   $��5,5,5,5q�6K   ��6     *	IndexText+6K   �� 5+   
   $��3��6H   $��2��6U   $��5,3,5,5q�5,      $��3��6#   $��18(�5-      ��5+      �� $ 
Stud.Index�$ OneWayToSource=�5-      �� 5.   
   $��4��6   $��2��6   $��5,5,5,5q�6.   ��6?     *AddBtn+��5/      �� $ AddStudentCommand�50      51      