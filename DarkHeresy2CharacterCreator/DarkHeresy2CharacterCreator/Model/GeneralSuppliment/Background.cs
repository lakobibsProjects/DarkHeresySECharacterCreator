using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    class Background : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private List<ISkill> backgroundSkills;
        private List<Talent> backgroundsTalents;
        private List<IItem> backgroundEquipment;
        private string backgroundBonuds;
        private List<Aptitudes> backgroundAptitude;
        private List<Role> recommendedRoles;
        #endregion Fields
        #region Properties
        public string Name { get; set; }
        public string BackgroundBonuds { get => backgroundBonuds; set => backgroundBonuds = value; }
        internal List<ISkill> BackgroundSkills { get => backgroundSkills; set => backgroundSkills = value; }
        internal List<Talent> BackgroundsTalents { get => backgroundsTalents; set => backgroundsTalents = value; }
        internal List<IItem> BackgroundEquipment { get => backgroundEquipment; set => backgroundEquipment = value; }
        internal List<Aptitudes> BackgroundAptitude { get => backgroundAptitude; set => backgroundAptitude = value; }
        internal List<Role> RecommendedRoles { get => recommendedRoles; set => recommendedRoles = value; }
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
