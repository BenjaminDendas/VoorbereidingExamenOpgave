   M S B A M L   `   `   `  ����T  PVoorbereidingExamenOpgave, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:VoorbereidingExamenOpgaveVoorbereidingExamenOpgave  5   	   3    -VoorbereidingExamenOpgave.UpdateMonsterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:VoorbereidingExamenOpgave     5   	     � Title$  UpdateMonsterWindow��5   	   $	��300��6%   $	��300��62   .��5	      � .+�5
   
   �� -   5         ��Name$ hpLabel��5
      $��HP��6!   $
��Left=�6.   $��	49,45,0,0q�6I   $	��Top=�6\   $��56��6t   �� 5   
   -   5        $ attackLabel��5      $��Attack��6%   $
��Left=�66   $��	49,87,0,0q�6Q   $	��Top=�6d   $��56��6|   �� 5   
   -   5        $ 
aliveLabel��5      $��Alive��6$   $
��Left=�64   $��
49,125,0,0q�6O   $	��Top=�6c   $��56��6{   �� 5   
   -   5        $ 	nameLabel��5      $
��Name��6#   $
��Left=�62   $��
49,167,0,0q�6M   $	��Top=�6a   $��56��6y   �� 5   
   -   5         ��Name$ nameTextBox��5      $
��Left=�6'   $��23��6B   $��149,170,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6�   $	��120��6�   ��6w   ��  �� Path$
 Name� �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ attackTextBox��5      $
��Left=�6)   $��23��6D   $��
149,90,0,0q�6P   $
 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� $ Attack�$ TwoWay=�6�   �� 5   
   -   5         ��Name$ aliveCheckBox��5      $�� ��6*   $
��Left=�65   $��149,128,0,0q�6P   $	��Top=�6e   $��23��6}   $��27��6�    d� 	IsChecked 6�   �� $ Alive�$ TwoWay=��� 5   
   -   5        $ 	hpTextBox��5      $
��Left=�6%   $��23��6@   $��
149,45,0,0q�6L   $
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� $ HP�$ TwoWay=�6�   �� 5   
   -	   5         ��Name$ updateButton��5      $��Update��6'   $
��Left=�68   $��
49,212,0,0q�6S   $	��Top=�6g   $	��220��6   6�   5      5      