   M S B A M L   `   `   `  ����  Okurleiga hf5    /Okurleiga_hf.Windows.NewApartmentIncidentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullV RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5           MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#��[ 5   	    � Title$ Atvikaskráning��5   	   $��446.25��6    $��463.438��60   .��5      � .+�5   
   o� $
��Auto��6   $	��Top=�6   .@�5      m� $��Skrá��6   .@�5      m� $��Nýtt atvik��6    m� Icon 5      '  !MaterialDesignThemes.Wpf.PackIcon  5      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Create=�62   5      m� 5      $��	Prenta...��6    5        5      $ Printer=�62   5      m� 5      $��Vista��6    5        5       $ ContentSave=�62   5"      m� 5#      $��Hætta��6    5$        5%      $ Close=�62   5'      5(      5)      �� 5*   
   $
��Left=�6   $��23��6-   $��
95,191,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   �� 5+   
   $
��Left=�6   $��	37,85,0,0q�6/   $
��Wrap=�6B   $��Dags. Atviks��6V   $	��Top=�6j   �� 5,   
   $
��Left=�6   $��
37,120,0,0q�6/   $
��Wrap=�6C   $��Tilkynanndi��6W   $	��Top=�6j   �� 5-   
   $
��Left=�6   $��
42,159,0,0q�6/   $
��Wrap=�6C   $��Staða:��6W   $	��Top=�6e   �� 5.   
   $
��Left=�6   $��
42,195,0,0q�6/   $
��Wrap=�6C   $��Verktaki��6W   $	��Top=�6g   �� 5/   
   $
��Left=�6   $��	37,48,0,0q�6/   $
��Wrap=�6B   $��
Húsnæði��6V   $	��Top=�6e   �� 50   
   $
��Left=�6+   $��
95,147,0,0q�6F   $	��Top=�6Z   $	��120��6r    �� SelectedIndex$ 0��6~    �� Text 6   �� *Status+.@�51      �� .��6   Nýtt6!   �� 52      .��6   
Í vinnslu6&   �� 53      .��6   Lokið6"   54      �� 55   
   -   5         ��Name$ cbApartments��55      	 �� DisplayMemberPath$	 Address��6A   $
��Left=�6�   $��
114,40,0,0q�6�   $	��Top=�6�   $	��143��6�   ��6)   �� 
 �� SelectedItem
 6]   �� *	Apartment+6�   (  "System.Windows.Controls.DatePicker  56   
   $
��Left=�6   $��
137,73,0,0q�60   $	��Top=�6D   $	��120��6\   �� 57   
   -   5        $��Vista��57      $
��Left=�6!   $��275,295,0,0q�6<   $	��Top=�6Q   $��75��6i    �� 	IsDefault . ���	#FF35B219���	#FF373638$
��Bold"�6�   $��Arial Black)�6�   �� 58   
   -   5        $��Hætta��58      $
��Left=�6!   $��182,295,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   �� 59   
   -   5         ��Name$ tbInfo��59        WatermarkTextbox#��[ 6"   $
��Left=�6j   $��26��6�   $��
42,231,0,0q�6�   $
 Wrap=�6�    �� TextAlignment$
 Left=�6�   $	��Top=�6�   $	��215��6�   ��6L   �� *IncidentInfo+6�   �� 5:   
   -   5        $ cbEmployees��5:      $	 FullName��6@   $
��Left=�6�   $��114,108,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6(   �� 
 6]   �� *RegisterName+6�   5<      5=      