   M S B A M L   `   `   `  ����I  EMenuNavigation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MenuNavigation.ViewsMenuNavigation.Views  5      /clr-namespace:MenuNavigationMenuNavigation  5      &     MenuNavigation.Views.SubjectView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MenuNavigation.Views     5      +nsclr-namespace:MenuNavigation     5        N� Title$  SubjectView��5
       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      �� 5      .+�5   
   �� $��1��64   $��Center=�5      $��32(�6/   $��2��6=   ��5      !   MenuNavigation.LocExtension  *SubjectOverview+5   =   �� 5   
   $��1��6-   $��18(�6:   $��10,10,10,10q�6H   ��6     *
NameText+6H   �� 5   
   $��1��6*   $��1��6:   $��Center=�5      $��18(�6/   $��10,10,10,10q�6=   ��5      �� *Name+5   =   �� 5    
   $��2��60   $��18(�6=   $��10,10,10,10q�6K   ��6     *TeacherText+6K   �� 5!   
   $��18(�65   $��2��6C   $��1��6P   $��10,10,10,10q�6`   ��6   �� *TeacherFullName+6`   �� 5"   
   $��18(�66   $��3��6D   $��10,10,10,10q�6Q   ��6     *StudentsAttending+6Q   �� 5#   
   -   5        $��TeachersListView��5$      $��3��5#   4   $��1��6A   $��	10,10,0,0q�5$   +   ��5#      �� *
Students+ �� View 5%      �� 5&      .P�5'      �� ��6%     *
NameText+ �� DisplayMemberBinding 6@   ��  �� Path$
 Name��� 5(      ��6%     *LastnameText+ 6D   �� $ Lastname��� 5)      ��6%     *	IndexText+ 6A   �� $ Index�5*      5,      5-      5.      