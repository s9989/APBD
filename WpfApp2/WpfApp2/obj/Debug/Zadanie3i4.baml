   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.Zadanie3i4   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
Zadanie3i4��5	   	   $	��450��6   $	��800��6)   .��5
      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ StudentsDataGrid��5   �      CanUserAddRows .     
IsReadOnly . $	��200��6�   6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��5q�6J   .+�5      �� $��Right=�6   .��60   Imię66   �� 5      -   5         ��Name$
 Imie��5   "   $	��500��6   62   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��5q�6J   .+�5      �� $��Right=�6   .��60   
Nazwisko6:   �� 5      -   5        $ Nazwisko��5   "   $	��500��6   66   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��5q�6J   .+�5      �� $��Right=�6   .��60   
Nr indeksu6<   �� 5      -   5        $ 	NrIndeksu��5   "   $	��500��6   67   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��5q�6J   .+�5      �� -   5         ��Name$ Dodaj��5      $	��5 0q�6$   $	��100��62   $��	0 0 300 0q�6>   .��6e   Dodaj6l   �� 5      -   5        $
 Usun��5      $	��5 0q�6#   $	��100��61   .��6P   Usuń6V   5      5      5      