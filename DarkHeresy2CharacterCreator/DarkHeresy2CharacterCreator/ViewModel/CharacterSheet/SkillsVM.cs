using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.CharacterSheet
{
    [AddINotifyPropertyChangedInterface]
    class SkillsVM
    {
        #region Fields
        private DelegateCommand increaceCommonSkillRank;
        private DelegateCommand increaceSpecializedSkillRank;
        #endregion Fields

        #region Propeties
        public ICharacter Character { get; set; }
        public AbstractSkill SelectedCommonSkill { get; set; }
        public AbstractSkill SelectedSpecializedSkill { get; set; }
        public ObservableCollection<AbstractSkill> CommonSkills { get; set; }
        public ObservableCollection<SpecializedSkill> SpecializedSkills { get; set; }
        public ICommand IncreaceCommonSkillRank => increaceCommonSkillRank;
        public ICommand IncreaceSpecializedSkillRank => increaceSpecializedSkillRank;
        #endregion Propeties

        #region Constructor
        public SkillsVM()
        {
            Character = MainWindowVM.OpenedCharacter;
            increaceCommonSkillRank = new DelegateCommand(obj => Character.CommonSkills.Where( s => s.Name == SelectedCommonSkill.Name).FirstOrDefault().IncreaceRank(Character));
            increaceSpecializedSkillRank = new DelegateCommand(obj => Character.SpecializedSkills.Where(s => s.Name == SelectedSpecializedSkill.Name).FirstOrDefault().IncreaceRank(Character));
            InitializeCollections();
        }
        #endregion Constructor

        #region Helped Methods
        private void InitializeCollections()
        {            
            var specializedSkillsQuery = Character.SpecializedSkills;
            var commonSkillsQuerry = Character.CommonSkills;
            CommonSkills = new ObservableCollection<AbstractSkill>(commonSkillsQuerry);
            SpecializedSkills = new ObservableCollection<SpecializedSkill>(specializedSkillsQuery);
        }
        #endregion Helped Methods

        #region Commands

        #endregion Commands
    }
}
