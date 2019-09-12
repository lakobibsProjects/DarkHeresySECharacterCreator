using DarkHeresy2CharacterCreator.Model.Characteristics;
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
                HomeWorldAptitude = AptitudeName.Toughness ,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Forge World")
            {
                FateTreshold = 3,
                EmperorsBlessing = 8,
                HomeWorldBonus = forgeWorldBonus,
                Wounds = 8,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Intelligence, CharacteristicName.Toughness, CharacteristicName.Fellowship },
                HomeWorldAptitude = AptitudeName.Intelligence ,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Highborn")
            {
                FateTreshold = 4,
                EmperorsBlessing = 10,
                HomeWorldBonus = heighbornBonus,
                Wounds = 9,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Fellowship, CharacteristicName.Influence, CharacteristicName.Toughness },
                HomeWorldAptitude = AptitudeName.Fellowship ,
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
                HomeWorldAptitude = AptitudeName.Willpower ,
                RekommendedBackgrouns = new Background[]{ }
            },
            new HomeWorld("Voidborn")
            {
                FateTreshold = 3,
                EmperorsBlessing = 5,
                HomeWorldBonus = voidbornBonus,
                Wounds = 7,
                Characteristics = new CharacteristicName[3] { CharacteristicName.Intelligence, CharacteristicName.Willpower, CharacteristicName.Strength },
                HomeWorldAptitude = AptitudeName.Intelligence ,
                RekommendedBackgrouns = new Background[]{ }
            },
            #endregion Core Rulebook
        };

        #region Bonuses
        private static string feralWorldBonus = "";
        private static string forgeWorldBonus = "";
        private static string heighbornBonus = "";
        private static string hiveWorldBonus = "";
        private static string shrineWorldBonus = "";
        private static string voidbornBonus = "";
        #endregion
    }
}
