   M S B A M L   `   `   `  ���� A  =Memory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemoryMemory      Memory.SpelSelectiePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Memory       N� Title$  SpelSelectiePage��$	��775��$	��410��$	��775��$	��410�� � 	Resources  !  RadioButton.Static.Background �� Color  RadioButton.Static.Border  RadioButton.Checked.Border " RadioButton.Checked.Background   RadioButton.MouseOver.Border $  RadioButton.MouseOver.Background  RadioButton.Pressed.Border " RadioButton.Pressed.Background  RadioButton.Disabled.Border #	 RadioButton.Disabled.Background 
 RadioButton.Static.Glyph  RadioButton.Checked.Glyph  RadioButton.MouseOver.Glyph " RadioButton.MouseOver.On.Glyph  RadioButton.Pressed.Glyph " RadioButton.Disabled.On.Border & "RadioButton.Disabled.On.Background  RadioButton.Disabled.Glyph ! RadioButton.Disabled.On.Glyph # RadioButton.MouseOver.On.Border ' #RadioButton.MouseOver.On.Background  ToggleSwitchTopStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name J� SnapsToDevicePixels'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard	 W� To g� Duration �� 
TargetName �� TargetProperty R� KeyTime R� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value � RowDefinitions ��Name ��Name J� Opacity �� CornerRadius A�Name J� RenderTransformOrigin T� X��%�  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     &	     &	 &    &	 ;    &	 P    &	 e    &	 z    &	 �    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7 
 7  7  7  7  7  7   7  7  7  7  7  7  7  7 	 7 
 7  �� $ 	#FFFFFFFF���� $ 	#FF333333���� $ 	#FF0063B1���� $ 	#FF0063B1���� $ 	#FF000000���� $ 	#FFFFFFFF���� $ 	#FF999999���� $ 	#FF999999���� $ 	#FF999999���� $ 	#FFFFFFFF���� $ 	#FF333333���� $ 	#FFFFFFFF���� $ 	#FF000000���� $ 	#FFFFFFFF���� $ 	#FFFFFFFF���� $ 	#FFCCCCCC���� $ 	#FFCCCCCC���� $ 	#FF999999���� $ 	#FFA3A3A3���� $ 	#FF4C91C8���� $ 	#FF4C91C8���� " d�.���  � ��8   ��  � ��8  ��  � ��# � ����  � ��$
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
�������$	��775��$	��410��$	��775��$	��410��.+��� -    ��Name$ BacktoSpelbtn��$��Terug��$��32,31,637,315q�  roundercorners#��[ $��Calibri)�$��15(�
��������� -   $ BeginSpelbtn��$��
Begin Spel��$��314,285,309,61q�#��[ $��Calibri)�$��20(�
�������$	��152���� -    ��Name$ speler1label��$�� Speler 1 :��$
��Left=�$��216,128,0,0q�$	��Top=�$��90��$��Calibri)�$��20(��� -    ��Name$ textboxspeler1��$
��Left=�$��35��$��311,128,0,0q� �� TextWrapping$
 Wrap=�$��Speler1��$	��Top=�$	��158��$��Italic$�$��Calibri)�$��20(��� -   $ Textboxspeler2��$
��Left=�$��35��$��311,213,0,0q�$
 Wrap=�$	��Top=�$	��158��$��Italic$�$��Calibri)�$��20(�{�.    �� 	IsEnabled  . $��Speler2��d� -   ! d�Name$! ToggleSwitchSpeler��$��	Sergio UI)�$��16(�#���  $��167,214,564,168q�$��Center=�$��Center=�$��28��$��44���� -   $ speler1label_Copy��$�� Speler 2 :��$
��Left=�$��216,214,0,0q�$	��Top=�$��90��$��Calibri)�$��20(�$��34��