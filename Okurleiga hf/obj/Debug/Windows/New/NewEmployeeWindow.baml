   M S B A M L   `   `   `  ����  Okurleiga hf0    *Okurleiga_hf.Windows.New.NewEmployeeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullV RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   -   5           MaterialDesignBody#���   5      $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5	   	      TextRenderingMode$
 Auto=�5
   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#��[ 5   	    � Title$ Skrá nýjan starfsmann��5   	   $	��450��6'   $	��800��64   .��5      � $	��Top=�6   $��
16,16,16,0q�6#   $	��106��67    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $	��927 �6   �� 5      $��4 �6   �� 5      $
��Auto �6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6"   $��Center=�61   $��2��6L   $��
19,30,0,60q�6\   �� 5   
   $��2��6   $��43,32,831,58q�6$   $��Center=�6:   $��16��6U   	Fornafn6j   �� 5   
   $��2��6   $��158,32,628,50q�6"   $��Center=�69   $��24��6T   ��6`   �� *	FirstName+6~     5   
   $ Account=�6"   $��Center=�61   $��
19,60,0,30q�6L   $��2��6`   �� 5   
   $��2��6   $��43,62,831,28q�6$   $��Center=�6:   $��16��6U   �� 6b   $�	Eftirnafn��6f   6z   �� 5   
   $��2��6   $��158,62,628,20q�6"   $��Center=�69   $��24��6T   ��6`   �� *
LastName+  5   
   $ Numeric=�6"   $��Center=�61   $��	19,90,0,0q�6L   $��2��6_   �� 5   
   $��2��6   $��43,92,831,-2q�6$   $��Center=�6:   $��16��6U   �� 6b   $�	Kennitala��6f   6z   �� 5    
   $��2��6   $��158,88,628,-6q�6"   $��Center=�69   $��24��6T   ��6`   �� *SocialNumber+  5!   
   $ Email=�6"   $��Center=�6/   $��19,120,0,-30q�6J   $��2��6`   �� 5"   
   $��2��6   $��43,122,831,-32q�6$   $��Center=�6<   $��16��6W   �� 6d   $�Netfang��6h   6z   �� 5#   
   $��2��6   $��158,118,628,-36q�6"   $��Center=�6;   $��24��6V   ��6b   �� *Email+  5$   
   $ Phone=�6"   $��Center=�6/   $��19,150,0,-60q�6J   $��2��6`   �� 5%   
   $��2��6   $��43,152,831,-62q�6$   $��Center=�6<   $��16��6W   �� 6d   $�Sími��6h   6w   �� 5&   
   $��2��6   $��158,148,628,-66q�6"   $��Center=�6;   $��24��6V   ��6b   �� *Phone+  5'   
   $ UserAddress=�6"   $��Center=�65   $��15,178,0,-88q�6P   $��2��6f   �� 5(   
   $��2��6   $��43,178,811,-88q�6$   $��Center=�6<   $��16��6W   �� 6d   $�Heimilisfang��6h   6   �� 5)   
   $��2��6   $��158,174,628,-92q�6"   $��Center=�6;   $��24��6V   ��6b   �� *	Address+  5*   
   $
 City=�6"   $��Center=�6.   $��15,203,0,-113q�6I   $��2��6`   $��18��6p   �� 5+   
   $��2��6   $��43,207,835,-117q�6$   $��Center=�6=   $��16��6X   �� 6e   $
�Borg��6i   6x   �� 5,   
   $��2��6   $��158,203,628,-121q�6"   $��Center=�6<   $��24��6W   ��6c   �� *City+�� 5-   
   $��2��6   $��43,239,811,-149q�6$   $��Center=�6=   $��16��6X   �� 6e   $�Póstnúmer��6i   6}   �� 5.   
   $��2��6   $��158,231,628,-149q�6"   $��Center=�6<   $��24��6W   ��6c   �� *Zip+  5/   
   $ Phone=�6"   $��Center=�6/   $��17,239,0,-149q�6J   $��2��6a     50   
   $ 	DateRange=�6"   $��Center=�63   $��17,266,0,-176q�6N   $��2��6e   $��18��6u   �� 51   
   $��2��6   $
��Left=�6$   $��43,266,0,-176q�6?   $
��Wrap=�6V   $��Dags. Ráðningar��6j   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  52   
   $��2��6   $
��Left=�6%   $��22��6@   $��158,260,0,-176q�6L   $	��Top=�6d   $	��141��6|      Text 6�   �� *	DateStart+�� 53   
   -   5         ��Name$ btnSaveClick��53      $��Vista��6'   $��2��67   $
��Left=�6G   $��626,285,0,-211q�6b   $	��Top=�6z   $��75��6�   6�   �� 54   
   -   5        $ btnQuitClick��54      $��Hætta��6'   $��2��67   $
��Left=�6G   $��529,285,0,-211q�6b   $	��Top=�6z   $��75��6�   6�   55      56      