using DarkHeresy2CharacterCreator.Model.Characteristics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    class HomeWorld : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private Characteristic[] characteristics = new Characteristic[3];
        private int fateTreshold;
        private int emperorsBlessing;
        private string homeWorldBonus;
        private Aptitudes homeWorldAptitude;
        private int wounds;
        private Background[] rekommendedBackgrouns;
        #endregion Fields

        #region Properties
        public string Name { get => name; set => name = value; }
        public int FateTreshold { get => fateTreshold; set => fateTreshold = value; }
        public int EmperorsBlessing { get => emperorsBlessing; set => emperorsBlessing = value; }
        public string HomeWorldBonus { get => homeWorldBonus; set => homeWorldBonus = value; }
        public int Wounds { get => wounds; set => wounds = value; }
        internal Characteristic[] Characteristics { get => characteristics; set => characteristics = value; }
        internal Aptitudes HomeWorldAptitude { get => homeWorldAptitude; set => homeWorldAptitude = value; }
        internal Background[] RekommendedBackgrouns { get => rekommendedBackgrouns; set => rekommendedBackgrouns = value; }
        #endregion Properties


        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion
    }
}
