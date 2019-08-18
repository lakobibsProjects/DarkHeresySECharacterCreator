using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Talents
{
    internal static class TalentList
    {
        internal static ObservableCollection<Talent> Talents { get; } = new ObservableCollection<Talent>
        {   
            #region Common talents discription
            new Talent(TalentName.Adamantium_Faith.ToString(), adamantiumFaithDiscription, AptitudeName.Willpower, AptitudeName.Defence, 3){
                Prerequisites =
                {
                    (Talents.FirstOrDefault( p => p.Name == "Jaded"), 1),
                    (Talents.FirstOrDefault(p => p.Name == "Resistance" && p.Specializations.First() == "Fear"), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 45)
                }
            },
            new Talent (TalentName.Ambidextrous.ToString(), ambidextrousDiscription, AptitudeName.Weapon_Skill, AptitudeName.Balistic_Skill, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 30) }
            },
            new Talent(TalentName.Armour_Monger.ToString(), armourMongerDiscription, AptitudeName.Intelligence, AptitudeName.Tech, 2)
            {
                Prerequisites =
                {                    
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 35),
                    (Skills.SkillList.CommonSkills.FirstOrDefault(s => s.Name == Skills.SkillName.Tech_Use), 1),
                    (Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == Skills.SkillName.Trade), 1)
                }
            },
            new Talent(TalentName.Assassin_Strike.ToString(), assassinStrikeDiscription, AptitudeName.Weapon_Skill, AptitudeName.Fieldcraft, 3)
            {
                Prerequisites =
                {
                    (Skills.SkillList.CommonSkills.FirstOrDefault(s => s.Name == Skills.SkillName.Acrobatics), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 40)
                }
            },
            new Talent(TalentName.Bastion_of_Iron_Will.ToString(), bastionOfIronWillDiscription, AptitudeName.Willpower, AptitudeName.Psyker, 3)
            {
                Prerequisites =
                {
                    (Traits.TraitList.Traits.FirstOrDefault(t => t.Name == "Psy_Rating"), 1),
                    (Talents.FirstOrDefault( p => p.Name == "Strong Minded"), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 40)
                }
            },
            new Talent(TalentName.Battle_Rage.ToString(), battleRageDiscription, AptitudeName.Strength, AptitudeName.Defence, 2)
            {
                 Prerequisites = { (Talents.FirstOrDefault(p => p.Name == "Frenzy"), 1) }
            },
            new Talent(TalentName.Blademaster.ToString(), bladeMasterDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 30),
                    (Talents.FirstOrDefault(p => p.Name == "Weapon Training"), 1)
                }
            },
            new Talent(TalentName.Blind_Fighting.ToString(), blindFightingDiscription, AptitudeName.Perception, AptitudeName.Fieldcraft, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 30) }
            },
            new Talent (TalentName.Bulging_Biceps.ToString(), bulgingBicepsDiscription, AptitudeName.Strength, AptitudeName.Offence, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Strength), 45) }
            },
            new Talent (TalentName.Catfall.ToString(), catfallDiscription, AptitudeName.Agility, AptitudeName.Fieldcraft, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 30) }
            },
            new Talent(TalentName.Clues_from_the_Crowds.ToString(), cluesFromTheCrowdsDiscription, AptitudeName.General, AptitudeName.Social, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Fellowship), 30) }
            },
            new Talent(TalentName.Combat_Master.ToString(), combatMasterDiscription, AptitudeName.Weapon_Skill, AptitudeName.Defence, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 30) }
            },
            new Talent(TalentName.Constant_Vigilance.ToString(), constantVigilanceDiscription, AptitudeName.Perception, AptitudeName.Defence, 2)
            {
                Specializations = {"Intelegence", "Perception"},
                Prerequisites =
                {
                    (Skills.SkillList.CommonSkills.FirstOrDefault(s => s.Name == Skills.SkillName.Awarness), 2),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 35),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 35)
                }                
            },
            new Talent (TalentName.Contact_Network.ToString(), contactNetworkDiscription, AptitudeName.Fellowship, AptitudeName.Leadship, 2)
            {
                 Prerequisites =
                 {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 35),
                    (Talents.FirstOrDefault(p => p.Name == "Cover-Up"), 1)
                 }
            },
            new Talent (TalentName.Coordinated_Interrogation.ToString(), coordinatedInterrogationDiscription, AptitudeName.Intelligence, AptitudeName.Social, 2)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Strength), 40),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 40),
                    (Talents.FirstOrDefault(p => p.Name == "Clues from the Crowds"), 1)
                }
            },
            new Talent(TalentName.Counter_Attack.ToString(), counterAttackDiscription,  AptitudeName.Weapon_Skill, AptitudeName.Defence, 2)
            {
                 Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40) }
            },
            new Talent (TalentName.Cover_Up.ToString(), coverUpDiscription, AptitudeName.Intelligence, AptitudeName.Knowledge, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 35) }
            },
            new Talent(TalentName.Crushing_Blow.ToString(), crushingBlowDiscription, AptitudeName.Weapon_Skill, AptitudeName.Offence, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40) }
            },
            new Talent(TalentName.Deathdealer.ToString(), deathDealerDiscription, AptitudeName.Perception, AptitudeName.Finesse, 3)
            {
                Specializations = {"Ranged", "Melee"},
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 45) ,
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 45)
                }
            },
            new Talent(TalentName.Delicate_Interrogation.ToString(), delicateInterrogationDiscription, AptitudeName.Intelligence, AptitudeName.Finesse, 3)
            {
                    Prerequisites =
                    {
                        (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Fellowship), 50),
                        (Talents.FirstOrDefault(p => p.Name == "Coordinated interrogation"), 1)
                    }
            },
            new Talent(TalentName.Deny_the_Witch.ToString(), denyTheWitchDiscription, AptitudeName.Willpower, AptitudeName.Defence, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 35) }
            },
            new Talent(TalentName.Devastating_Assault.ToString(), devatatingAssalutDiscription, AptitudeName.Weapon_Skill, AptitudeName.Offence, 2)
            {
                 Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 35) }
            },
            new Talent(TalentName.Die_Hard.ToString(), dieHardDiscription, AptitudeName.Willpower, AptitudeName.Defence, 1)
            {
                 Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 40) }
            },
            new Talent(TalentName.Disarm.ToString(), disarmDiscription, AptitudeName.Weapon_Skill, AptitudeName.Defence, 1)
            {
                 Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 30) }
            },
            new Talent(TalentName.Double_Tap.ToString(), doubleTapDiscription, AptitudeName.Finesse, AptitudeName.Offence, 2)
            {
                 Prerequisites = { (Talents.FirstOrDefault(p => p.Name == "Two-Weapon Wielder"), 1) }
            },
            new Talent(TalentName.Double_Team.ToString(), doubleTeamDiscription, AptitudeName.General, AptitudeName.Offence, 1),
            new Talent(TalentName.Enemy.ToString(), enemyDiscription, AptitudeName.General, AptitudeName.Social, 1)
            {
                Specializations = powerOfAskelon
            },
            new Talent(TalentName.Exotic_Weapon_Training.ToString(), exoticWeaponTrainingDiscription, AptitudeName.Intelligence, AptitudeName.Finesse, 2)
            {
                Specializations = { }  //require add some specializations
            },
            new Talent(TalentName.Eye_of_Vengence.ToString(), eyeOfVengenceDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 50) }
            },
            new Talent (TalentName.Face_in_a_Crowd.ToString(), faceInACrowdDiscription, AptitudeName.Fellowship, AptitudeName.Social, 2)
            {
                Prerequisites =
                {
                        (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Fellowship), 35),
                        (Talents.FirstOrDefault(p => p.Name == "Clues from the Crowds"), 1)
                }
            },
            new Talent (TalentName.Favoured_by_the_Warp.ToString(), favoredByTheWarpDiscription, AptitudeName.Willpower, AptitudeName.Psyker, 3)
            {
                  Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 35) }
            },
            new Talent (TalentName.Ferric_Summons.ToString(), ferricSummonDiscription, AptitudeName.Willpower, AptitudeName.Tech, 1)
            {
                // require add  prerequisites after adding full collection of items and traits
            },
            new Talent("Flash of Inside", flashOfInsideDiscription, AptitudeName.Perception, AptitudeName.Knowledge, 3)
            {
                   Prerequisites =
                   {    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 40),
                        (Talents.FirstOrDefault(p => p.Name == "Contact Network"), 1),
                        (Talents.FirstOrDefault(p => p.Name == "Coordinated Interrogation"), 1)
                   }
            },
            new Talent(TalentName.Frenzy.ToString(), frenzyDiscription, AptitudeName.Strength, AptitudeName.Offence, 1),
            new Talent(TalentName.Halo_of_Command.ToString(), haloOfCommandDiscription, AptitudeName.Fellowship, AptitudeName.Leadship, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Fellowship), 40),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 40)
                }
            },
            new Talent(TalentName.Hammer_Blow.ToString(), hammerBlowDiscription, AptitudeName.Strength, AptitudeName.Offence, 3)
            {
                Prerequisites = { (Talents.FirstOrDefault(p => p.Name == "Crushing Blow"), 1) }
            },
            new Talent(TalentName.Hard_Target.ToString(), hardTargetDiscription, AptitudeName.Agility, AptitudeName.Defence, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 40) }
            },
            new Talent(TalentName.Hardy.ToString(), hardyDiscription, AptitudeName.Toughness, AptitudeName.Defence, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Toughness), 40) }
            },
            new Talent(TalentName.Hatred.ToString(), hatredDiscription, AptitudeName.Weapon_Skill, AptitudeName.Social, 2)
            {
                Specializations = { } //add specializations
            },
            new Talent(TalentName.Hip_Shooting.ToString(), hipShootingDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 2)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 40),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 40)
                }
            },
            new Talent(TalentName.Independent_Targeting.ToString(), independentTargetingDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 40) }
            },
            new Talent (TalentName.Inescapable_Attack.ToString() + " (ranged)", inescapableAttackDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 2)
            {
                 Prerequisites =
                 {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 35),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 40)
                 }
            },
            new Talent (TalentName.Inescapable_Attack.ToString() + " (melee)", inescapableAttackDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 2)
            {
                 Prerequisites =
                 {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 35),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40)
                 }
            },
            new Talent(TalentName.Infused_Knowledge.ToString(), infusedKnowledgeDiscription, AptitudeName.Intelligence, AptitudeName.Knowledge, 3)
            {
                 Prerequisites =
                 {
                    (Skills.SkillList.SpecializedSkills.FirstOrDefault(s => s.Name == Skills.SkillName.Common_Lore || s.Name == Skills.SkillName.Scholastic_Lore
                        || s.Name == Skills.SkillName.Forbidden_Lore), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 40)
                 }
            },
            new Talent (TalentName.Iron_Jaw.ToString(), ironJawDiscription, AptitudeName.Toughness, AptitudeName.Defence, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Toughness), 40) }
            },
            new Talent(TalentName.Jaded.ToString(), jadedDiscription, AptitudeName.Willpower, AptitudeName.Defence, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 40) }
            },
            new Talent(TalentName.Keen_Intuition.ToString(), keenIntuitionDiscription, AptitudeName.Perception, AptitudeName.Social, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 35) }
            },
            new Talent(TalentName.Killing_Strike.ToString(), killingStrikeDiscription, AptitudeName.Weapon_Skill, AptitudeName.Offence, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 50) }
            },
            new Talent(TalentName.Leap_Up.ToString(), leapUpDiscription, AptitudeName.Agility, AptitudeName.General, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 30) }
            },
            new Talent(TalentName.Lightning_Attack.ToString(), lightningAttackDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 1)
            {
                Prerequisites = { (Talents.FirstOrDefault(p => p.Name == TalentName.Swift_Attack.ToString().Replace('_', ' ')), 1) }
            },
            new Talent (TalentName.Luminien_Blast.ToString(), luminienBlastDiscription, AptitudeName.Balistic_Skill, AptitudeName.Tech, 3)
            {
                //add prerequisites after complete adding all items
            },
            new Talent(TalentName.Luminien_Shock.ToString(), luminienShockDiscription, AptitudeName.Weapon_Skill, AptitudeName.Tech, 2)
            {
                //add prerequisites after complete adding all items
            },
            new Talent(TalentName.Maglev_Transcendence.ToString(), maglevTranscendenceDiscription, AptitudeName.Intelligence, AptitudeName.Tech, 2)
            {
                //add prerequisites after complete adding all items
            },
            new Talent(TalentName.Marksman.ToString(), marksmanDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 35) }
            },
            new Talent(TalentName.Mastery.ToString(), masteryDiscription, AptitudeName.Intelligence, AptitudeName.Knowledge, 3)
            {   //relize logic of specialization and prerequisites
                Specializations = { },
                Prerequisites = { }                
            },
            new Talent(TalentName.Mechandendrite_Use.ToString(), mechandendriteUseDiscription, AptitudeName.Intelligence, AptitudeName.Knowledge, 2)
            {
                Specializations = {"Weapon", "Utility"},
                Prerequisites = {(Traits.TraitList.Traits.FirstOrDefault(t => t.Name == "Mechanicus_Implants"), 1) }
            },
            new Talent(TalentName.Mighty_Shot.ToString(), mightyShotDiscription, AptitudeName.Balistic_Skill,  AptitudeName.Offence, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 35) }
            },
            new Talent(TalentName.Never_Die.ToString(), neverDieDiscription, AptitudeName.Toughness, AptitudeName.Defence, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 50),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Toughness), 50)
                }
            },
            new Talent(TalentName.Nowhere_to_Hide.ToString(), nowhereToHideDiscription, AptitudeName.Perception, AptitudeName.Offence, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 30) }
            },
            new Talent(TalentName.Peer.ToString(), peerDiscription, AptitudeName.Fellowship, AptitudeName.Social, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Fellowship), 30) }
            },
            new Talent(TalentName.Precision_Killer.ToString() + " (ranged)", precisionKillerDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 40) }
            },
            new Talent(TalentName.Precision_Killer.ToString() + " (melee)", precisionKillerDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40) }
            },
            new Talent(TalentName.Preternatural_Speed.ToString(), preternaturalSpeedDiscription, AptitudeName.Agility, AptitudeName.Offence, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 50)
                }
            },
            new Talent(TalentName.Prosanguine.ToString(), prosanguineDiscription, AptitudeName.Toughness, AptitudeName.Tech, 2)
            {
                 //add prerequisites after complete adding all items
            },
            new Talent(TalentName.Quick_Draw.ToString(), quickDrawDiscription, AptitudeName.Agility, AptitudeName.Finesse, 1),
            new Talent(TalentName.Rapid_Reload.ToString(), rapidReloadDiscription, AptitudeName.Agility, AptitudeName.Fieldcraft, 1),
            new Talent(TalentName.Resistance.ToString(), resistanceDiscription, AptitudeName.Toughness, AptitudeName.Defence, 1)
            {
                Specializations = {"Cold", "Fear", "Heat", "Poison", "Psychic Power", "Radiation", "Vacuum"}
            },
            new Talent(TalentName.Sound_Constitution.ToString(), soundConstitutionDiscription, AptitudeName.Toughness, AptitudeName.General, 1),
            new Talent(TalentName.Sprint.ToString(), sprintDiscription, AptitudeName.Agility, AptitudeName.Fieldcraft, 3),
            new Talent(TalentName.Sprint.ToString(), sprintDiscription, AptitudeName.Agility, AptitudeName.Defence, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 40),
                    (Skills.SkillList.CommonSkills.FirstOrDefault(s => s.Name == Skills.SkillName.Dodge), 1),
                    (Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == Skills.SkillName.Parry), 1)
                }
            },
            new Talent(TalentName.Strong_Minded.ToString(), strongMindedDiscription, AptitudeName.Willpower, AptitudeName.Defence, 2)
            {
                 Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 30),
                    (Talents.FirstOrDefault(p => p.Name == TalentName.Resistance.ToString().Replace('_',' ') && p.Specializations.Contains("Psychic Power")), 1)
                }
            },
            new Talent (TalentName.Superior_Chirurgeon.ToString(), superriorHirurgeonDiscription, AptitudeName.Intelligence, AptitudeName.Fieldcraft, 3)
            {
                Prerequisites = { (Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == Skills.SkillName.Medicae), 2) }
            },
            new Talent(TalentName.Swift_Attack.ToString(), swiftAttackDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 2)
            {
                 Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 30) }
            },
            new Talent(TalentName.Takedown.ToString(), takedownDiscription, AptitudeName.Weapon_Skill, AptitudeName.Offence, 1),
            new Talent(TalentName.Target_Selection.ToString(), targetSelectionDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 50) }
            },
            new Talent(TalentName.Technical_Knock.ToString(), technicalKnockDiscription, AptitudeName.Intelligence, AptitudeName.Tech, 1)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 30) }
            },
            new Talent(TalentName.Thunder_Charge.ToString(), thunderChargeDiscription, AptitudeName.Strength, AptitudeName.Offence, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Strength), 50) }
            },
            new Talent(TalentName.True_Grit.ToString(), trueGritDiscription, AptitudeName.Toughness, AptitudeName.Defence, 3)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Toughness), 40) }
            },
            new Talent(TalentName.Two_Weapon_Master.ToString(), twoWeaponMasterDiscription, AptitudeName.Finesse, AptitudeName.Offence, 3)
            {
                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 45),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Balistic_Skill), 40),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40),
                    (Talents.FirstOrDefault(p => p.Name == TalentName.Two_Weapon_Wielder.ToString().Replace('_',' ') && p.Specializations.Contains("Melee")), 1),
                    (Talents.FirstOrDefault(p => p.Name == TalentName.Two_Weapon_Wielder.ToString().Replace('_',' ') && p.Specializations.Contains("Ranged")), 1),
                    (Talents.FirstOrDefault(p => p.Name == TalentName.Ambidextrous.ToString().Replace('_',' ')), 1)
                }
            },
            new Talent(TalentName.Two_Weapon_Wielder.ToString(), twoWeaponWielderDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 2)
            {
                Specializations = {"Melee"}
            },
            new Talent(TalentName.Two_Weapon_Wielder.ToString(), twoWeaponWielderDiscription, AptitudeName.Balistic_Skill, AptitudeName.Finesse, 2)
            {
                Specializations = {"Ranged"}
            },
            new Talent(TalentName.Unarmed_Specialist.ToString(), unarmedSpecialistDiscription, AptitudeName.Strength, AptitudeName.Offence, 2)
            {
                                Prerequisites =
                {
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility), 35),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 35),
                    (Talents.FirstOrDefault(p => p.Name == TalentName.Ambidextrous.ToString().Replace('_',' ')), 1)
                }
            },
            new Talent(TalentName.Warp_Conduit.ToString(), warpConduitDiscription, AptitudeName.Willpower, AptitudeName.Psyker, 2)
            {
                Prerequisites =
                {
                    (Traits.TraitList.Traits.FirstOrDefault(t => t.Name == "Psy_Rating"), 1),
                    (Talents.FirstOrDefault( p => p.Name == "Strong Minded"), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 50)
                }
            },
            new Talent(TalentName.Warp_Lock.ToString(), warpLockDiscription, AptitudeName.Willpower, AptitudeName.Psyker, 3)
            {
                Prerequisites =
                {
                    (Traits.TraitList.Traits.FirstOrDefault(t => t.Name == "Psy_Rating"), 1),
                    (Talents.FirstOrDefault( p => p.Name == "Strong Minded"), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Willpower), 50)
                }
            },
            new Talent(TalentName.Warp_Sense.ToString(), warpSenseDiscription, AptitudeName.Perception, AptitudeName.Psyker, 1)
            {
                Prerequisites =
                {
                    (Traits.TraitList.Traits.FirstOrDefault(t => t.Name == "Psy_Rating"), 1),
                    (Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == Skills.SkillName.Psyniscience), 1),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Perception), 30)
                }
            },
            new Talent(TalentName.Weapon_Tech.ToString(), weaponTechDiscription, AptitudeName.Intelligence, AptitudeName.Tech, 1)
            {
                Prerequisites =
                {
                    (Skills.SkillList.SpecializedSkills.FirstOrDefault( s => s.Name == Skills.SkillName.Tech_Use), 2),
                    (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Intelligence), 40)
                }
            },
            new Talent(TalentName.Weapon_Training.ToString(), weaponTrainingDiscription, AptitudeName.General, AptitudeName.Finesse, 1)
            {
                Specializations = {"Bolt", "Chain", "Flame", "Heavy", "Las", "Launcher", "Melta", "Plasma", "Power", "Low-Tech", "Shock", "Solid Projectile"}
            },
            new Talent(TalentName.Whirlewind_of_Death.ToString(), whirewindOfDeathDiscription, AptitudeName.Weapon_Skill, AptitudeName.Finesse, 2)
            {
                Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Weapon_Skill), 40) }
            }
            #endregion Common talents discription
        };

        #region Discriptions
        #region Common talents discription
        private static string adamantiumFaithDiscription = "The Acolyte has become inured to horrors that would cripple lesser men." +
            "This might come from years of facing incoming fire, staring down the terrors of the Warp, or simply his absolute faith" +
            " in the Emperor. He can subtract his Willpower bonus from his degrees of failure on a failed Fear or Pinning test. " +
            "If this reduces the result to zero or less, he counts as having passed the Fear test with 1 degree of success.";
        private static string ambidextrousDiscription = "This talent does not represent true ambidexterity so much as sufficient training" +
            " with both hands to make the distinction moot. When combined with Two-Weapon Wielder talent, the penalty for making attacks with both weapons in the same turn drops to –10.";
        private static string armourMongerDiscription = "The Acolyte is a skilled armourer, and constantly tinkers and improves his armour, or keeps it in pristine" +
            " shape by repairing the slightest damage it sustains.With years of training, he has even learned to enhance the protection afforded by his armour" +
            " and how to use it to its optimum.The character gains an extra amount of Armour points equal to his Intelligence bonus, which he can distribute" +
            " to any locations that his armour would normally cover, as long as he has at least an hour each day to clean and repair it or make minor modifications." +
            "This bonus applies only to armour when the Acolyte is wearing it, as it combines his training with his skill at armoury.";
        private static string assassinStrikeDiscription = "The character’s natural agility and graceful martial form turn him into a dervish of death in combat." +
            "After making a melee attack, a successful Challenging(+0) Acrobatics skill test allows the Acolyte to move at half rate as a Free Action.He may only" +
            " make this move once per round, and the character’s opponent does not receive a free attack resulting from this move.";
        private static string bastionOfIronWillDiscription = "The Acolyte’s sheer willpower and psychic focus have become one and the same, over years of " +
            "practice and training, such that their combined use is second nature.He adds 5 x his psy rating to any Opposed test he makes when defending against psychic powers.";
        private static string battleRageDiscription = "Long experience and indomitable will have allowed the character to master the beast within, directing its rage while" +
            " keeping his head, despite the howling bloodlust in his mind.The Acolyte can Parry while Frenzied, and can re-roll a failed test to snap out of Frenzy or resist" +
            " entering Frenzy if he so chooses.";
        private static string bladeMasterDiscription = "The Acolyte’s mastery of bladed weapons and their martial disciplines has no peer.When attacking with any bladed weapon, including chainswords," +
            " axes, and power swords, he can re-roll one missed attack per round.";
        private static string blindFightingDiscription = "Years of practice and development of his other senses allows the Acolyte to fight in close combat without the benefit of sight." +
            " He ignores all penalties for fighting with a melee weapon while suffering from obscured vision, permitting him to fight in fog, smoke," +
            " or darkness more effectively.Note this talent only improves his chances to hit with melee weapons, and has no effect on ranged weapon attacks.";
        private static string bulgingBicepsDiscription = "Whereas a weaker man might be sent flying by the recoil of a heavy weapon, this Acolyte’s strong physique allows him to " +
            "remain standing.He can fire a heavy weapon using Semi- Auto Burst or Full Auto Burst without bracing the weapon, and does not suffer the –30 penalty" +
            " for failing to brace it.In addition, whenever he uses the Heft special use of the Athletics skill he can add +20 to" +
            " his Athletics skill test to reflect his powerful musculature.";
        private static string catfallDiscription = "Gymnastic ability and natural balance enables the Acolyte to fall great distances without harm.He automatically " +
            "reduces the effective distance of all falls by a number of metres equal to his Agility bonus, ignoring this distance as if it did not exist." +
            " He also adds +20 to his Acrobatics skill tests when using the Jump special skill use, as it pertains to reducing damage from falling.";
        private static string cluesFromTheCrowdsDiscription = "It is often difficult to extract information from groups such as hive gangs or Administratum scribes," +
            " as often numbers can bolster recalcitrance to questioning.A veteran Acolyte knows that such groups can hold critical information to complete" +
            " an investigation, and can throw more effective nets when interrogating groups and reveal valued clues.Once per day, he can re-roll a" +
            " test made to gather information from a group of people.";
        private static string combatMasterDiscription = "The Acolyte’s weapon seems to be everywhere at once, keeping many more opponents at bay in close combat" +
            " than would seem possible.Opponents fighting him in hand-to-hand combat gain no bonuses for Ganging Up.";
        private static string constantVigilanceDiscription = "From years of surviving ambushes and surprise attacks, the Acolyte is always ready for battle." +
            "His subconscious is alert to the slightest footstep or activation of a lasgun pack, and he acts often before he is fully aware of the threat." +
            "When this talent is taken, the character selects the Specialisation that matches the prerequisite (Perception or Intelligence) used in purchase. " +
            "He can use the characteristic that matches that Specialisation when rolling for Initiative instead of his Agility value, and rolls two dice for the roll" +
            " (picking the highest of the two for his score).";
        private static string contactNetworkDiscription = "Acolytes rely on a web of relationships, favours, debts, and obligations that can range from within" +
            " a hab-block to spanning an entire system.Developing and exploiting this network properly  allows them to gain access to weapons, travel" +
            " berths, personnel, and other resources when needed; those who maximise their connections can ensure they are well-armed and well-prepared " +
            "as they face a new heresy.An Acolyte with this talent can use his Fellowship characteristic in place of his Influence when making Requisition tests.";
        private static string coordinatedInterrogationDiscription = "A trained Acolyte, especially when working in conjunction with fellow veteran Acolytes," +
            " can induce cooperation from even the most hardened of suspects and captured heretics.He gains a +10 bonus to all Interrogation tests, and gains" +
            " an additional +5 for each other character participating in the interrogation who also has Coordinated Interrogation.This counts as test assistance," +
            " and thus also gains the standard assistance bonuses as per page 25.";
        private static string counterAttackDiscription = "The Acolyte’s lightning ripostes are things of deadly beauty; swift and invisible as the wind." +
            "Once per turn, after successfully Parrying an opponent’s attack, this character may immediately make a Standard Attack action" +
            " as a Free Action against that opponent using the weapon with which he Parried.The character suffers a –20 penalty on the Weapon Skill test for this attack.";
        private static string coverUpDiscription = "Even the slightest whisper of the Inquisition’s presence can be enough to scatter suspected heretics and drive cults" +
            " into hiding. To prevent the growth and spread of rumours, Acolytes use combinations of well-placed bribes, dire threats, and other means to keep their" +
            " activities as secretive as possible.At the GM’s discretion, the character can reduce his Influence to increase his group’s Subtlety. For every point of" +
            " Influence lost in this way, the Acolyte increases his warband’s Subtlety by 1d5.";
        private static string crushingBlowDiscription = "The Acolyte has the ability to focus his entire body into close combat attacks." +
            "He adds half his Weapon Skill bonus (rounding up) to damage he inflicts with melee attacks.";
        private static string deathDealerDiscription = "The Acolyte can place his hits where they inflict maximum harm, such as gaps or joints in armour." +
            "When this talent is taken, the character selects the Specialisation that matches the prerequisite used in purchase (Melee with Weapon Skill, " +
            "Ranged with Ballistic Skill). When the character’s attack in that combat type inflicts Critical damage, he adds his Perception bonus to the damage result.";
        private static string delicateInterrogationDiscription = "Questioning suspects and witnesses is always a necessary part of any investigation." +
            "Such sessions must remain secretive or obscured, however, lest others learn of the Inquisition’s interest, and a variety of subterfuges, " +
            "deceptions, and outright threats come into play to aid this effort.Whenever the Acolyte would decrease his warband’s Subtlety due to an " +
            "interrogation, the amount of Subtlety lost is reduced by 1d5. If this results in a negative number, the Acolyte’s skilled efforts increase the warband’s Subtlety by 1.";
        private static string denyTheWitchDiscription = "The Acolyte draws on his faith and mental fortitude to act as his shield against those tainted by the Warp." +
            "The character may use his Willpower characteristic when making an Evasion Reaction against ranged or melee attacks against him made with psychic powers." +
            "When successfully evading an attack with an area of effect, the character does not move but instead is simply unaffected by the psychic power.";
        private static string devatatingAssalutDiscription = "The Acolyte launches a furious attack on his foe, the rage of the Emperor powering his assault." +
            "Once per turn, after resolving an All Out Attack action that successfully hits, the character may make a second All Out Attack action against the same target" +
            " as a Free Action, with the same bonuses and penalties as the first.";
        private static string dieHardDiscription = "Through either mental resolve or sheer stubbornness, the Acolyte refuses to fall." +
            "When this character would suffer a level of Fatigue due to the Blood Loss condition, he makes a Challenging (+0) Willpower test;" +
            " if he succeeds, he does not suffer a level of Fatigue.";
        private static string disarmDiscription = "The Acolyte can wrest weapons from his opponents’ hands through practised technique or brute force." +
            "As a Full Action, the character may make an Opposed Weapon Skill test against one target with whom he is engaged.If the Acolyte wins the test," +
            " the enemy drops his weapon to the ground. Should the Acolyte score three or more degrees of success, he can take the enemy’s weapon from him.";
        private static string doubleTapDiscription = "The Acolyte is practiced in making dual attacks, and can almost subconsciously tell when his hits" +
            " strike to best effect.When making a second ranged attack action in the same turn against the same target, he gains a +20 bonus to the attack test" +
            " if his first attack scored one or more successful hits.";
        private static string doubleTeamDiscription = "The Acolyte has experience of fighting in paired teams that work together to take down their enemies." +
            "When Ganging Up on an opponent, he gains an additional +10 bonus to Weapon Skill tests. If both the characters that outnumber the enemy have this talent," +
            " then both gain an additional +10 bonus, for a total of +20. This bonus is in addition to the normal bonus gained from Ganging Up on an opponent.";
        private static string enemyDiscription = "The opposite of Peer; the Acolyte is particularly despised and possibly hunted by a specific social group or organisation," +
            " heretical cult, or xenos race.He suffers an additional –10 penalty to Fellowship and Influence tests when dealing with this group, and the GM can use them to" +
            " complicate his life from time to time. Unlike other talents, Enemy does not cost any xp to purchase and cannot be taken as an advance. Instead the GM and player" +
            " can agree to award it when appropriate to the adventure or campaign. It can be removed with the approval of the GM, if the character has redeemed himself with" +
            " the group in question. The Enemy talent can be awarded multiple times for the same group, in which case it should be listed as Enemy (X)," +
            " with X equalling the number of times the talent has been awarded. This can be used to represent groups who particularly hate the Acolyte" +
            " and want to see him dead. In game terms, the penalty to Fellowship tests increases to –10 times X.";
        private static string exoticWeaponTrainingDiscription = "The Acolyte is trained to use a particularly obscure type of weapon, such as a graviton gun or needle pistol." +
            "Weapons requiring this unique talent are noted in their armoury descriptions.Unlike other kinds of weapons training, this talent applies only to a single weapon " +
            "type and not a class of weapons.Note that an Exotic weapon with the Heavy class would also require the Weapon Training(Heavy) talent as well" +
            " as Exotic Weapon Training in that specific weapon.";
        private static string eyeOfVengenceDiscription = "The Acolyte can focus his intent on where it is likely to do most damage to his enemy and then strike his" +
            " foe down with a single shot.Before making a ranged Standard Attack action, he can spend a Fate point.If he does so, he adds the number of degrees" +
            " of success scored on the attack test to both his damage and penetration for the hit.";
        private static string faceInACrowdDiscription = "A successful investigation often involves trailing suspects without their knowledge, the better to follow them to hidden dens of heretical worship or criminal activity.With training, the Acolyte can ensure none notice his presence, through careful replication of a crowd’s mannerisms or even joining gatherings while still keeping acareful eye on his quarry.When employing the Shadowing special use of the Stealth skill, he can use his Fellowship characteristic instead of his Agility.";
        private static string favoredByTheWarpDiscription = "Whenever this character rolls Psychic Phenomena, so long as he does not receive" +
            " the Perils of the Warp result, he may roll a second time and choose which result he receives.";
        private static string ferricSummonDiscription = "The Acolyte has trained himself in better use of his Ferric Lure Implants. " +
            "He can summon to his hand an unsecured metal object weighing up to 2 kilograms per point of his Willpower bonus, and can summon such objects up to 40 metres distant.";
        private static string flashOfInsideDiscription = "Despite steady application of logic and careful analysis, some conundrums remain insoluble, " +
            "but inspiration could come from outside sources, such as reading patterns from wisps of lho smoke or even making direct appeals to the Emperor for guidance." +
            "An Acolyte who has trained his mind to process such lateral data can leap to conclusions that direct thinking cannot provide," +
            " and thus quash even the most hidden of heresies.When stuck in an investigation, he can spend one Fate point to reveal a single clue or lead to aid in the progression of his efforts.";
        private static string frenzyDiscription = "The Acolyte’s temper and passion boil just below the surface of his psyche, mostly held in check by his rational mind," +
            " but easily released when needed.If he spends one full round fuelling his anger—by flagellation, drugs, or other means—on the next round," +
            " he goes into an uncontrolled rage, gaining a +10 bonus to Weapon Skill, Strength, Toughness, and Willpower, but suffering a –20 penalty to Ballistic Skill," +
            " Intelligence, and Fellowship.Note that characteristic penalties are different from characteristic damage (see page 188), and cannot reduce a characteristic below 1." +
            " While Frenzied, the character must attack the nearest enemy in melee combat if possible.If he is not engaged with the nearest enemy," +
            " he must move towards that enemy and engage it if possible.He will not take obviously suicidal actions such as leaping off a building" +
            " in order to engage someone on the ground, but he will take any actions that offer a reasonable opportunity to engage in melee with the nearest enemy." +
            " While Frenzied, he is immune to Fear, Pinning, Stunning effects, and the effects of Fatigue; he cannot Parry, retreat, or flee." +
            " He remains Frenzied for the duration of the combat, and cannot use psychic powers while Frenzied.After combat ends, or if there are no more eligible enemy targets" +
            " for the character to attack, he can make a Willpower test to snap out of his Frenzy.If he fails, he must continue to attack, favouring NPCs over PCs." +
            " Each successive round, however, he can make another Willpower test, with a cumulative +10 bonus to return to a stable state of mind and come out of Frenzy." +
            " After Frenzying, he cannot Frenzy again for at least an hour, as he recovers his mental and physical strength.";
        private static string haloOfCommandDiscription = "The Acolyte has trained himself to better to lead and sway others, either motivating or terrifying those around him to greater levels. " +
            "When targeting friendly NPCs through skills that have either the Social or Leadership Aptitudes (such as Charm, Command, and Intimidate)," +
            " he can affect those within 100 times his Fellowship bonus in metres rather than 10 times that number.";
        private static string hammerBlowDiscription = "The Acolyte strikes a single blow with such focus and force that it breaks armour and pulps flesh as it strikes." +
            "When he uses an All Out Attack action to make a single melee attack, he can add half his Strength bonus (rounded up) to the weapon’s penetration. " +
            "The attack also counts as having the Concussive (2) weapon quality, to represent the shocking force of the blow’s impact.";
        private static string hardTargetDiscription = "Light on his feet, the Acolyte dodges and weaves as he moves, skills learned from long years in the line of fire." +
            "When he performs a Charge or Run action, opponents suffer a –20 penalty to Ballistic Skill tests made to hit him with ranged attacks. " +
            "This penalty continues until the start of his next turn.";
        private static string hardyDiscription = "The Acolyte’s constitution allows him to rebound quickly from shock or injury." +
            "When undergoing medical treatment or healing from injuries, he always recovers damage as if Lightly Damaged, regardless of the level of damage he sustained.";
        private static string hatredDiscription = "A group, organisation, or race has wronged the character in the past, fuelling this animosity.When fighting opponents" +
            " of that group in close combat, the Acolyte gains a +10 bonus to all Weapon Skill tests made against them.He also finds it difficult to back down" +
            " from a fight with his hated foe, and must make a Challenging (+0) Willpower test to retreat or surrender when fighting them, unless suicidally outnumbered or outclassed.";
        private static string hipShootingDiscription = "The Acolyte’s prowess with ranged weapons is such that he can still fire accurately without his eye behind the sights." +
            "As a Full Action, he can both move up to his Full Move rate and make a single attack with a ranged weapon.This attack can only be a single shot," +
            " and so cannot be a semi- or full-automatic ranged attack for example.Characters with the Two-Weapon Fighting talent can use this talent with" +
            " Hip Shooting to make two single shots, if they are armed with a ranged weapon in each hand.";
        private static string independentTargetingDiscription = "The Acolyte has developed his situational awareness to a point where he can fire in two directions within a split second." +
            "When firing two weapons as part of a single action (using the Two- Weapon Fighting talent, for example), the character does not need his targets to be within 10 metres of each other.";
        private static string inescapableAttackDiscription = "The Acolyte can anticipate his opponent’s reactions, and ensures his hits strike no matter how a foe tries to avoid them." +
            "This talent applies to Melee or Ranged attacks, depending on the Speciality chosen.After making a successful attack test of the appropriate type as part of an" +
            " All Out Attack, Called Shot, Charge, Standard Attack, or Stun action, the character imposes a penalty on all evasion attempts (Dodge or Parry tests)" +
            " made against this attack equal to 10 times the total degrees of success scored on the attack test.";
        private static string infusedKnowledgeDiscription = "The Acolyte has been imbued with a great breadth of lore, either through punishing noetic techniques" +
            " or by arcane methods kept secret by the guardians of technology and learning.He counts as having all Common Lore and Scholastic Lore skills" +
            " at rank 1 (Known)—basically, he knows something about everything.If he wishes to later improve his Lore skills, these advances must be bought" +
            " using experience points(from rank 1) as normal.He also adds one degree of success to any successful Common or Scholastic Lore tests, due to his ingrained training.";
        private static string ironJawDiscription = "The Acolyte has taken blows from Orks and given back as good as he got, bouncing back from most strikes without ill effects." +
            "Whenever this character becomes Stunned, he may make a Challenging (+0) Toughness test as a Free Action to ignore the effects.";
        private static string jadedDiscription = "The Acolyte’s wide travels have shown him both wonders and horrors beyond the ken of most." +
            "The galaxy has thrown its worst at him and he has yet to flinch.Mundane events, from death’s horrific visage to xenos abominations, do not force him to" +
            " gain Insanity points or make Fear tests.Daemons, Warp manifestations, and other unnatural effects still affect him normally.";
        private static string keenIntuitionDiscription = "The Acolyte has trained extensively to notice objects that seem out of place or hidden." +
            "This can bring the smallest irregularity to prominence, revealing the heresy festering beneath the surface. After failing an" +
            " Awareness skill test, the character can re-roll the test with a –10 modifier.";
        private static string killingStrikeDiscription = "With expert precision, the Acolyte can land blows which defy his opponent’s ability to counter," +
            " slicing through defences as surely as a powerblade cuts flesh.At the beginning of each of his turns, the character may spend" +
            " a Fate point to make his melee attacks unavoidable with the Dodge and Parry skills until the end of the round.Other means of avoiding or stopping attacks" +
            " (such as displacer fields or alien protective devices) are unaffected.";
        private static string leapUpDiscription = "A combination of athletic ability and speed allows the Acolyte to spring to his feet in virtually any circumstance." +
            " He can stand up as a Free Action.";
        private static string lightningAttackDiscription = "The Acolyte’s speed with weapons is unmatched, allowing him to launch flurries of attacks in melee." +
            "He can make the Lightning Attack action.";
        private static string luminienBlastDiscription = "The energies charged in the Acolyte’s Luminen Capacitors can be expelled in a ranged attack." +
            "The character always counts as being equipped with a Pistol weapon with a 10m range.This can only be used in single shot mode," +
            " and deals 1d10 plus twice his Willpower bonus in Energy damage, with Pen 0 and the Shocking quality." +
            "The character always counts as having Weapon Training for this weapon and after making an attack with it, he must pass a Toughness test or suffer 1 level of Fatigue.";
        private static string luminienShockDiscription = "The energies charged in the Acolyte’s Luminen Capacitors can be expelled by touching a foe." +
            "The character always counts as being equipped with a melee weapon that inflicts 1d10 plus his WPB in Energy damage, with Pen 0 and the Shocking quality." +
            "He always counts as having Weapon Training for it and after making this attack, he must pass a Toughness test or suffer 1 level of Fatigue.";
        private static string maglevTranscendenceDiscription = "The Acolyte has learned how to better use his implanted maglev coils, and can hover for a number of minutes equal to 1d10" +
            " plus twice his Toughness bonus.He can move his Run speed when making a Half Move action and suffers no damage from falling if the coils are active." +
            "Each use drains half the power stored in the coils (therefore he can use the coils twice before recharging them).";
        private static string marksmanDiscription = "The Acolyte’s steady hand and eagle eye allow him to keep crosshairs steady on any target, regardless of range." +
            "Distance is no protection against the character’s marksmanship, and he suffers no penalties for making Ballistic Skill tests at Long or Extreme range.";
        private static string masteryDiscription = "The Acolyte has mastered a single skill. He can spend a Fate point to automatically pass a skill test with his chosen skill," +
            " provided the final modifier to his skill test is Challenging(+0) or better.He scores a number of degrees of success equal to the characteristic bonus" +
            " of the skill’s associated characteristic.This talent may be taken more than once, each time for a different skill.";
        private static string mechandendriteUseDiscription = "The Acolyte is trained in the use of a particular kind of mechadendrite in much the same way as Weapon Training " +
            "allows the use of weapons.Though there are many different types of mechadendrites, this talent divides them into two broad categories:" +
            "\n • Weapon: Mechadendrites of this type end in either ranged or close combat weapons, and have the supplemental power supplies and mechanical support necessary for combat." +
            "\n • Utility: Including such varied types as Manipulator, Medicae, Utility, Optical, and countless others, these generally require less hardy mountings," +
            " but all function in a similar manner.";
        private static string mightyShotDiscription = "The Acolyte knows the weak points in every type of armour and material, and has the skill to ensure that his shots" +
            " land exactly where they can do the most damage.He adds half his Ballistic Skill bonus(rounded up) to damage he inflicts with ranged weapons.";
        private static string neverDieDiscription = "The Acolyte’s will or devotion to the Emperor can sustain him when his mortal body fails." +
            "He may spend one Fate point to ignore the effects of injury(such as those from Critical damage), Fatigue, and Stunning for a single combat," +
            " so long as they would not kill him immediately.This talent does not prevent the damage, but allows him to temporarily ignore its effects for" +
            " the duration of the combat.Once the encounter ends, the effects trigger as normal.";
        private static string nowhereToHideDiscription = "The Acolyte’s keen eye ensures he can spot soft points even in the most impregnable of protective cover." +
            "When he damages cover, the character adds his degrees of success from the attack to the reduction of the cover’s Armour value." +
            "If using a weapon that does not require a skill test, he adds 1 instead.";
        private static string peerDiscription = "The Acolyte knows how to deal with a particular social group or organisation, or even xenos race." +
            "He gains a +10 bonus to all Fellowship and Influence tests when interacting with this chosen group, and at the GM’s discretion can" +
            " sometimes call upon them for favours.The GM and player may agree to award this talent when appropriate to the adventure or campaign, " +
            "though the character must still pay the experience cost for the Talent as normal. This talent can be awarded multiple times for the same group, " +
            "in which case it should be listed as Peer(X), with X equalling the number of times the talent has been awarded.This can be used to represent groups" +
            " who particularly like the character and may even be staunch allies.In game terms, the bonus to Fellowship tests increases to +10 times X." +
            " Additionally, when the character acquires this talent, he increases his Influence by 1.";
        private static string precisionKillerDiscription = "The Acolyte’s eye, hand, and weapon act seamlessly together, placing his attacks exactly where he intends." +
            "When this talent is taken, the character selects the Specialisation that matches the Characteristic and Aptitude pair (Ballistic Skill or Weapon Skill)" +
            " used in purchase. When making a Called Shot with a melee or ranged attack(depending on the Specialisation), he does not suffer the usual –20 penalty.";
        private static string preternaturalSpeedDiscription = "The Acolyte is a swift-moving bringer of death, a living, bloody scythe before whom foes die like corn before the reaper." +
            "When making a Charge action, he doubles his normal Charge movement(for instance, if he has an Agility bonus of 3 and thus a Charge movement of 9 metres, " +
            "his movement is then doubled to 18 metres with this talent).";
        private static string prosanguineDiscription = "Through the Acolyte’s iron will, he is able to speed the function of his Autosanguinator." +
            "He must spend 10 minutes in meditation and make a Tech-Use test. If he succeeds, he removes 1d5 points of damage.If he rolls a 96 or higher," +
            " he loses the ability to use his Autosanguinator for one week.";
        private static string quickDrawDiscription = "The Acolyte has practised so frequently with his weapons that they practically leap into his hands in response to a simple thought." +
            "As a Free Action, the character may draw and ready a Pistol or Basic weapon, or a one-handed Melee weapon.";
        private static string rapidReloadDiscription = "The firing ranges and weapon drill chambers are the Acolyte’s constant abode." +
            "Hours of reloading countless magazines or power cells means that he can replace them without looking and without thinking, " +
            "even in the middle of combat.He halves all reload times, rounding down. Thus, a Half Action reload becomes a Free Action, a Full Action reload becomes a Half Action, and so on.";
        private static string resistanceDiscription = "The Acolyte’s background, experience, training, exposure, or plain stubbornness has developed a resistance within him." +
            "Each time he selects this talent, choose one area of resistance.He gains a +10 bonus when making tests to resist effects of this type." +
            "The GM can require approval for certain choices, or justification based on he Acolyte’s past.";
        private static string soundConstitutionDiscription = "The Acolyte gains an additional wound. He can purchase this talent additional times up to twice his Toughness bonus. " +
            "When he gains this talent multiple times, note the number of times it has been taken after the talent, such as Sound Constitution (3).";
        private static string sprintDiscription = "The Acolyte moves at great speeds, and when taking a Full Move action can move an extra number of metres" +
            " equal to his Agility bonus.Additionally, whenever he takes a Run action, he may move double the normal distance. If he did so in the previous round," +
            " however, he suffers 1 level of Fatigue.";
        private static string stepAsideDiscription = "Swaying his body out of the path of an attack, the Acolyte causes the shot to pass through thin air, " +
            "or turns his blade mid-swing to deflect a blow. He can make an additional Evasion attempt(either a Dodge or a Parry) once per round.In effect, " +
            "this gives him a second Reaction that can only be used for Dodge or Parry attempts, allowing two Dodges, two Parries, or a Dodge and a Parry in each turn." +
            "However, he can still only attempt a single Dodge or Parry against each individual attack.";
        private static string strongMindedDiscription = "The Acolyte’s mind acts as a fortress against psychic attacks. He can re-roll failed Willpower tests to resist" +
            " any psychic powers that affect his mind.This talent does not affect psychic powers that have a physical effect, such as Smite or Assail.";
        private static string superriorHirurgeonDiscription = "The Acolyte’s advanced medical training enables him to knit flesh with deft mastery, essential for" +
            " treating combat casualties.His exceptional education in use of the Narthecium, Med-Slate, and supplemental drugs give his patients an enormous advantage." +
            "He gains a +20 bonus on all Medicae skill tests.When providing first aid, he ignores the penalties for Heavily Damaged patients and only suffers a –10 penalty " +
            "for those suffering Critical damage.";
        private static string swiftAttackDiscription = "The Acolyte’s ability with weapons is legendary, allowing him to attack with amazing speed in melee.He can make the Swift Attack action.";
        private static string takedownDiscription = "When making a Standard Attack or Charge action, the Acolyte can declare that he is attempting a takedown his target." +
            "He then rolls to hit(using his Weapon Skill) as normal, applying all the regular modifiers for the attack action.If the character hits and would have done" +
            " at least 1 point of damage(after reduction for Armour and Toughness), no wounds are caused.Instead, the opponent must make a Challenging (+0) Toughness test" +
            " or be Stunned for 1 Round and knocked Prone.In addition, when performing a Stun Action, the character does not suffer the normal –20 penalty to his Weapon Skill.";
        private static string targetSelectionDiscription = "The Acolyte’s dread gaze marks out his chosen victim, and not even the riotous confusion of close combat interferes." +
            "He can shoot into melee with no penalty.If he also makes an Aim action beforehand, he prevents any chance of hitting friendly targets as well.";
        private static string technicalKnockDiscription = "Either through the ease of long practice, or the proper ritual to appease a weapon’s machine spirit, " +
            "the Acolyte can clear stoppages with a simple knock or solid smack of his hand to a weapon.Once per round, he may attempt to unjam a gun as a Half Action" +
            " rather than a Full Action.He must touch the weapon to make use of this talent.";
        private static string thunderChargeDiscription = "The Acolyte charges into combat using his body as an additional weapon.Driven by his rage and momentum, the" +
            " impact of such a charge can knock foes flying or bring them to their knees.When he makes a Charge action, he can barrel through enemies to get to his target." +
            "The character makes an Opposed Strength test against each foe in his way(those who his movement would take him past or through). Each foe that loses the Opposed test" +
            " is knocked Prone. After resolving these Opposed tests, the character’s Charge action resolves against his original target as normal.";
        private static string trueGritDiscription = "The Acolyte is able to shrug off wounds that would fell lesser men. Whenever he suffers Critical damage" +
            "(after reduction for Armour and Toughness), reduce the amount by his Toughness bonus(to a minimum of 1 damage).";
        private static string twoWeaponMasterDiscription = "The Acolyte has mastered the difficult ability of wielding a weapon in each hand, making him deadly both in personal " +
            "and shortranged attacks.When armed with two single-handed weapons (such as a pistol or sword in either hand), he ignores the –20 penalty for Two-Weapon Fighting.";
        private static string twoWeaponWielderDiscription = "Intensive training allows the Acolyte to use a weapon in each hand when needed." +
            "When armed with two one-handed weapons (ether melee or ranged weapons), after making a Half Action attack(this can be a Single Attack, " +
            "a Swift Attack, or a Lightning Attack with a melee weapon, or it can be a single shot, semi-auto burst, or full auto burst with a ranged weapon), " +
            "he can make a single additional Half Action attack following the same restrictions with the other weapon as a Free Action.In effect, this allows him to " +
            "attack twice in a round, once from each of his weapons.Both of these attacks count as being part of the same Half Action, and both tests made to attack " +
            "with the weapons suffer a –20 penalty. This talent can be taken twice, each time with a different specialisation(melee or ranged). " +
            "If he possesses both talents, then he can fight with one melee and one ranged weapon.When this talent is taken with the melee focus it counts as having the" +
            " Weapon Skill and Finesse aptitudes, and when it is taken with the ranged focus it counts as having the Ballistic Skill and Finesse aptitudes.";
        private static string unarmedSpecialistDiscription = "After extensive training, the Acolyte has made his body as dangerous as any Munitorum-issued weapon." +
            "He gains the Deadly Natural Weapon trait, and counts as armed even when facing weapon-wielding opponents while barehanded.While fighting barehanded, " +
            "he can also re-roll the damage he inflicts.";
        private static string warpConduitDiscription = "The sheer power of the Acolyte’s mind allows him to channel vast amounts of Warp energy when he chooses.When Pushing, " +
            "before rolling his Focus Power test the character may spend one Fate Point to add an additional 1d5 to the effective psy rating of the power." +
            "Channelling such vast amounts of power is dangerous, however, and so he adds +30 to rolls Psychic Phenomena when he makes as a result of this talent.";
        private static string warpLockDiscription = "The Acolyte has learned to swiftly cut himself off from the Warp to protect himself from harm." +
            "Once per game session, he may ignore the Psychic Phenomena he has rolled (including the Perils of the Warp result on Psychic Phenomena, " +
            "completely negating its effects.Such rapid dislocation from the Warp, though, is stressful and traumatic to his mind. " +
            "He suffers 1d5 Energy damage to the Head location (not reduced by Armour or Toughness) as a result, and cannot make any Focus Power tests or" +
            " sustain other psychic powers until the beginning of his next turn.";
        private static string warpSenseDiscription = "The Acolyte’s senses have evolved to perceive the Warp in parallel with the physical world." +
            "The character can use the Psyniscience Skill as a Free Action instead of as a Half Action.He can also passively detect psychic effects and " +
            "entities without the need to actively seek them out. Whenever the character could detect such a Warp signature or a creature, the GM can allow him " +
            "to make a Psyniscience skill test to detect it, in the same way he could use Awareness to spot an ambush without knowing it is there.";
        private static string weaponTechDiscription = "The Acolyte calls upon the blessings of the Omnissiah, channelling his faith into his weapon and performing" +
            " armament rituals to more readily smite his foes.Once per combat encounter, as a Free Action, this character may enhance any Melta, Plasma, Power," +
            " or Exotic weapon he is personally wielding.This increases the weapon’s damage and penetration by an amount equal to the character’s Intelligence bonus until the end of the round.";
        private static string weaponTrainingDiscription = "The Acolyte can use all weapons with Class: Pistol, Basic, Melee, Throwing, and Vehicle within the group he has selected with this talent." +
            "When a character attempts to use a weapon he does not have the correct Weapon Training talent for, he suffers a –20 penalty to any relevant Weapon Skill or Ballistic Skill test." +
            " The character can only use weapons with Class: Heavy without suffering the –20 penalty if he has both Weapon Training in the appropriate group and Weapon Training (Heavy)." +
            " This talent can be taken more than once, each time with a different Specialisation. Note that a character without the Weapon Training (Low-Tech) talent operating a" +
            " weapon that functions as a Low-Tech weapon in certain circumstances does not suffer this penalty, so long as he has the applicable Weapon Training talent for the weapon" +
            " (Power for a power sword, for example).";
        private static string whirewindOfDeathDiscription = "When facing massed opponents in close quarters, the Acolyte becomes a streak of blows, moving, " +
            "hacking, gutting, and beheading his enemies with ceaseless fury.As a Half Action, the character may make one Standard Attack action " +
            " with a melee weapon against a foe, plus one additional Standard Attack action with the same weapon targeting each other foe also engaged " +
            "in melee combat with the character beyond the first(to a maximum number of attacks up to his Weapon Skill bonus).";
        #endregion Common talents discription
        private static string Discription = "";
        private static readonly ObservableCollection<string> powerOfAskelon;
        #endregion Discriptions
    }
}
