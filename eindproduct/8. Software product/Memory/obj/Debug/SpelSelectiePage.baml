   M S B A M L   `   `   `  ����A  =Memory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemoryMemory  5          Memory.SpelSelectiePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Memory     5        N� Title$  SpelSelectiePage��5	      $	��775��6    $	��410��6,   $	��775��69   $	��410��6H    � 	Resources 5
       !  RadioButton.Static.Background �� Color  RadioButton.Static.Border  RadioButton.Checked.Border " RadioButton.Checked.Background   RadioButton.MouseOver.Border $  RadioButton.MouseOver.Background  RadioButton.Pressed.Border " RadioButton.Pressed.Background  RadioButton.Disabled.Border #	 RadioButton.Disabled.Background 
 RadioButton.Static.Glyph  RadioButton.Checked.Glyph  RadioButton.MouseOver.Glyph " RadioButton.MouseOver.On.Glyph  RadioButton.Pressed.Glyph " RadioButton.Disabled.On.Border & "RadioButton.Disabled.On.Background  RadioButton.Disabled.Glyph ! RadioButton.Disabled.On.Glyph # RadioButton.MouseOver.On.Border ' #RadioButton.MouseOver.On.Background  ToggleSwitchTopStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name J� SnapsToDevicePixels'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard	 W� To g� Duration �� 
TargetName �� TargetProperty R� KeyTime R� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value � RowDefinitions ��Name ��Name J� Opacity �� CornerRadius A�Name J� RenderTransformOrigin T� X��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		 ;    &	
 ^    &	 �    &	 �    &	 �    &	 �    &	     &	 0    &	 S    &	 v    &	 �    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7 
 7  7  7  7  7  7   7  7  7  7  7  7  7  7 	 7 
 7  �� 5   
   $ 	#FFFFFFFF��6@   �� 5   
   $ 	#FF333333��6<   �� 5   
   $ 	#FF0063B1��6=   �� 5   
   $ 	#FF0063B1��6A   �� 5   
   $ 	#FF000000��6?   �� 5   
   $ 	#FFFFFFFF��6C   �� 5   
   $ 	#FF999999��6=   �� 5   
   $ 	#FF999999��6A   �� 5   
   $ 	#FF999999��6>   �� 5   
   $ 	#FFFFFFFF��6B   �� 5   
   $ 	#FF333333��6;   �� 5   
   $ 	#FFFFFFFF��6<   �� 5   
   $ 	#FF000000��6>   �� 5!   
   $ 	#FFFFFFFF��6A   �� 5#   
   $ 	#FFFFFFFF��6<   �� 5%   
   $ 	#FFCCCCCC��6A   �� 5'   
   $ 	#FFCCCCCC��6E   �� 5(   
   $ 	#FF999999��6=   �� 5*   
   $ 	#FFA3A3A3��6@   �� 5,   
   $ 	#FF4C91C8��6B   �� 5.   
   $ 	#FF4C91C8��6F   �� 51   
   " d�6-   .�52      ��  � ��8   6+   �� 53       � ��8  6,   �� 54       � ��# � ��6+   �� 55       � ��$
 Left=�6;   �� 56       � ��$ 1q�60   �� 57       �@J�SnapsToDevicePixels . 64   �� 58       �@�FocusVisualStyle 61   Z� �� 59       � �� 5:      �� 5;      " d�6&   .R�5<      � $ templateRoot��6   
������ # z 5>      	 5?        5@   "   CommonStates��.
 5A   &     
Normal��62     5B   &   	MouseOver��. 5C   *   �� .��5D   .   W� $ 0X�6>   $ 0:0:0.2D�6E   $ normalBorder��6X   $ (UIElement.Opacity)�6}   W� 5E   .   $ 1X�6>   $ 0:0:0.2D�6E   $ hoverBorder��6X   $ (UIElement.Opacity)�6|   T� 5F   .   $ 
optionMark��6L   $
 Fill�6o   $ 0:0:0.2D�6�   ..�5G   2   i� $ 0��6I   8  6U   5H   /   T� 5I   .   $ optionMarkOn��6L   $
 Fill�6q   $ 0:0:0.2D�6�   ..�5J   2   i� $ 0��6I   8  6U   5K   /   5L   +   5M   '     5N   &   Pressed��. 5O   *   �� .��5P   .   W� $ 1X�6>   $ 0D�6E   $ pressedBorder��6R   $ (UIElement.Opacity)�6x   T� 5Q   .   $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5R   2   i� $ 0��6I   8  6U   5S   /   5T   +   5U   '     5V   &   Disabled��. 5W   *   �� .��5X   .   T� $ 0D�6L   $ checkedBorder��6Y   $ BorderBrush�6   ..�5Y   2   i� $ 0��6I   8  6U   5Z   /   T� 5[   .   $ 0D�6L   $ checkedBorder��6Y   $ 
Background�6   ..�5\   2   i� $ 0��6I   8  6U   5]   /   W� 5^   .   $ 1X�6>   $ 0D�6E   $ disabledBorder��6R   $ (UIElement.Opacity)�6y   T� 5_   .   $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5`   2   i� $ 0��6I   8  6U   5a   /   T� 5b   .   $ optionMarkOn��6L   $
 Fill�6q   $ 0D�6�   ..�5c   2   i� $ 0��6I   8  6U   5d   /   5e   +   5f   '   5g   #     5h   "   CheckStates��.
 5i   &     	Unchecked��62     5j   &   Checked��. 5k   *   �� .��5l   .   T� $ 
optionMark��6L   $
 Fill�6o   $ 0D�6�   ..�5m   2   i� $ 0��6I   8 	 6U   5n   /   U� 5o   .   $ 0:0:0.5D�6L   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6_   $ 
optionMark��6�   .\�5p   2     $ 0��6G   $ 12Q�6S   5q   /   T� 5r   .   $ 0D�6L   $ 
optionMark��6Y   $
 Fill�6|   ..�5s   2   i� $ 0��6I   8 
 6U   5t   /   T� 5u   .   $ 0D�6L   $ hoverBorder��6Y   $ BorderBrush�6}   ..�5v   2   i� $ 0��6I   8  6U   5w   /   T� 5x   .   $ 0D�6L   $ hoverBorder��6Y   $ 
Background�6}   ..�5y   2   i� $ 0��6I   8  6U   5z   /   W� 5{   .   $ 1X�6>   $ 0D�6E   $ optionMarkOn��6R   $ (UIElement.Opacity)�6w   W� 5|   .   $ 1X�6>   $ 0D�6E   $ checkedBorder��6R   $ (UIElement.Opacity)�6x   T� 5}   .   $ 0D�6L   $ disabledBorder��6Y   $ BorderBrush�6�   ..�5~   2   i� $ 0��6I   8  6U   5   /   T� 5�   .   $ 0D�6L   $ disabledBorder��6Y   $ 
Background�6�   ..�5�   2   i� $ 0��6I   8  6U   5�   /   5�   +   5�   '     5�   &   Indeterminate��62   5�   #     5�   "   FocusStates��.
 5�   &     	Unfocused��62     5�   &   Focused��62   5�   #    5�      �� 5�   "   �� 5�   "   $
��Auto �60   .+�5�      �� $ contentPresenter��6/   |�.  ��. #��z��5�   !   #��z��5�   !   # z 5�   !   #��z��5�   !   � 5�      $ markGrid��6#   $��1��65   $��0 8 0 2q�6B   $��44��6S   $��20��6^   #��z��5�   !   .+�5�   "   �� $ normalBorder��6)   $ 1Q�6?   $��2q�6K   $ 10��6_   #��z��5�   %   8�� 6Q   �� 5�   "   $ checkedBorder��6)   $ 0Q�6@   $��2q�6L   $ 10��6`   8�� 8�� 5�   _   �� 5�   "   $ hoverBorder��6)   $ 0Q�6>   $��2q�6J   $ 10��6^   8�� 8�� 5�   a   �� 5�   "   $ pressedBorder��6)   $ 0Q�6@   $��2q�6L   $ 10��6`   8�� 8�� 5�   _   �� 5�   "   $ disabledBorder��6)   $ 0Q�6A   $��2q�6M   $ 10��6a   8�� 8�� 5�   `   A� 5�   "   $ 
optionMark��6*   $��10��5�   %   $��10��61   8�� $��0��6m   $��Center=�5�   %   $	��5,0q�6@   $ 0.5,0.5&�6M   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   T� 5�   .   $	 -12Q�6A   5�   +   5�   #   A� 5�   "   $ optionMarkOn��6*   $ 0Q�6@   $��10��5�   %   $��10��61   8�� $��0��6n   $��Center=�5�   %   $	��5,0q�6@   $ 0.5,0.5&�6M   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   T� 5�   .   $ 12Q�6A   5�   +   5�   #   5�      5�      5�      5�      5�      5�      .��5�      � 
�������$	��775��6   $	��410��6*   $	��775��67   $	��410��6F   .+�5�   
   �� -   5         ��Name$ BacktoSpelbtn��5�      $��Terug��6(   $��32,31,637,315q�68     roundercorners#��[ 6O   $��Calibri)�6�   $��15(�6�   
�������6�   �� 5�   
   -   5        $ BeginSpelbtn��5�      $��
Begin Spel��6'   $��314,285,309,61q�6<   #��[ 6T   $��Calibri)�6�   $��20(�6�   
�������$	��152��6�   �� 5�   
   -   5         ��Name$ speler1label��5�      $�� Speler 1 :��6&   $
��Left=�6<   $��216,128,0,0q�6W   $	��Top=�6l   $��90��6�   $��Calibri)�6�   $��20(�6�   �� 5�   
   -   5         ��Name$ textboxspeler1��5�      $
��Left=�6*   $��35��6E   $��311,128,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $��Speler1��6z   $	��Top=�6�   $	��158��6�   $��Italic$�6�   $��Calibri)�6�   $��20(�6�   �� 5�   
   -   5        $ Textboxspeler2��5�      $
��Left=�6*   $��35��6E   $��311,213,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��158��6�   $��Italic$�6�   $��Calibri)�6�   $��20(�6�   {�.    �� 	IsEnabled  . $��Speler2��6  d� 5�   
   -   5        ! d�Name$! ToggleSwitchSpeler��5�      $��	Sergio UI)�63   $��16(�6J   #���  5�      $��167,214,564,168q�5�      $��Center=�6&   $��Center=�6A   $��28��5�      $��44��6   �� 5�   
   -   5        $ speler1label_Copy��5�      $�� Speler 2 :��6+   $
��Left=�6A   $��216,214,0,0q�6\   $	��Top=�6q   $��90��6�   $��Calibri)�6�   $��20(�6�   $��34��6�   5�      5�      