   M S B A M L   `   `   `  ����I  EMenuNavigation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MenuNavigation.ViewsMenuNavigation.Views  5      /clr-namespace:MenuNavigationMenuNavigation  5      E'clr-namespace:MenuNavigation.ConvertersMenuNavigation.Converters  5      &     MenuNavigation.Views.ViewStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MenuNavigation.Views     5      +nsclr-namespace:MenuNavigation     5      8conv'clr-namespace:MenuNavigation.Converters     5        N� Title$  ViewStudent��5       N� 
Background
 ����� � 	Resources 5      4  .MenuNavigation.Converters.ObjectToUriConverter   objToUri �� 
TargetType  editBtn �� Property �� Value ��Name �� 	Converter �� Triggers	 P� Property
 P� Value �� 
TargetName �� Color��%L  &	        &	      7   '�� �    '�� �      5   
   67   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      .R�5      �� $ 	borderBtn��6!   
������ 
������ ._�5      �� ��6$   �� *Tag+8   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   �� $ 	borderBtn��6?    � �� 5   &   �� 5   *   $
 Blue��6:   5   #   5      5      5       5!      �� 5"   
   " ��6   .�5#      ��  � ��$
 Left=�64   5$      �� 5%   
   " ��6   .�5&      ��  � ��
 ��  �6%   5'      5(       J� InputBindings 5)      �� 5*   
    �� 	Modifiers$	 Altf�6   
 �� Key$ C��6%    �� Command 5+      ��  �� Path$ CancelEditCommand�.��5.      �  � RowDefinitions 5/   
   �� 50      $��5* �6   �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $
��Auto �6   �� 54      �� 55      �� 56      �� 57       � ColumnDefinitions 59   
   �� 5:      �� 5;      $
��Auto �6   �� 5<      �� 5=      �� 5>      �� 5?      $��30 �6   �� 5@      �� 5A      �� 5B      .+�5D   
   �� $��5,5,5,5q�6-   $��1��6>   $��1��6K   ��6   !   MenuNavigation.LocExtension  *
NameText+6K   �� 5E   
   $��5,3,5,5q�6-   $��3��5F      $��1��6&   $��2��63   $��18(�5G      ��5E      �� $
 Name�{�5G       �� *IsEnabledName+�� 5H   
   $��1��6   $��5��6   $��5,5,5,5q�6.   #��[ 6?   ��5I      �� $ EditingNameCommand�
 � Tag 6=   �� *ImageBtnUri+5J      �� 5K   
   $��2��61   $��1��6>   $��5,5,5,5q�5L      ��5K        *LastnameText+5L      �� 5M   
   $��2��61   $��2��6>   $��5,3,5,5q�5N      $��3��6#   $��18(�67   ��5M      �� $ Lastname�{�5O      �� *IsEnabledLastname+�� 5P   
   $��2��6   $��5��6   $��5,5,5,5q�6.   #��[ 6?   ��5Q      �� $ EditingLastnameCommand� 6A   �� *ImageUriBtnLastname+�� 5R   
   $��3��6.   $��1��6;   $��5,5,5,5q�6K   ��6     *	IndexText+6K   �� 5S   
   $��3��6.   $��2��6;   $��5,3,5,5q�5T      $��3��6#   $��18(�5U      ��5S      �� $ Index�{�5U       �� *IsEnabledIndex+�� 5V   
   $��3��6   $��5��6   $��5,5,5,5q�6.   #��[ 6?   ��5W      �� $ EditingIndexCommand� 6>   �� *ImageUriBtnIndex+�� 5X   
   $��4��6   $��2��6   $��5,5,5,5q�6.   ��6?     *	EditBtn+��5Y      �� $ EditCommand��� 5Z   
   $��4��6   $��4��6   $��5,5,5,5q�6.   ��6?     *	CancelBtn+��5[      �� $ CancelEditCommand�5\      5]      