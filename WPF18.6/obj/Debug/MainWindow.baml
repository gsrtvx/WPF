   M S B A M L   `   `   `  ����B  >WPF18.6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF18._6WPF18._6  5   	       WPF18._6.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF18._6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ helloButton��5
      
�������$��70��69   $��25��6D   $��Кнопка��6P   ��5      �� 5      -   5        buttonColor�� �� Color$ Black��5   7    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   [�5      �� 5      .��5      �� .��5   "   W�  �� TargetProperty$ Width�62    �� 
TargetName$ helloButton��6T    W� From$ 80X�5      	 W� To$	 150X�6)   	 g� AutoReverse	 . 
 g� RepeatBehavior$
 0:0:10��6F    g� Duration$ 0:0:2D�6^   W� 5   "   $ Height�62   $ helloButton��6U   $ 30X�5      $	 100X�6)   	 . $
 0:0:10��6E   $ 0:0:2D�6]   �� 5   "   $ buttonColor��61   $ Color�6U   	 �� To$	 RedX�5   T   	 . $
 0:0:10��5   2   $ 0:0:2D�6J    �� From 5      ��  �� ElementName$ buttonColor�� �� Path$ Color�5   J   5      5      5      5      5       5!      