using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using DarkHeresy2CharacterCreator.Model.Traits;
using PropertyChanged;
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
    /// <summary>
    /// Instantiate logic of background
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Background : ISourceDiscription
    {
        #region Fields
        private string name;
        private List<ValueTuple<AbstractSkill, AbstractSkill>> backgroundSkills;
        private List<ValueTuple<Talent, Talent>> backgroundsTalents;
        private List<ValueTuple<IItem, IItem>> backgroundEquipment;
        private string backgroundBonuds;
        private ValueTuple<AptitudeName, AptitudeName> backgroundAptitude;
        private List<RoleName> recommendedRoles;
        private SourceList sourceBook = SourceList.Core_Rulebook_2_edition;
        private int sourcePage = 44;
        private Trait trait;
        #endregion Fields
        #region Properties
        public string Name { get { return name; } set { name = value; } }
        public string BackgroundBonuds { get => backgroundBonuds; set => backgroundBonuds = value; }
        public List<ValueTuple<AbstractSkill, AbstractSkill>> BackgroundSkills { get => backgroundSkills; set => backgroundSkills = value; }
        public List<ValueTuple<Talent, Talent>> BackgroundsTalents { get => backgroundsTalents; set => backgroundsTalents = value; }
        public List<ValueTuple<IItem, IItem>> BackgroundEquipment { get => backgroundEquipment; set => backgroundEquipment = value; }
        public ValueTuple<AptitudeName, AptitudeName> BackgroundAptitude { get => backgroundAptitude; set => backgroundAptitude = value; }
        public List<RoleName> RecommendedRoles { get => recommendedRoles; set => recommendedRoles = value; }
        public SourceList SourceBook { get => sourceBook; set => sourceBook = value; }
        public int SourcePage { get => sourcePage; set => sourcePage = value; }
        public Trait Trait { get => trait; set => trait = value; }
        #endregion Properties

        public Background(string name)
        {
            Name = name;
        }


    }
}
