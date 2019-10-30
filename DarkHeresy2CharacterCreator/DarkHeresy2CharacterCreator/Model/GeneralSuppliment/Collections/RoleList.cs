using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    /// <summary>
    /// Instaniate a observableCollection of roles
    /// </summary>
    public static class RoleList
    {
        #region Role bonuses
        private static readonly string assassinBonus = "Sure Kill: In addition to the normal uses of Fate points, when an Assassin successfully hits with an attack," +
            " he may spend a Fate point to inflict additional damage equal to his degrees of success on the attack roll on the first hit the attack inflicts.";
        private static readonly string chirurgeonBonus = "Dedicated Healer: In addition to the normal uses of Fate points, when a Chirurgeon character fails a test " +
            "to provide First Aid, he can spend a Fate point to automatically succeed instead with the degrees of success equal to his Intelligence bonus.";
        private static readonly string desperadoBonus = "Move and Shoot: Once per round, after performing a Move action, a Desperado character may perform a single Standard Attack " +
            "with a Pistol weapon he is currently wielding as a Free Action.";
        private static readonly string hierophantBonus = "Sway the Masses: In addition to the normal uses of Fate points, a Hierophant character may spend a Fate point " +
            "to automatically succeed at a Charm, Command, or Intimidate skill test with a number of degrees of success equal to his Willpower bonus.";
        private static readonly string mysticBonus = "Stare into the Warp: A Mystic character starts the game with the Psyker elite advance. " +
            "It is recommended that a character who wishes to be a Mystic have a Willpower of at least 35.";
        private static readonly string sageBonus = "Quest for Knowledge: In addition to the normal uses of Fate points, a Sage character may spend a Fate point " +
            "to automatically succeed at a Logic or any Lore skill test with a number of degrees of success equal to his Intelligence bonus.";
        private static readonly string seekerBonus = "Nothing Escapes My Sight: In addition to the normal uses of Fate points, a Seeker character " +
            "may spend a Fate point to automatically succeed at an Awareness or Inquiry skill test with a number of degrees of success equal to his Perception bonus.";
        private static readonly string warriorBonus = "Expert at Violence: In addition to the normal uses of Fate points, after making a successful attack test, " +
            "but before determining hits, a Warrior character may spend a Fate point to substitute his Weapon Skill(for melee) or Ballistic Skill(for ranged) bonus" +
            " for the degrees of success scored on the attack test.";
        private static readonly string fanaticBonus = "";
        private static readonly string penitentBonus = "";
        private static readonly string aceBonus = "";
        private static readonly string crusaderBonus = "";
        #endregion
        /// <summary>
        /// Collection of roles
        /// </summary>
        public static ObservableCollection<Role> Roles = new ObservableCollection<Role>
        {
            new Role(RoleName.Assassin.ToString(), assassinBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Agility, null), (AptitudeName.Balistic_Skill, AptitudeName.Weapon_Skill),
                    (AptitudeName.Fieldcraft, null), (AptitudeName.Finesse, null), (AptitudeName.Perception, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Jaded.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Leap_Up.ToString()))
                ),
            new Role(RoleName.Chirurgeon.ToString(), chirurgeonBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Fieldcraft, null),(AptitudeName.Intelligence, null), (AptitudeName.Knowledge, null),
                    (AptitudeName.Strength, null), (AptitudeName.Toughness, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Resistance.ToString()),  //need logic to choise specialization
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Takedown.ToString()))
                ),
            new Role(RoleName.Desperado.ToString(), desperadoBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Agility, null), (AptitudeName.Balistic_Skill, null),(AptitudeName.Defence, null),
                    (AptitudeName.Fellowship, null), (AptitudeName.Finesse, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Catfall.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Quick_Draw.ToString()))
                ),
            new Role(RoleName.Hierophant.ToString(), hierophantBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Fellowship, null), (AptitudeName.Offence, null), (AptitudeName.Social, null),
                    (AptitudeName.Toughness, null), (AptitudeName.Willpower, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Double_Tap.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Hatred.ToString()))     //need logic to choise specialization
                ),
            new Role(RoleName.Mystic.ToString(), mysticBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Defence, null), (AptitudeName.Intelligence, null), (AptitudeName.Knowledge, null),
                    (AptitudeName.Perception, null), (AptitudeName.Willpower, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Resistance.ToString()),   //need logic to choise specialization
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Warp_Sense.ToString()))
                ),
            new Role(RoleName.Sage.ToString(), sageBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Tech, null), (AptitudeName.Intelligence, null), (AptitudeName.Knowledge, null),
                    (AptitudeName.Perception, null), (AptitudeName.Willpower, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Ambidextrous.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Clues_from_the_Crowds.ToString()))
                ),
            new Role(RoleName.Seeker.ToString(), seekerBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Tech, null), (AptitudeName.Intelligence, null), (AptitudeName.Fellowship, null),
                    (AptitudeName.Perception, null), (AptitudeName.Social, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Keen_Intuition.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Disarm.ToString()))
                ),
            new Role(RoleName.Warrior.ToString(), warriorBonus, new List<ValueTuple<AptitudeName, AptitudeName?>>
                {
                    (AptitudeName.Balistic_Skill, null), (AptitudeName.Defence, null), (AptitudeName.Offence, null),
                    (AptitudeName.Strength, null), (AptitudeName.Weapon_Skill, null)
                },
                (TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Iron_Jaw.ToString()),
                TalentList.Talents.FirstOrDefault(p => p.Name == TalentName.Rapid_Reload.ToString()))
                ),
        };


    }
}
