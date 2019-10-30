using DarkHeresy2CharacterCreator.Model.Equipment.Enums;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Enums;
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
    public static class BackgroundsCollection
    {
        #region Bonuses
        private static readonly string adeptusAdministratumBonus = "Master of Paperwork: An Adeptus Administratum character counts the Availability of all items " +
            "as one level more available(Very Rare items count as Rare, Average items count as Common, etc.).";
        private static readonly string adeptusArbitesBonus = "The Face of the Law: An Arbitrator can re-roll any Intimidation and Interrogation test," +
            " and can substitute his Willpower bonus for his degrees of success on these tests.";
        private static readonly string adeptusAstraTelepaticaBonus = "The Constant Threat: When the character or an ally within 10 metres triggers" +
            " a roll on Table Psychic Phenomenon, the Adeptus Astra Telepathica character can increase or decrease the result by amount" +
            " equal to his Willpower bonus. Tested on Terra: If the character takes the Psyker elite advance during character creation, he also gains the Sanctioned trait.";
        private static readonly string adeptusMechanicusBonus = "Replace the Weak Flesh: An Adeptus Mechanicus character counts the Availability of all " +
            "cybernetics as two levels more available(Rare items count as Average, Very Rare items count as Scarce, etc.).";
        private static readonly string adeptusMinistorumBonus = "Faith is All: When spending a Fate point to gain a + 10 bonus to any one test, " +
            "an Adeptus Ministorum  character gains a +20 bonus instead.";
        private static readonly string imprialGuardBonus = "Hammer of the Emperor: When attacking a target that an ally attacked since the end " +
            "of the Guardsman’s last turn, the Guardsman can re-roll any results of 1 or 2 on damage rolls.";
        private static readonly string outcastBonus = "Never Quit: An Outcast character counts his Toughness bonus as two higher for purposes of determining Fatigue.";
        #endregion Bonuses
        /// <summary>
        /// Collection of backgrounds
        /// </summary>
        public static ObservableCollection<Background> Backgrounds = new ObservableCollection<Background>
        {
            //TODO create mechanizm to add specialization
            #region Core Culebook
            new Background(BackgroundName.Adeptus_Administratum.ToString())
            {
                BackgroundBonuds = adeptusAdministratumBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Commerce).FirstOrDefault(), Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Medicae).First()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Linguistics).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Logic).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Scholastic_Lore).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(),
                        Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Laspistiol.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Stub_Automatic.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Imperial_Robes.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Auto_Quill.ToString()).FirstOrDefault(), null),
                    (Equipment.GearCollection.Gear.Where ( t => t.Name == GearName.Chrono.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Dataslate.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Medi_Kit.ToString()).FirstOrDefault(), null)
                },
                BackgroundAptitude = (AptitudeName.Knowledge, AptitudeName.Social),
                RecommendedRoles = new List<string> { RoleName.Chirurgeon.ToString(), RoleName.Hierophant.ToString(), RoleName.Sage.ToString(), RoleName.Seeker.ToString() }
            },
            new Background(BackgroundName.Adeptus_Arbites.ToString())
            {
                BackgroundBonuds = adeptusArbitesBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Inquiry).FirstOrDefault(),
                        Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Interrogation).FirstOrDefault()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Awarness).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Intimidate).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),     //add specialization
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),     //add specialization
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Scrutiny).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(),
                        Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Shotgun.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Shock_Maul.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Enforcer_Light_Carapace.ToString()).FirstOrDefault(),
                        Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Carapace_Chestplate.ToString()).FirstOrDefault()),
                    (Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Stimm.ToString()).FirstOrDefault(), null),    //add number
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Manacles.ToString()).FirstOrDefault(), null),
                    (Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Lho_Sticks.ToString()).FirstOrDefault(), null),
                },
                BackgroundAptitude = (AptitudeName.Offence, AptitudeName.Defence),
                RecommendedRoles = new List<string> { RoleName.Assassin.ToString(), RoleName.Desperado.ToString(), RoleName.Warrior.ToString(), RoleName.Seeker.ToString() }
            },
            new Background(BackgroundName.Adeptus_Astra_Telepathica.ToString())
            {
                BackgroundBonuds = adeptusAstraTelepaticaBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Deceive).FirstOrDefault(),
                        Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Interrogation).FirstOrDefault()),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Psyniscience).FirstOrDefault(),
                        Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Scrutiny).FirstOrDefault()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Awarness).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Forbidden_Lore).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Staff.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Whip.ToString()).FirstOrDefault()),
                    (Equipment.Collections.WeaponCollection.Weapons.Where( a => a.Name == WeaponName.Laspistiol.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ArmorCollection.Armors.Where ( t => t.Name == ArmorName.Light_Flak_Cloak.ToString()).FirstOrDefault(),
                        Equipment.Collections.ArmorCollection.Armors.Where ( t => t.Name == ArmorName.Flak_Vest.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Micro_Bead.ToString()).FirstOrDefault(),
                        Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Psy_Focus.ToString()).FirstOrDefault()),
                },
                BackgroundAptitude = (AptitudeName.Defence, AptitudeName.Psyker),
                RecommendedRoles = new List<string> { RoleName.Chirurgeon.ToString(), RoleName.Mystic.ToString(), RoleName.Sage.ToString(), RoleName.Seeker.ToString() }
            },
            new Background(BackgroundName.Adeptus_Mechanicus.ToString())
            {
                BackgroundBonuds = adeptusMechanicusBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Awarness).FirstOrDefault(),
                        Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Operate).FirstOrDefault()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Logic).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Security).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Tech_Use).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()).FirstOrDefault(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Mechandendrite_Use.ToString()).FirstOrDefault(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Autogun.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Hand_Cannon.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Imperial_Robes.ToString()).FirstOrDefault(), null),
                    (Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Sacred_Ungents.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Monotask_Servo_Skull.ToString()).FirstOrDefault(),
                        Equipment.CyberneticCollection.Cybernetics.Where ( t => t.Name == CyberneticName.Utility_Mechandendrite.ToString()).FirstOrDefault()),
                },
                BackgroundAptitude = (AptitudeName.Knowledge, AptitudeName.Tech),
                RecommendedRoles = new List<string> { RoleName.Chirurgeon.ToString(), RoleName.Hierophant.ToString(), RoleName.Sage.ToString(), RoleName.Seeker.ToString() },
                Trait = Traits.TraitList.Traits.Where (t => t.Name == TraitName.Mechanicus_Implants.ToString()).FirstOrDefault() as Trait

            },
            new Background(BackgroundName.Adeptus_Ministorum.ToString())
            {
                BackgroundBonuds = adeptusMinistorumBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Inquiry).FirstOrDefault(),
                        Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Security).FirstOrDefault()),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Charm).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Command).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Linguistics).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()).FirstOrDefault(),
                    Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()).FirstOrDefault())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Hand_Flamer.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Stub_Revolver.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Imperial_Robes.ToString()).FirstOrDefault(),
                        Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Flak_Vest.ToString()).FirstOrDefault()),
                    (Equipment.GearCollection.Gear.Where ( t => t.Name == GearName.Backpack.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Glow_Globe_or_Stablight.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Monotask_Servo_Skull.ToString()).FirstOrDefault(), null)
                },
                BackgroundAptitude = (AptitudeName.Leadship, AptitudeName.Social),
                RecommendedRoles = new List<string> { RoleName.Chirurgeon.ToString(), RoleName.Hierophant.ToString(), RoleName.Warrior.ToString(), RoleName.Seeker.ToString() }
            },
            new Background(BackgroundName.Imperial_Guard.ToString())
            {
                BackgroundBonuds = imprialGuardBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Athletics).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Navigate).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Command).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Medicae).FirstOrDefault(),
                        Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Operate).FirstOrDefault())
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(), null),
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(), null)
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Laspistiol.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Lasgun.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Imperial_Guard_Flak_Armour.ToString()).FirstOrDefault(), null),
                    (Equipment.GearCollection.Gear.Where ( t => t.Name == GearName.Combat_Vest.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Gapnel_and_Line.ToString()).FirstOrDefault(), null),
                    (Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Lho_Sticks.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Magnoculars.ToString()).FirstOrDefault(), null)
                },
                BackgroundAptitude = (AptitudeName.Fieldcraft, AptitudeName.Leadship),
                RecommendedRoles = new List<string> { RoleName.Assassin.ToString(), RoleName.Desperado.ToString(), RoleName.Hierophant.ToString(), RoleName.Warrior.ToString() }
            },
            new Background(BackgroundName.Outcast.ToString())
            {
                BackgroundBonuds = outcastBonus,
                BackgroundSkills = new List<ValueTuple<AbstractSkill, AbstractSkill>>
                {
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Acrobatics).FirstOrDefault(),
                        Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Sleght_of_Hand).FirstOrDefault()),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Deceive).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Dodge).FirstOrDefault(), null),
                    (Skills.SkillList.CommonSkills.Where( s => s.Name == Skills.SkillName.Stealth).FirstOrDefault(), null),
                    (Skills.SkillList.SpecializedSkills.Where( s => s.Name == Skills.SkillName.Common_Lore).FirstOrDefault(), null),
                },
                BackgroundsTalents = new List<ValueTuple<Talents.Talent, Talents.Talent>>
                {
                    (Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault(),
                        Talents.TalentList.Talents.Where( t => t.Name == TalentName.Weapon_Training.ToString()). FirstOrDefault())
                },
                BackgroundEquipment = new List<ValueTuple<Equipment.Interfaces.IItem, Equipment.Interfaces.IItem>>
                {
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Laspistiol.ToString()).FirstOrDefault(),
                        Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Autopistol.ToString()).FirstOrDefault()),
                    (Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Armoured_Bodyglove.ToString()).FirstOrDefault(),
                        Equipment.Collections.ArmorCollection.Armors.Where( a => a.Name == ArmorName.Flak_Vest.ToString()).FirstOrDefault()),
                    (Equipment.Collections.WeaponCollection.Weapons.Where( w => w.Name == WeaponName.Chainsword.ToString()).FirstOrDefault(), null),
                    (Equipment.Collections.ToolsCollection.Tools.Where ( t => t.Name == ToolName.Inhaler_or_Injector.ToString()).FirstOrDefault(), null),
                    (Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Obscura.ToString()).FirstOrDefault(),
                        Equipment.DrugsAndConsumablesCollection.DrugsAndConsumables.Where ( t => t.Name == DrugsAndConsumablesName.Slaught.ToString()).FirstOrDefault()),
                },
                BackgroundAptitude = (AptitudeName.Fieldcraft, AptitudeName.Social),
                RecommendedRoles = new List<string> { RoleName.Assassin.ToString(), RoleName.Desperado.ToString(), RoleName.Seeker.ToString() }
            },            
            #endregion

        };

    }
}
