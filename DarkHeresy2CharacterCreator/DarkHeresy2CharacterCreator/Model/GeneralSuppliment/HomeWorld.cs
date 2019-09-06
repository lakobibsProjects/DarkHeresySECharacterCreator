using DarkHeresy2CharacterCreator.Model.Characteristics;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    /// <summary>
    /// Instantiate logic of homeworld
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class HomeWorld
    {
        #region Fields
        private string name;
        private CharacteristicName[] characteristics = new CharacteristicName[3];
        private int fateTreshold;
        private int emperorsBlessing;
        private string homeWorldBonus;
        private AptitudeName homeWorldAptitude;
        private int wounds;
        private Background[] rekommendedBackgrouns;
        #endregion Fields

        #region Properties
        public string Name { get => name; set => name = value; }
        public int FateTreshold { get => fateTreshold; set => fateTreshold = value; }
        public int EmperorsBlessing { get => emperorsBlessing; set => emperorsBlessing = value; }
        public string HomeWorldBonus { get => homeWorldBonus; set => homeWorldBonus = value; }
        public int Wounds { get => wounds; set => wounds = value; }
        internal CharacteristicName[] Characteristics { get => characteristics; set => characteristics = value; }
        internal AptitudeName HomeWorldAptitude { get => homeWorldAptitude; set => homeWorldAptitude = value; }
        internal Background[] RekommendedBackgrouns { get => rekommendedBackgrouns; set => rekommendedBackgrouns = value; }
        #endregion Properties

        public HomeWorld(string name)
        {
            Name = name;
        }       
    }
}
