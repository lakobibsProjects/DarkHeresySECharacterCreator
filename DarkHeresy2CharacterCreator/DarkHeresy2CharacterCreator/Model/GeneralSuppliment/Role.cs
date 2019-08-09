using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    class Role : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private List<Aptitudes> aptitudes;
        private Tuple<Talent, Talent> roleTalent;
        private string roleBonus;
        #endregion Fields

        #region Properties
        public string Name { get => name; set => name = value; }
        public string RoleBonus { get => roleBonus; set => roleBonus = value; }
        internal List<Aptitudes> Aptitudes { get => aptitudes; set => aptitudes = value; }
        internal Tuple<Talent, Talent> RoleTalent { get => roleTalent; set => roleTalent = value; }
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
