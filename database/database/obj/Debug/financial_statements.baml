   M S B A M L   `   `   `  ����C  ?database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:databasedatabase  5   	   #    database.financial_statements   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:database     5   	   -   5          � Title$  financial_statements��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$# financial_statements_DataGrid��5
      $
��Left=�6;   $	��409��6V   $��	386,0,0,0q�6c   $	��Top=�6v   $	��396��6�   6�   �� 5   
   -   5         ��Name$ Add_btn��5      $	��Add��6"   $
��Left=�60   $��
29,342,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5   
   -   5        $ 
Update_btn��5      $��Update��6%   $
��Left=�66   $��165,342,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 
Delete_btn��5      $��Delete��6%   $
��Left=�66   $��306,342,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 	Reset_btn��5      $��Reset��6$   $
��Left=�64   $��165,390,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ Back_btn��5      $
��Back��6#   $
��Left=�62   $��306,390,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5         ��Name$ labe1��5      $��
manager-id��6   $
��Left=�64   $��	66,94,0,0q�6O   $	��Top=�6b    J� RenderTransformOrigin$ -0.289,1.687&�6z   �� 5   
   -	   5        $ labe2��5      $��total-salary��6   $
��Left=�66   $��
66,124,0,0q�6Q   $	��Top=�6e   �� 5   
   -
   5        $ labe3��5      $��utilities-cost��6   $
��Left=�68   $��
66,154,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $ labe4��5      $��commodity-cost��6   $
��Left=�68   $��
66,184,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $ labe5��5      $��commodity-income��6   $
��Left=�6:   $��
66,214,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ labe6��5      $��miscellaneous-cost��6   $
��Left=�6<   $��
66,244,0,0q�6W   $	��Top=�6k   $ 0.244,-0.104&�6�   �� 5   
   -   5         ��Name$ manager_id_txtbx��5      $
��Left=�6,   $��23��6G   $��
197,94,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ total_salary_txtbx��5      $
��Left=�6/   $��23��6J   $��197,124,0,0q�6V   $
 Wrap=�6k   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ utilities_cost_txtbx��5      $
��Left=�60   $��23��6K   $��197,154,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ commodity_cost_txtbx��5      $
��Left=�60   $��23��6K   $��197,184,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ commodity_income_txtbx��5      $
��Left=�62   $��23��6M   $��197,214,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ miscellaneous_cost_txtbx��5      $
��Left=�64   $��23��6O   $��197,244,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   $ -0.158,-0.722&�6�   �� 5   
   $��Information��6   $
��Left=�6(   $	��234��6C   $��	56,48,0,0q�6P   $	��Top=�6c   $	��273��6{   5      5       