   M S B A M L   `   `   `  ����A  =Memory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemoryMemory  5          Memory.InstellingenPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Memory     5        N� Title$  InstellingenPage��5	      $	��775��6    $	��410��6,   $	��775��69   $	��410��6H    � 	Resources 5       !  RadioButton.Static.Background �� Color  RadioButton.Static.Border  RadioButton.Static.Glyph $  RadioButton.MouseOver.Background   RadioButton.MouseOver.Border  RadioButton.MouseOver.Glyph ' #RadioButton.MouseOver.On.Background # RadioButton.MouseOver.On.Border " RadioButton.MouseOver.On.Glyph #	 RadioButton.Disabled.Background 
 RadioButton.Disabled.Border  RadioButton.Disabled.Glyph & "RadioButton.Disabled.On.Background " RadioButton.Disabled.On.Border ! RadioButton.Disabled.On.Glyph " RadioButton.Pressed.Background  RadioButton.Pressed.Border  RadioButton.Pressed.Glyph " RadioButton.Checked.Background  RadioButton.Checked.Border  RadioButton.Checked.Glyph  ToggleSwitchTopStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name J� SnapsToDevicePixels'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard	 W� To g� Duration �� 
TargetName �� TargetProperty R� KeyTime R� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value � RowDefinitions ��Name ��Name J� Opacity �� CornerRadius A�Name J� RenderTransformOrigin T� X��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		 ;    &	
 ^    &	 �    &	 �    &	 �    &	 �    &	     &	 0    &	 S    &	 v    &	 �    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7  7  7  7  7  7  7 
 7 	 7  7  �� 5   
   $ 	#FFFFFFFF��6@   �� 5   
   $ 	#FF333333��6<   �� 5   
   $ 	#FF333333��6;   �� 5   
   $ 	#FFFFFFFF��6C   �� 5   
   $ 	#FF000000��6?   �� 5   
   $ 	#FF000000��6>   �� 5   
   $ 	#FF4C91C8��6F   �� 5   
   $ 	#FF4C91C8��6B   �� 5   
   $ 	#FFFFFFFF��6A   �� 5   
   $ 	#FFFFFFFF��6B   �� 5   
   $ 	#FF999999��6>   �� 5   
   $ 	#FF999999��6=   �� 5   
   $ 	#FFCCCCCC��6E   �� 5    
   $ 	#FFCCCCCC��6A   �� 5!   
   $ 	#FFA3A3A3��6@   �� 5#   
   $ 	#FF999999��6A   �� 5$   
   $ 	#FF999999��6=   �� 5%   
   $ 	#FFFFFFFF��6<   �� 5'   
   $ 	#FF0063B1��6A   �� 5(   
   $ 	#FF0063B1��6=   �� 5)   
   $ 	#FFFFFFFF��6<   �� 5-   
   " d�6-   .�5.      ��  � ��8   6+   �� 5/       � ��8  6,   �� 50       � ��# � ��6+   �� 51       � ��$
 Left=�6;   �� 52       � ��$ 1q�60   �� 53       �@J�SnapsToDevicePixels . 64   �� 54       �@�FocusVisualStyle 61   Z� �� 55       � �� 56      �� 57      " d�6&   .R�58      � $ templateRoot��6   
������ # z 5:   
   	 5;        5<   "   CommonStates��.
 5=   &     
Normal��62     5>   &   	MouseOver��. 5?   *   �� .��5@   .   W� $ 0X�6>   $ 0:0:0.2D�6E   $ normalBorder��6X   $ (UIElement.Opacity)�6}   W� 5A   .   $ 1X�6>   $ 0:0:0.2D�6E   $ hoverBorder��6X   $ (UIElement.Opacity)�6|   T� 5B   .   $ 
optionMark��6L   $
 Fill�6o   $ 0:0:0.2D�6�   ..�5C   2   i� $ 0��6I   8  6U   5D   /   T� 5E   .   $ optionMarkOn��6L   $
 Fill�6q   $ 0:0:0.2D�6�   ..�5F   2   i� $ 0��6I   8  6U   5G   /   5H   +   5I   '     5J   &   Pressed��. 5K   *   �� .��5L   .   W� $ 1X�6>   $ 0D�6E   $ pressedBorder��6R   $ (UIElement.Opacity)�6x   T� 5M   .   $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5N   2   i� $ 0��6I   8  6U   5O   /   5P   +   5Q   '     5R   &   Disabled��. 5S   *   �� .��5T   .   T� $ 0D�6L   $ checkedBorder��6Y   $ BorderBrush�6   ..�5U   2   i� $ 0��6I   8  6U   5V   /   T� 5W   .   $ 0D�6L   $ checkedBorder��6Y   $ 
Background�6   ..�5X   2   i� $ 0��6I   8  6U   5Y   /   W� 5Z   .   $ 1X�6>   $ 0D�6E   $ disabledBorder��6R   $ (UIElement.Opacity)�6y   T� 5[   .   $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5\   2   i� $ 0��6I   8  6U   5]   /   T� 5^   .   $ optionMarkOn��6L   $
 Fill�6q   $ 0D�6�   ..�5_   2   i� $ 0��6I   8  6U   5`   /   5a   +   5b   '   5c   #     5d   "   CheckStates��.
 5e   &     	Unchecked��62     5f   &   Checked��. 5g   *   �� .��5h   .   T� $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5i   2   i� $ 0��6I   8 	 6U   5j   /   U� 5k   .   $ 0:0:0.5D�6L   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6_   $ 
optionMark��6�   .\�5l   2     $ 0��6G   $ 12Q�6S   5m   /   T� 5n   .   $ 0D�6L   $ 
optionMark��6Y   $
 Fill�6|   ..�5o   2   i� $ 0��6I   8 
 6U   5p   /   T� 5q   .   $ 0D�6L   $ hoverBorder��6Y   $ BorderBrush�6}   ..�5r   2   i� $ 0��6I   8  6U   5s   /   T� 5t   .   $ 0D�6L   $ hoverBorder��6Y   $ 
Background�6}   ..�5u   2   i� $ 0��6I   8  6U   5v   /   W� 5w   .   $ 1X�6>   $ 0D�6E   $ optionMarkOn��6R   $ (UIElement.Opacity)�6w   W� 5x   .   $ 1X�6>   $ 0D�6E   $ checkedBorder��6R   $ (UIElement.Opacity)�6x   T� 5y   .   $ 0D�6L   $ disabledBorder��6Y   $ BorderBrush�6�   ..�5z   2   i� $ 0��6I   8  6U   5{   /   T� 5|   .   $ 0D�6L   $ disabledBorder��6Y   $ 
Background�6�   ..�5}   2   i� $ 0��6I   8  6U   5~   /   5   +   5�   '     5�   &   Indeterminate��62   5�   #     5�   "   FocusStates��.
 5�   &     	Unfocused��62     5�   &   Focused��62   5�   #    5�      �� 5�   "   �� 5�   "   $
��Auto �60   .+�5�      �� $ contentPresenter��6/   |�.  ��. #��z��5�      #��z��5�      # z 5�      #��z��5�      � 5�      $ markGrid��6#   $��1��65   $��0 8 0 2q�6B   $��44��6S   $��20��6^   #��z��5�      .+�5�   "   �� $ normalBorder��6)   $ 1Q�6?   $��2q�6K   $ 10��6_   #��z��5�      8�� 67   �� 5�   "   $ checkedBorder��6)   $ 0Q�6@   $��2q�6L   $ 10��6`   8�� 8�� 5�   F   �� 5�   "   $ hoverBorder��6)   $ 0Q�6>   $��2q�6J   $ 10��6^   8�� 8�� 5�   G   �� 5�   "   $ pressedBorder��6)   $ 0Q�6@   $��2q�6L   $ 10��6`   8�� 8�� 5�   E   �� 5�   "   $ disabledBorder��6)   $ 0Q�6A   $��2q�6M   $ 10��6a   8�� 8�� 5�   F   A� 5�   "   $ 
optionMark��6*   $��10��5�      $��10��6   8�� $��0��6T   $��Center=�5�      $	��5,0q�6'   $ 0.5,0.5&�64   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   T� 5�   .   $	 -12Q�6A   5�   +   5�   #   A� 5�   "   $ optionMarkOn��6*   $ 0Q�6@   $��10��5�      $��10��6   8�� $��0��6U   $��Center=�5�      $	��5,0q�6'   $ 0.5,0.5&�64   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   T� 5�   .   $ 12Q�6A   5�   +   5�   #   5�      5�      5�      5�      5�      5�      .��5�      � 
�������$	��775��6   $	��410��6*   $	��775��67   $	��410��6F   .+�5�   
   �� -   5         ��Name$ btnTerug��5�      $��Terug��6#   $��32,31,637,315q�63     roundercorners#��[ 6J   $��Calibri)�6~   $��15(�6�   
�������6�   �� 5�   
   -   5         ��Name$ lblMusic��5�      $��Muziek��6"   $
��Left=�63   $��
304,83,0,0q�6N   $	��Top=�6b   $��Calibri)�6z   $��15(�6�   �� 5�   
   -   5        $ lblSound��5�      $��Geluids effecten��6"   $
��Left=�6=   $��304,126,0,0q�6X   $	��Top=�6m   $��Calibri)�6�   $��15(�6�   d� 5�   
   -   5         d�Name$ ToggleSwitchMusic��5�      $��	Sergio UI)�62   $��16(�6I   #���  5�      $��450,83,281,299q�5�      $��Center=�6'   $��Center=�6B   $��28��6   d� 5�   
   -   5        $ ToggleSwitchSound��5�      $��	Sergio UI)�62   $��16(�6I   #���  5�      $��450,126,281,256q�5�      $��Center=�6(   $��Center=�6C   $��28��6�   �� 5�   
   -   5        $ lblTheme��5�      $��Thema: ��6"   $
��Left=�64   $��304,173,0,0q�6O   $	��Top=�6d   $��Calibri)�6|   $��15(�6�   �� 5�   
   -   5        $ lblActiveTheme��5�      $�� ��6(   $
��Left=�63   $��376,173,0,0q�6N   $	��Top=�6c   $��Calibri)�6{   $��15(�6�   �� 5�   
   $
��Left=�6   $	��190��62   $��304,204,0,0q�6?   $	��Top=�6T   $	��190��6l   $��Disabled=�6x   $��Disabled=�6�   ��. .��5�      �� -   5         ��Name$ imgTheme��5�      6(   5�      �� 5�   
   -	   5        $ btnLeft��5�      $��3��6"   $��250,268,476,78q�6.   #��[ 6\   $��Marlett)�6�   $��36(�6�   
�������6�   �� 5�   
   -
   5        $ btnRight��5�      $��4��6#   $��498,268,228,78q�6/   #��[ 6_   $��Marlett)�6�   $��36(�6�   
�������6�   5�      5�      