   M S B A M L   `   `   `  ����  Pra.Wine.Keeper.Wpf$    Pra.Wine.Keeper.Wpf.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Wine Keeper��5   	   $	��300��6   $	��650��6*   .��5      � .+�5	   
   �� $$��resources/magnifying-glass.png��6   $��20��68   $
��Left=�6D   $	��Top=�6_   $��230, 12, 10, 10q�6w   �� 5
   
   -   5         ��Name$ 	txtFilter��5
      $
��Left=�6%   $	��Top=�6@   $��10, 10, 10, 10q�6X   $	��100��6p   $��25��6|   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dtpFilter��5      $
��Left=�6(   $	��Top=�6C   $��115, 10, 10, 10q�6[   $	��110��6t   $��25��6�   6�   �� 5   
   -   5         ��Name$ lstWine��5       �� DisplayMemberPath$ Description��6;   $
��Left=�6[   $��Stretch=�6v   $��10, 40, 10, 10q�6�   $	��285��6�   ��6#   �� 6�   �� 5   
   -   5         ��Name$ 
btnAddWine��5      $��+��6%   $	��Top=�61   $
��Left=�6I   $��275, 13, 10, 10q�6d   $��20��6}   $��20��6�   ���	#FF96F98D6�   �� 5   
   -   5        $ btnDrinkBottle��5      $��
Drink fles��6)   ${�False��6>   $��Right=�6P   $	��Top=�6l   $��0, 12, 20, 0q�6�   6�   �� 5   
   -   5         ��Name$ grpWineDetails��5      $
{�True��6+   $��Gegevens wijnsoort��6<   $��Stretch=�6X   $��300,30,10,10q�6v   .��5      � .+�5      �� $��Omschrijving:��6   $��10q�60   �� 5      -   5        $ txtDescription��5      $	��190��62   $
��Left=�6>   $	��Top=�6Y   $��110, 15, 0, 0q�6q   �� 5      $��Bewaartijd:��6   $��10, 40, 10, 10q�6.   �� 5      -   5        $ txtMinStorage��5      $��35��61   $
��Left=�6<   $	��Top=�6W   $��110, 45, 15, 0q�6o   �� 5      $	��tot��6   $��30��6&   $
��Left=�61   $	��Top=�6L   $��150, 40, 10, 0q�6d   �� 5      -	   5        $ txtMaxStorage��5      $��35��61   $
��Left=�6<   $	��Top=�6W   $��180, 45, 15, 0q�6o   �� 5      $��maanden��6   $��60��6*   $
��Left=�65   $	��Top=�6P   $��220, 40, 10, 0q�6h   �� 5      $��Aankoopdatum:��6   $��10, 70, 10, 10q�60     5      -
   5        $ dtpPurchaseDate��5      $
��Left=�66   $	��Top=�6Q   $��110, 72, 0, 0q�6i   �� 5      $��Aantal flessen:��6   $��10, 100, 10, 10q�62   �� 5      -   5        $ txtNumBottles��5      $��35��61   $
��Left=�6<   $	��Top=�6W   $��110, 105, 15, 0q�6o   �� 5      -   5        $ btnSave��5      $y�Hidden=�6*   $��Bewaren��6>   $
��Left=�6P   $	��Top=�6k   $��15, 135, 0, 10q�6�   $��5q�6�   6�   �� 5      -   5        $ 	btnCancel��5      $y�Hidden=�6,   $��	Annuleren��6@   $
��Left=�6T   $	��Top=�6o   $��80, 135, 0, 10q�6�   $��5q�6�   6�   5      5      5       5!      