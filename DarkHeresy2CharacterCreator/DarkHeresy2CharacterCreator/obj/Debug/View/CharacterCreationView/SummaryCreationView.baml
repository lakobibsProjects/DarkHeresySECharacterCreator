   M S B A M L   `   `   `  ����V  RDarkHeresy2CharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullDclr-namespace:DarkHeresy2CharacterCreator.View.CharacterCreationView6DarkHeresy2CharacterCreator.View.CharacterCreationView  5   	   ]3clr-namespace:DarkHeresy2CharacterCreator.ViewModel%DarkHeresy2CharacterCreator.ViewModel  5   	   P    JDarkHeresy2CharacterCreator.View.CharacterCreationView.SummaryCreationView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   VlocalDclr-namespace:DarkHeresy2CharacterCreator.View.CharacterCreationView     5   	   Bvm3clr-namespace:DarkHeresy2CharacterCreator.ViewModel     5   	   -   5          �Name$  SummaryCreation��5   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Summary��5   	   $	��450��6   $	��800��6&   .��5      �  � DataContext 5   
   D   >DarkHeresy2CharacterCreator.ViewModel.SummaryCreationViewModel  5      -   5        vm��5   *   ��5   
   �� 5       �� ImageSource$) #/Res/HorizontalWindowBackground.jpg��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � -   5         �Name$ CharacterDiscriptionGrid��5      $��0��61   $��5q�6>    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      ��  �� Orientation$ Vertical=�6   $��0��60   .+�5      �� $ 
Horizontal=�6   $��0 3 0 3q�67   .+�5       �� $��Name: ��6       BaseTextBlock#���   6.   �� 5!      $	��100��6`   ��6   �� 	 �� Path$$	 CreatedCharacter.CharacterName�
 �� Mode$
 TwoWay=�6`   5"      �� 5#      $ 
Horizontal=�6   $��0 3 0 3q�67   .+�5$      �� $��Homeworld: ��6    #���   63   �� 5%      ��6    �� $%	 CreatedCharacter.HomeWorld.Name�5&      �� 5'      $ 
Horizontal=�6   $��0 3 0 3q�66   .+�5(      �� $��Background: ��6    #���   64   �� 5)      ��6    �� $&	  CreatedCharacter.Background.Name�5*      �� 5+      $ 
Horizontal=�6   $��0 3 0 3q�66   .+�5,      �� $��Role: ��6    #���   6.   �� 5-      ��6    �� $%	 CreatedCharacter.HomeWorld.Name�5.      5/      �� 51      $��1��6   .+�52      �� $ 
Horizontal=�6   .+�53      �� $��Player Name: ��6    #���   65   �� 54      $��Stretch=�6]   ��6   �� $!	 CreatedCharacter.PlayerName�$
 TwoWay=�6]   55      �� 56      $ 
Horizontal=�6   .+�57      �� $��Gender: ��6    #���   60   �� 58      $��Stretch=�6Y   ��6   �� $	 CreatedCharacter.Gender�$
 TwoWay=�6Y   59      �� 5:      $ 
Horizontal=�6   .+�5;      �� $��Age: ��6    #���   6-   �� 5<      $��Stretch=�6V   ��6   �� $	 CreatedCharacter.Age�$
 TwoWay=�6V   5=      �� 5>      $ 
Horizontal=�6   .+�5?      �� $��Build: ��6    #���   6/   �� 5@      $��Stretch=�6X   ��6   �� $	 CreatedCharacter.Build�$
 TwoWay=�6X   5A      �� 5B      $ 
Horizontal=�6   .+�5C      �� $��Hair: ��6    #���   6.   �� 5D      $��Stretch=�5E      ��5D      �� $	 CreatedCharacter.Hair�$
 TwoWay=�5E      5F      5G      ]� 5I      $��2��6   .+�5J      ]� $	��Top=�6   .+�5K      �� $��Divination: ��6    #���   64   $
��Left=�6\   �� 5L      $
��Wrap=�6E   ��6    �� *Divination.Prophecy+6E   �� 5M      �� 5N      $��Right=�6   $
��Roll��5O      $��25��5Q      $��Right=�5R      ��5P      �� *SetDivinationCommand+5R      5S      �� 5T      $
��Wrap=�6?   ��6   �� *Divination.Effect+6?   5U      5V      � 5X   
   $��1��6   $��5q�6    5Y      �� 5Z      $��* �6#   �� 5[      $��* �6#   �� 5\      $��* �6#   .+�5^      �� -   5         ��Name$$ CharacteristicksAndAptitudesSP��5^      .+�5_      �� $��Characteristics:��6   � 5`       5a      �� 5b      $��* �6(   �� 5c      $��* �6(   �� 5d      $��* �6(   �� 5e      $��* �6(   �� 5f      $��* �6(    5h      �� 5i      $��* �6+   �� 5j      $��* �6+   .+�5l      �� $ 
Horizontal=�6!   $��0��5m   !   $��0��5n   !   .+�5o      �� Weapon�� 5p   %   
Skill (WS)5q      �� 5r       �� TextAlignment$ Center=�5s   $   $��Center=�5t   $   $��5q�5u   $   ��5r   $   �� *WeaponSkill.Value+5u   $   �� 5v      $
��Roll��6!   $��Center=�5w   !   ��5x   !   �� *SetCharateristic+��5y   !   �� *WeaponSkill+5z      �� 5{      $ 
Horizontal=�6!   $��0��5|   !   $��1��5}   !   .+�5~      �� 	Ballistic�� 5   (   
Skill (BS)5�      �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *BallisticSkill.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *BallisticSkill+5�      �� 5�      $ 
Horizontal=�6!   $��0��5�   !   $��2��5�   !   .+�5�      �� $��Strength (S)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Strength.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *
Strength+5�      �� 5�      $ 
Horizontal=�6!   $��0��5�   !   $��3��5�   !   .+�5�      �� $��Toughness (T)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Toughness.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *	Toughness+5�      �� 5�      $ 
Horizontal=�6!   $��0��5�   !   $��4��5�   !   .+�5�      �� $��Agility (AG)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Agility.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *	Agility+5�      �� 5�      $ 
Horizontal=�6!   $��1��5�   !   $��0��5�   !   .+�5�      �� $��Intelligence (INT)��6$   $��Center=�6>   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Intelligence.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *Intelligence+5�      �� 5�      $ 
Horizontal=�6!   $��1��5�   !   $��1��5�   !   .+�5�      �� $��Perception (PER)��6$   $��Center=�6<   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Perception.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *
Perception+5�      �� 5�      $ 
Horizontal=�6!   $��1��5�   !   $��2��5�   !   .+�5�      �� $��Willpower (WP)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Willpower.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *	Willpower+5�      �� 5�      $ 
Horizontal=�6!   $��1��5�   !   $��3��5�   !   .+�5�      �� $��Fellowship (FEL)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Fellowship.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *
Fellowship+5�      �� 5�      $ 
Horizontal=�6!   $��1��5�   !   $��4��5�   !   .+�5�      �� $��Influence (IFL)��6$   �� 5�      $ Center=�5�   $   $��Center=�5�   $   $��5q�5�   $   ��5�   $   �� *Influence.Value+5�   $   �� 5�      $
��Roll��6!   $��Center=�5�   !   ��5�   !   �� *SetCharateristic+��5�   !   �� *	Influence+5�      5�      �� 5�      $ 
Horizontal=�6   $��5q�66   .+�5�      �� $��Fate:��6    �� 5�      $	��5 0q�6O   ��6    �� *CreatedCharacter.FateTreshold+6O   �� 5�      $��Blessing��6   ��60   �� *SetFateTreshhold+5�      �� 5�      $ 
Horizontal=�6   $��5 0 5 5q�66   .+�5�      �� $��Wounds:��6    �� 5�      $	��5 0q�6N   ��6    �� *CreatedCharacter.TotalWounds+6N   �� 5�      $
��Roll��6   ��6,   �� *	SetWounds+5�      �� 5�      -   5         ��Name$ AptitudesLV��5�      $��Visible=�5�      ��.  $��90��5     ��5�      �� *	Aptitudes+��5     �� 5     .R�5     �� $ Vertical=�6)   5     5     5     �� 5	     $��1��6   $��0��5
     .+�5     �� $��Skills��6   $��Center=�6*   $
��Bold"�6G   &   System.Windows.Controls.DataGrid  5     $��3q�6      AutoGenerateColumns .  ��5     �� *Skills+   Columns 5     0  *System.Windows.Controls.DataGridTextColumn  5     ,  &System.Windows.Controls.DataGridColumn   Header$ Skill��6-      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *Name+4  .System.Windows.Controls.DataGridCheckBoxColumn  5     $
 Know��62    .  6@   �� *IsKnow+6[     5     $ Trained��61    .  6B   �� *	IsTrained+6`     5     $ Experienced��61    .  6F   �� *IsExperienced+6h     5     $ Veteran��61    .  6B   �� *	IsVeteran+6`   5     5     � 5     $��2��6   $��5q�6#    5     �� 5     $��* �6$   �� 5     $��* �6$   �� 5     $��* �6$   .+�5      �� $��0��6   .+�5!     �� $��Talents and Traits:��6    �� 5"     .��5#     �� ��6"   �� *TalentsAndTraits+5%     5&     5'     �� 5(     $��1��6   .+�5)     �� $��Gear:��6    �� 5*     .��5+     �� -   5        $ GearLV��5+  #   ��5,     �� *Gear+��5-     �� 5.  "   .R�5/  &   �� $ Vertical=�61   50  #   52     53     54     �� 55     $��2��6   .+�56     �� $��Special Abilities:��6    �� 57     $	��100��58     $��Visible=�59     ��57     �� *SpecialAbilities+��5:     �� 5;     .R�5<  "   �� $
��Wrap=�6,   $	��250��6Q   ��6@   �� 6Q   5=     5?     5@     5A     5B     �� 5C  
   $��2��6   $��4��5D     $��Center=�5E     $ 
Horizontal=�5F     .+�5G     �� $
��Exit��6   $��Center=�5H     $��85��5I     $��5q�5J     ��5K     �� *ExitCommand+��5L     ��  �� ElementName$ SummaryCreation���� 5M     $��Save and Exit��6   $��Center=�5N     $��85��5O     $��5q�5P     ��5Q     �� *SaveAndExitCommand+��5R     �� $ SummaryCreation��5S     5T     5U     