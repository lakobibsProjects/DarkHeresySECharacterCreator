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
    class Role : INotifyPropertyChanged, ISourceDiscription
    {
        #region Fields
        private string name;
        private List<Tuple<AptitudeName, AptitudeName?>> aptitudes;
        private Tuple<Talent, Talent> roleTalent;
        private string roleBonus;
        private SourceList sourceBook = SourceList.Core_Rulebook_2_edition;
        private int sourcePage = 61;
        #endregion Fields

        #region Properties
        public string Name { get => name; set => name = value; }
        public string RoleBonus { get => roleBonus; set => roleBonus = value; }
        public SourceList SourceBook { get => sourceBook; set => sourceBook = value; }
        public int SourcePage { get => sourcePage; set => sourcePage = value; }
        internal List<Tuple<AptitudeName, AptitudeName?>> Aptitudes { get => aptitudes; set => aptitudes = value; }
        internal Tuple<Talent, Talent> RoleTalent { get => roleTalent; set => roleTalent = value; }
        #endregion Properties

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion

        public Role(string name, string roleBonus, List<Tuple<AptitudeName, AptitudeName?>> aptitudes, Tuple<Talent, Talent> roleTalent)
        {
            Name = name;
            RoleBonus = roleBonus;
            Aptitudes = aptitudes;
            RoleTalent = roleTalent;
        }
    }
}
