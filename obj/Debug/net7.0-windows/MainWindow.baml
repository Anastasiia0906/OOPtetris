   M S B A M L   `   `   `  ����  курсова1    Tetris.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Tetris��5   	   $	��600��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�5   	   
������� � WindowStyle$
 None=�5
   	    � 	Resources 5         TitleGradient �� 
StartPoint �� EndPoint � Color � Offset �� 
TargetType  ColorfulButton	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value �� ScaleX �� ScaleY��%�  &	        &	 �     �� 5   
   $	 0,0&�64   $	 1,1&�6E   .��5      � $ 	#FF00FFE4��6   $	 0.0Q�6-   � 5      $ 	#FF00FF9D��6   $	 0.5Q�6-   � 5      $ 	#FF9600FF��6   $	 1.0Q�6-   5      �� 5   
   " ��6   .�5      �� 	 � ��

 �����6+   �� 5      	 � ��$
 18(�6)   �� 5      	 � ��$

 Bold"�6+   �� 5      	 � ��$	
 250��6&   �� 5      	 � ��$
 60��6'   �� 5      	 � ��$

 0,15q�6'   �� 5      	 �@�Cursor$

 Hand��6'   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 12��5   !   #��z��5    !   $��0q�5!   !   ._�5"      �� $��Center=�6/   $��Center=�5#   -   5$      5%      5'       5(      P� 5)       �@J�IsMouseOver$
 True��61   . �5*      �� 	 �@J�Opacity$	
 0.8Q�60   �� 5+      	 � z�
 5,      �� 5-      $
 1.05Q�6-   $
 1.05Q�6;   5/      50      52      53      .��55      � -   5         �Name$ MainGrid��55      .+�56   
   �� -   5         ��Name$ BackgroundCanvas��56       J� Opacity$
 0.15Q�6+   � 59   
   -   5        $ MainMenu��59      $y�Visible=�6!   .+�5:      �� $��Center=�6   $��Center=�64   .+�5;      �� -   5         ��Name$ TitleTextBlock��5;      $��TETRIS��5<      #��[  5=      $��80(�5>      $
��Bold"�5?      $��Arial Black)�5@      $��Center=�5A      $��0,0,0,50q�5B       J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         Color$ 	#AA00FFFF��6+      
BlurRadius$ 25Q�6=      ShadowDepth$ 5Q�6M      Opacity$	 0.8Q�6]   5F      �� 5H      -   5         ��Name$ StartButton��5H      $��ПОЧАТИ ГРУ��5I      ���	#FF4CAF50#��[ 5K      5L      �� 5N      -   5        $ SettingsButton��5N      $��НАЛАШТУВАННЯ��5O      ���	#FF2196F3#��[ 5Q      5R      �� 5T      -   5        $ ThemeButton��5T      $��ТЕМНА ТЕМА��5U      ���	#FF9C27B0#��[ 5W      5X      �� 5Z      -   5        $ 
ExitButton��5Z      $��
ВИЙТИ��5[      ���	#FFF44336#��[ 5]      5^      5_      5`      5a      5b      