﻿using DarkHeresy2CharacterCreator.Model.Characteristics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections
{
    /// <summary>
    /// Instaniate a observableCollection of homeworlds
    /// </summary>
    public static class HomeWorldList
    {

        #region Bonuses
        private static string feralWorldBonus = "The Old Ways: In the hands of a feral world character, any Low-Tech weapon loses the Primitive quality " +
        "(if it had it) and gains the Proven(3) quality.";
        private static string forgeWorldBonus = "Omnissiah’s Chosen: A forge world character starts with either the Technical Knock or Weapon-Tech talent.";
        private static string heighbornBonus = "Breeding Counts: Any time a highborn character would reduce his Influence, he reduces it by 1 less(to a minimum reduction of 1).";
        private static string hiveWorldBonus = "Teeming Masses in Metal Mountains: A hive world character ignores crowds for purposes of movement," +
        " treating them as open terrain.When in enclosed spaces, he also gains a +20 bonus to Navigate (Surface) tests.";
        private static string shrineWorldBonus = "Faith in the Creed: Whenever a shrine world character spends a Fate point, he rolls 1d10." +
        " On a result of 1, the character’s total number of Fate points is not reduced.";
        private static string voidbornBonus = "Child of the Dark: A voidborn character starts with the Strong Minded talent, " +
        "and gains a +30 bonus to tests for moving in a zero gravity environment.";
        #endregion
        /// <summary>
        /// Collection of homeworlds
        /// </summary>
        public static ObservableCollection<HomeWorld> HomeWorlds = new ObservableCollection<HomeWorld>
        {
        //TODO correct and add recomended backgrounds
        #region Core Rulebook
        new HomeWorld("Feral World")
            {
                FateTreshold = 2,
                EmperorsBlessing = 3,
                HomeWorldBonus = feralWorldBonus,
                Wounds = 9,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Strength, CharacteristicName.Toughness, CharacteristicName.Influence },
                HomeWorldAptitude = AptitudeName.Toughness,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Forge World")
            {
                FateTreshold = 3,
                EmperorsBlessing = 8,
                HomeWorldBonus = forgeWorldBonus,
                Wounds = 8,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Intelligence, CharacteristicName.Toughness, CharacteristicName.Fellowship },
                HomeWorldAptitude = AptitudeName.Intelligence,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Highborn")
            {
                FateTreshold = 4,
                EmperorsBlessing = 10,
                HomeWorldBonus = heighbornBonus,
                Wounds = 9,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Fellowship, CharacteristicName.Influence, CharacteristicName.Toughness },
                HomeWorldAptitude = AptitudeName.Fellowship,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Hive World")
            {
                FateTreshold = 2,
                EmperorsBlessing = 6,
                HomeWorldBonus = hiveWorldBonus,
                Wounds = 8,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Agility, CharacteristicName.Perception, CharacteristicName.Willpower },
                HomeWorldAptitude = AptitudeName.Perception,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Shrine World")
            {
                FateTreshold = 3,
                EmperorsBlessing = 6,
                HomeWorldBonus = shrineWorldBonus,
                Wounds = 7,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Fellowship, CharacteristicName.Willpower, CharacteristicName.Perception },
                HomeWorldAptitude = AptitudeName.Willpower,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Voidborn")
            {
                FateTreshold = 3,
                EmperorsBlessing = 5,
                HomeWorldBonus = voidbornBonus,
                Wounds = 7,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Intelligence, CharacteristicName.Willpower, CharacteristicName.Strength },
                HomeWorldAptitude = AptitudeName.Intelligence,
                RekommendedBackgrouns = new Background[]{ }
            },
            #endregion Core Rulebook
        };


    }
}
