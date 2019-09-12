using DarkHeresy2CharacterCreator.Model;
using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Tests
{
    public static class TestTalentList
    {

        private static string adamantiumFaithDiscription = "The Acolyte has become inured to horrors that would cripple lesser men.";
        private static string ambidextrousDiscription = "This talent does not represent true ambidexterity so much as sufficient training";
        private static string armourMongerDiscription = "The Acolyte is a skilled armourer, and constantly tinkers and improves his armour, or keeps it in pristine";
        public static ObservableCollection<Talent> Talents { get; set; } = new ObservableCollection<Talent>()
                {
                    /*new Talent(TalentName.Adamantium_Faith.ToString(), adamantiumFaithDiscription, AptitudeName.Willpower, AptitudeName.Defence, 3){
                        Prerequisites = 
                        {
                            (Talents.FirstOrDefault( p => p.Name == "Jaded"), 1),
                            (Talents.FirstOrDefault(p => p.Name == "Resistance" && p.Specializations.First() == "Fear"), 1),
                            (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower) as IPrerequisitable, 45)
                        }
                    },
                    new Talent (TalentName.Ambidextrous.ToString(), ambidextrousDiscription, AptitudeName.Weapon_Skill, AptitudeName.Balistic_Skill, 1)
                    {
                        Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility) as IPrerequisitable, 30) }
                    },
                    new Talent(TalentName.Armour_Monger.ToString(), armourMongerDiscription, AptitudeName.Intelligence, AptitudeName.Tech, 2)
                    {
                        Prerequisites =
                        {
                            (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence) as IPrerequisitable, 35),
                            (DarkHeresy2CharacterCreator.Model.Skills.SkillList.CommonSkills.FirstOrDefault(s => s.Name == DarkHeresy2CharacterCreator.Model.Skills.SkillName.Tech_Use), 1),
                            (DarkHeresy2CharacterCreator.Model.Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == DarkHeresy2CharacterCreator.Model.Skills.SkillName.Trade), 1)
                        }
                    },*/
                };

        
        }
}
