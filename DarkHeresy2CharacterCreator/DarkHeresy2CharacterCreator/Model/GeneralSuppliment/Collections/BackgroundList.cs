using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using DarkHeresy2CharacterCreator.Model.Traits;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections
{
    /// <summary>
    /// Instaniate a observableCollection of backgrounds
    /// </summary>
    public static class BackgroundList
    {
        /// <summary>
        /// Collection of backgrounds
        /// </summary>
        public static ObservableCollection<Background> Backgrounds { get; } = new ObservableCollection<Background>
        {
            //TODO create mechanizm to add specialization
            #region Core Culebook
            new Background("Adeptus Administratum")
            {
                BackgroundBonuds = adeptusAdministratumDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Commerce).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Medicae).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Linguistics).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Logic).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Scholastic_Lore).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Laspistol").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Stub Automatic").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Imperial Robes").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Qutoquill").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Chrono").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Dataslate").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Medi-kit").First(), null)
                },
                BackgroundAptitude = (AptitudeName.Knowledge, AptitudeName.Social),
                RecommendedRoles = new List<RoleName> { RoleName.Chirurgeon, RoleName.Hierophant, RoleName.Sage, RoleName.Seeker }
            },
            new Background("Adeptus Arbites")
            {
                BackgroundBonuds = adeptusArbitesDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Inquiry).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Interrogation).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Awarness).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Intimidate).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),     //add specialization
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),     //add specialization
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Scrutiny).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Shotgun").First(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Shock Maul").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Enforcer Light Carapace Armour").First(),
                        Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Carapace Chestplate").First()),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Stimm").First(), null),    //add number
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Manacles").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Lho Stiks").First(), null),
                },
                BackgroundAptitude = (AptitudeName.Offence, AptitudeName.Defence),
                RecommendedRoles = new List<RoleName> { RoleName.Assassin, RoleName.Desperado, RoleName.Warrior, RoleName.Seeker }
            },
            new Background("Adeptus Astra Telepatica")
            {
                BackgroundBonuds = adeptusAstraTelepaticaDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Deceive).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Interrogation).First()),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Psyniscience).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Scrutiny).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Awarness).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Forbidden_Lore).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Staff").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Whip").First()),
                    (Equipment.Collections.WeaponCollection.Weapons.Where( a => a.Name == "Laspistol").First(), null),
                    (Equipment.Collections.ArmorCollection.Armors.Where ( t => t.Name == "Loght Flak Cloack").First(), Equipment.Collections.ArmorCollection.Armors.Where ( t => t.Name == "Flak Vest").First()),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Micro Bead").First(), Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Psy Focus").First()),
                },
                BackgroundAptitude = (AptitudeName.Defence, AptitudeName.Psyker),
                RecommendedRoles = new List<RoleName> { RoleName.Chirurgeon, RoleName.Mystic, RoleName.Sage, RoleName.Seeker }
            },
            new Background("Adeptus Mechanicus")
            {
                BackgroundBonuds = adeptusMechanicusDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Awarness).First(), Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Operate).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Logic).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Security).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Tech_Use).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Mechandendrite_Use.ToString()). First(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Autogun").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Hand Cannon").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Imperial Robes").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Vial of Sacred Urgents").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Monotask Servoskull").First(), Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Utility Mechandendrite").First()),
                },
                BackgroundAptitude = (AptitudeName.Knowledge, AptitudeName.Tech),
                RecommendedRoles = new List<RoleName> { RoleName.Chirurgeon, RoleName.Hierophant, RoleName.Sage, RoleName.Seeker },
                Trait = Traits.TraitList.Traits.Where (t => t.Name == "Mechanicus Implants").First() as Trait

            },
            new Background("Adeptus Ministorum")
            {
                BackgroundBonuds = adeptusMinistorumDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Inquiry).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Security).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Charm).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Command).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Linguistics).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Hand Flamer").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Stub Rvolver").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Imperial Robes").First(), Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Flak Vest").First()),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Backpack").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Glow Globe/Stublight").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Monotask Sevoskull").First(), null)
                },
                BackgroundAptitude = (AptitudeName.Leadship, AptitudeName.Social),
                RecommendedRoles = new List<RoleName> { RoleName.Chirurgeon, RoleName.Hierophant, RoleName.Warrior, RoleName.Seeker }
            },
            new Background("Imperial Guard")
            {
                BackgroundBonuds = imprialGuardDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Athletics).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Navigate).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Command).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Medicae).First(), Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Operate).First())
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Laspistol").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Lasgun").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Imperial Guard Flak Armour").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Combat Vest").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Grappnel and Line").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Lho Stiks").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Magnoculars").First(), null)
                },
                BackgroundAptitude = (AptitudeName.Fieldcraft, AptitudeName.Leadship),
                RecommendedRoles = new List<RoleName> { RoleName.Assassin, RoleName.Desperado, RoleName.Hierophant, RoleName.Warrior }
            },
            new Background("Outcast")
            {
                BackgroundBonuds = outcastDiscription,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Acrobatics).First(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Sleght_of_Hand).First()),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Deceive).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Dodge).First(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Stealth).First(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).First(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First(), Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). First())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Laspistol").First(), Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Autopistol").First()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Armoured Bodyglove").First(), Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == "Flak Vest").First()),
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == "Chainsword").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Injector").First(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Obscura").First(), Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == "Slaught").First()),
                },
                BackgroundAptitude = (AptitudeName.Fieldcraft, AptitudeName.Social),
                RecommendedRoles = new List<RoleName> { RoleName.Assassin, RoleName.Desperado, RoleName.Seeker }
            },            
            #endregion

        };

        //TODO Add discriptions
        #region Bonuses
        private static readonly string adeptusAdministratumDiscription = "";
        private static readonly string adeptusArbitesDiscription = "";
        private static readonly string adeptusAstraTelepaticaDiscription = "";
        private static readonly string adeptusMechanicusDiscription = "";
        private static readonly string adeptusMinistorumDiscription = "";
        private static readonly string imprialGuardDiscription = "";
        private static readonly string outcastDiscription = "";
        #endregion Bonuses
    }
}