   M S B A M L   `   `   `  ����C  ?Customer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Customer.ViewCustomer.View  5   	   %    Customer.View.MusteriWindowView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Customer.View     5   	     � Title$  MusteriWindowView��5   	   $	��500��6#   $	��800��60   .��5	      � .+�5   
   �� -   5        $��UserGrid��5      $
��Left=�6k   $	��209��6�   $��
10,200,0,0q�6�   $	��Top=�6�   $	��547��6�   ��6#   �� *MusteriList+ �� SelectedItem 6G   �� *
SelectItem+ �� View 5      �� 5      .P�5      �� $��	MusteriID��6%    �� Width$ 80��6o    �� DisplayMemberBinding 68   �� *	MusteriID+ �� Mode$ TwoWay=�6o   �� 5      $	��Adi��6%   $ 80��6c    62   �� *Adi+$ TwoWay=�6c   �� 5      $��Soyadi��6%   $ 80��6i    65   �� *Soyadi+$ TwoWay=�6i   �� 5      $��TelefonNumarısı��6%   $	 100��6u    6>   �� *	TelefonNo+$ TwoWay=�6u   �� 5      $��Adres��6%   $	 120��6g    64   �� *Adres+$ TwoWay=�6g   �� 5      $��Bakiye��6%   $ 80��6i    65   �� *Bakiye+$ TwoWay=�6i   5      5      �� 5   
   $
��Left=�6T   $��22��6o   $��
153,22,0,0q�6{    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   ��  �� ElementName$ UserGrid�� �� Path$ SelectedItem.MusteriID�6�   �� 5   
   $
��Adı��6   $
��Left=�6   $��	60,44,0,0q�69   $	��Top=�6L   �� 5   
   $
��Left=�6   $��	60,75,0,0q�6+   $	��Top=�6>   �� 5   
   $��Soyadı��6   $
��Left=�6!   $��	60,70,0,0q�6<   $	��Top=�6O   �� 5   
   $��	TelefonNo��6   $
��Left=�6$   $��
60,101,0,0q�6?   $	��Top=�6S   �� 5   
   $��Adres��6   $
��Left=�6    $��
60,132,0,0q�6;   $	��Top=�6O   �� 5   
   $��	MusteriID��6   $
��Left=�6$   $��	60,18,0,0q�6?   $	��Top=�6R   	 J� RenderTransformOrigin$	 0.619,-0.372&�6j   �� 5   
   $��Bakiye��6   $
��Left=�6!   $��
60,158,0,0q�6<   $	��Top=�6P   �� 5   
   $
��Left=�6N   $��22��6i   $��
153,49,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ UserGrid��$ SelectedItem.Adi�6�   �� 5    
   $
��Left=�6U   $��22��6p   $��153,105,0,0q�6|   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ UserGrid��$ SelectedItem.TelefonNo�6�   �� 5!   
   $
��Left=�6R   $��22��6m   $��
153,76,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ UserGrid��$ SelectedItem.Soyadi�6�   �� 5"   
   $
��Left=�6R   $��22��6m   $��153,162,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ UserGrid��$ SelectedItem.Bakiye�6�   �� 5#   
   $
��Left=�6Q   $��22��6l   $��153,132,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ UserGrid��$ SelectedItem.Adres�6�   �� 5$   
   $��	Güncelle��6   $
��Left=�6D   $��
353,24,0,0q�6_   $	��Top=�6s   $��75��6�   ��6$   �� *SaveMusteri+6�   �� 5%   
   $	��Sil��6   $
��Left=�6A   $��
353,60,0,0q�6\   $	��Top=�6p   $��75��6�   ��6   �� *DeleteMusteri+6�   �� 5&   
   $��	Yeni Kisi��6   $
��Left=�6B   $��353,101,0,0q�6]   $	��Top=�6r   $��75��6�   ��6%   �� *
YeniKisi+6�   5'      5(      