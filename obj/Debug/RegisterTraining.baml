   M S B A M L   `   `   `  ����M  ITreningiPersonalne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TreningiPersonalneTreningiPersonalne  5   	   )    #TreningiPersonalne.RegisterTraining   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TreningiPersonalne     5   	     � Title$  RegisterTraining��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��TrainersDataGrid��5
   '   $��
0,10,0,301q�6   ��6?   ��  �� Source$ trainersList��5      �� 5   
   $��Id Trenera:��6   $
��Left=�6&   $��
10,174,0,0q�6A   $	��Top=�6U   $��43��6m   $	��105��6y   �� 5   
   $��Data:��6   $
��Left=�6    $��
10,234,0,0q�6;   $	��Top=�6O   $��32��6g   $��81��6s   �� 5   
   $��Godzina:��6   $
��Left=�6#   $��
10,299,0,0q�6>   $	��Top=�6R   $��32��6j   $��81��6v   �� 5   
   -   5        $��IdBox��5   �   $
��Left=�6   $��115,174,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $��Id��6V   $	��Top=�6`   $	��120��6x   $��29��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DatePickBox��5   u   $
��Left=�6   $��115,234,0,0q�60   $	��Top=�6E   $	��120��6]   $��32��6i   6u   �� 5   
   -   5        $��HourBox��5   �   $
��Left=�6   $��115,302,0,0q�6-   $
 Wrap=�6B   $��00:00��6V   $	��Top=�6c   $	��120��6{   $��26��6�   6�   �� 5   
   $��Czas Trwania:��6   $
��Left=�6(   $��
10,355,0,0q�6C   $	��Top=�6W   $��81��6o   $��43��6z   �� 5   
   -   5         ��Name$ 
TimeLength��5   �   $
��Left=�6   $��115,355,0,0q�6-   $
 Wrap=�6B   $��00:00��6V   $	��Top=�6c   $	��120��6{   $��26��6�   6�   5      5      