   M S B A M L   `   `   `  ����F  BQuicNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuicNotepadQuicNotepad  5      !    QuicNotepad.NoteItemControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuicNotepad     5      $��30��5	      $	��Top=�5
        � 	Resources  5         NoteItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name  ListItemGrayBrush � ColumnDefinitions  FontSizeSmall  Segoe UI  FontLightGrayBrush  NoteControlButton �� Triggers :� RoutedEvent  ListItemLightGray		 �� To
 g� Duration �� 
TargetName �� TargetProperty  ListItemGray��%�  &	        7  7  7  7  7  7  7  7  �� 5   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � $
 grid��6   8��   5      �� 5   "   $��* �63   �� 5   "   $��30 �63   �� 5   "   $��30 �63   �� 5   "   $��12 �63   .+�5      �� $
��Left=�5   %   $��Center=�5   %   $��6 0 0 0q�5   %   8�� 8�� 8�� ��5   %   �� *
NoteName+�� 5       $��1��6%   8�� $	��✏��5!   %   5"      �� 5#      $��2��6%   8�� $	��✖��5$   %   5%      5&       5'      :� 5(      $ 
MouseEnter��6+   .[�5)   "   �� .��5*   &   �� .��5+   *   �� 8	  $
 0:0:0.08D�6a   $
 grid��6u   $/ )(Grid.Background).(SolidColorBrush.Color)�6�   5,   '   5-   #   5.      :� 50      $ 
MouseLeave��6+   .[�51   "   �� .��52   &   �� .��53   *   �� 8	  $
 0:0:0.08D�6\   $
 grid��6p   $/ )(Grid.Background).(SolidColorBrush.Color)�6�   54   '   55   #   56      59      5;      5<      5=      .��5?      ��    QuicNotepad.NoteItemDVM   	Singleton � DataContext# Z 5@   
   #��[  5A   	   5C      