   M S B A M L   `   `   `  ����  	StrandWPF    StrandWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Fürdők��5   	   $	��450��6   $	��900��6%   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��10q�6%   .+�5      �� $��Fürdő adatai��6   $��20(�6,   $��0,0,0,10q�6:   �� 5      $��Név:��6   $��0,0,0,5q�6$   �� 5      -   5         ��Name$ 
nevTextBox��5       �� 
IsReadOnly . $��0,0,0,10q�6<   �� 5      $��Cím:��6   $��0,0,0,5q�6$   �� 5      -   5        $ 
cimTextBox��5       . $��0,0,0,10q�6<   �� 5      $
��Ár:��6   $��0,0,0,5q�6#   �� 5      -   5        $ 	arTextBox��5       . $��0,0,0,10q�6;   �� 5      $��Vízhőfok:��6   $��0,0,0,5q�6)   �� 5      -   5        $ vizhofokTextBox��5       . $��0,0,0,10q�6A   � 5      -   5         �Name$ vizhofokProgressBar��5       � Minimum$ 0Q�67    � Maximum$	 100Q�6C   $��0,0,0,10q�6Q   �� 5      -   5         ��Name$ mentesButton��5      $��Mentés��6+   $��10q�6<   $��5q�6H   6T   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ furdoDataGrid��5   #   $��1��6   	   AutoGenerateColumns	 .  
   
IsReadOnly
 .    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Név��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nev+  5"      $
 Cím��6%    62   �� *Cim+  5#      $	 Ár��6%    61   �� *Ar+  5$      $ 
Vízhőfok��6%    67   �� *
Vizhofok+5&      5'      5(      