   M S B A M L   `   `   `  ���� A  =Memory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemoryMemory      Memory.InstellingenPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Memory       N� Title$  InstellingenPage��$	��775��$	��410��$	��775��$	��410�� � 	Resources  !  RadioButton.Static.Background �� Color  RadioButton.Static.Border  RadioButton.Static.Glyph $  RadioButton.MouseOver.Background   RadioButton.MouseOver.Border  RadioButton.MouseOver.Glyph ' #RadioButton.MouseOver.On.Background # RadioButton.MouseOver.On.Border " RadioButton.MouseOver.On.Glyph #	 RadioButton.Disabled.Background 
 RadioButton.Disabled.Border  RadioButton.Disabled.Glyph & "RadioButton.Disabled.On.Background " RadioButton.Disabled.On.Border ! RadioButton.Disabled.On.Glyph " RadioButton.Pressed.Background  RadioButton.Pressed.Border  RadioButton.Pressed.Glyph " RadioButton.Checked.Background  RadioButton.Checked.Border  RadioButton.Checked.Glyph  ToggleSwitchTopStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name J� SnapsToDevicePixels'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard	 W� To g� Duration �� 
TargetName �� TargetProperty R� KeyTime R� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value � RowDefinitions ��Name ��Name J� Opacity �� CornerRadius A�Name J� RenderTransformOrigin T� X��%�  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     &	     &	 &    &	 ;    &	 P    &	 e    &	 z    &	 �    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7  7  7  7  7  7  7 
 7 	 7  7  �� $ 	#FFFFFFFF���� $ 	#FF333333���� $ 	#FF333333���� $ 	#FFFFFFFF���� $ 	#FF000000���� $ 	#FF000000���� $ 	#FF4C91C8���� $ 	#FF4C91C8���� $ 	#FFFFFFFF���� $ 	#FFFFFFFF���� $ 	#FF999999���� $ 	#FF999999���� $ 	#FFCCCCCC���� $ 	#FFCCCCCC���� $ 	#FFA3A3A3���� $ 	#FF999999���� $ 	#FF999999���� $ 	#FFFFFFFF���� $ 	#FF0063B1���� $ 	#FF0063B1���� $ 	#FFFFFFFF���� " d�.���  � ��8   ��  � ��8  ��  � ��# � ����  � ��$
 Left=���  � ��$ 1q���  �@J�SnapsToDevicePixels . ��  �@�FocusVisualStyle Z� ��  � �� �� " d�.R�� $ templateRoot��
������ # z 	   CommonStates��.
   
Normal��  	MouseOver��. �� .��W� $ 0X�$ 0:0:0.2D�$ normalBorder��$ (UIElement.Opacity)�W� $ 1X�$ 0:0:0.2D�$ hoverBorder��$ (UIElement.Opacity)�T� $ 
optionMark��$
 Fill�$ 0:0:0.2D�..�i� $ 0��8  T� $ optionMarkOn��$
 Fill�$ 0:0:0.2D�..�i� $ 0��8    Pressed��. �� .��W� $ 1X�$ 0D�$ pressedBorder��$ (UIElement.Opacity)�T� $ 
optionMark��$
 Fill�$ 0D�..�i� $ 0��8    Disabled��. �� .��T� $ 0D�$ checkedBorder��$ BorderBrush�..�i� $ 0��8  T� $ 0D�$ checkedBorder��$ 
Background�..�i� $ 0��8  W� $ 1X�$ 0D�$ disabledBorder��$ (UIElement.Opacity)�T� $ 
optionMark��$
 Fill�$ 0D�..�i� $ 0��8  T� $ optionMarkOn��$
 Fill�$ 0D�..�i� $ 0��8    CheckStates��.
   	Unchecked��  Checked��. �� .��T� $ 
optionMark��$
 Fill�$ 0D�..�i� $ 0��8 	 U� $ 0:0:0.5D�$U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 
optionMark��.\�  $ 0��$ 12Q�T� $ 0D�$ 
optionMark��$
 Fill�..�i� $ 0��8 
 T� $ 0D�$ hoverBorder��$ BorderBrush�..�i� $ 0��8  T� $ 0D�$ hoverBorder��$ 
Background�..�i� $ 0��8  W� $ 1X�$ 0D�$ optionMarkOn��$ (UIElement.Opacity)�W� $ 1X�$ 0D�$ checkedBorder��$ (UIElement.Opacity)�T� $ 0D�$ disabledBorder��$ BorderBrush�..�i� $ 0��8  T� $ 0D�$ disabledBorder��$ 
Background�..�i� $ 0��8    Indeterminate��  FocusStates��.
   	Unfocused��  Focused�� �� �� $
��Auto �.+��� $ contentPresenter��|�.  ��. #��z��#��z��# z #��z��� $ markGrid��$��1��$��0 8 0 2q�$��44��$��20��#��z��.+��� $ normalBorder��$ 1Q�$��2q�$ 10��#��z��8�� �� $ checkedBorder��$ 0Q�$��2q�$ 10��8�� 8�� �� $ hoverBorder��$ 0Q�$��2q�$ 10��8�� 8�� �� $ pressedBorder��$ 0Q�$��2q�$ 10��8�� 8�� �� $ disabledBorder��$ 0Q�$��2q�$ 10��8�� 8�� A� $ 
optionMark��$��10��$��10��8�� $��0��$��Center=�$	��5,0q�$ 0.5,0.5&�z�V� .~��� �� �� T� $	 -12Q�A� $ optionMarkOn��$ 0Q�$��10��$��10��8�� $��0��$��Center=�$	��5,0q�$ 0.5,0.5&�z�V� .~��� �� �� T� $ 12Q�.��� 
�������$	��775��$	��410��$	��775��$	��410��.+��� -    ��Name$ btnTerug��$��Terug��$��32,31,637,315q�  roundercorners#��[ $��Calibri)�$��15(�
��������� -    ��Name$ lblMusic��$��Muziek��$
��Left=�$��
304,83,0,0q�$	��Top=�$��Calibri)�$��15(��� -   $ lblSound��$��Geluids effecten��$
��Left=�$��304,126,0,0q�$	��Top=�$��Calibri)�$��15(�d� -    d�Name$ ToggleSwitchMusic��$��	Sergio UI)�$��16(�#���  $��450,83,281,299q�$��Center=�$��Center=�$��28��d� -   $ ToggleSwitchSound��$��	Sergio UI)�$��16(�#���  $��450,126,281,256q�$��Center=�$��Center=�$��28���� -   $ lblTheme��$��Thema: ��$
��Left=�$��304,173,0,0q�$	��Top=�$��Calibri)�$��15(��� -   $ lblActiveTheme��$�� ��$
��Left=�$��376,173,0,0q�$	��Top=�$��Calibri)�$��15(��� $
��Left=�$	��190��$��304,204,0,0q�$	��Top=�$	��190��$��Disabled=�$��Disabled=���. .���� -    ��Name$ imgTheme���� -	   $ btnLeft��$��3��$��250,268,476,78q�#��[ $��Marlett)�$��36(�
��������� -
   $ btnRight��$��4��$��498,268,228,78q�#��[ $��Marlett)�$��36(�
�������