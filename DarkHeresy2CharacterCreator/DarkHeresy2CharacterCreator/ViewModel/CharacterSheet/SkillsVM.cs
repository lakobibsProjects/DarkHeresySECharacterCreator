﻿using DarkHeresy2CharacterCreator.Model.Character;
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
        public ObservableCollection<AbstractSkill> SpecializedSkills { get; set; }
        public ICommand IncreaceCommonSkillRank => increaceCommonSkillRank;
        public ICommand IncreaceSpecializedSkillRank => increaceSpecializedSkillRank;
        #endregion Propeties

        #region Constructor
        public SkillsVM()
        {
            Character = MainWindowVM.SelectedCharacter;
            increaceCommonSkillRank = new DelegateCommand(obj => Character.Skills.Where( s => s.Name == SelectedCommonSkill.Name).FirstOrDefault().Rank++);
            increaceSpecializedSkillRank = new DelegateCommand(obj => Character.Skills.Where(s => s.Name == SelectedSpecializedSkill.Name).FirstOrDefault().Rank++);
            InitializeCollections();
        }
        #endregion Constructor

        #region Helped Methods
        private void InitializeCollections()
        {
            var commonSkillsQuerry = Character.Skills.Where(s => s is CommonSkill);
            var specializedSkillsQuery = Character.Skills.Where(s => s is SpecializedSkill);
            CommonSkills = new ObservableCollection<AbstractSkill>(commonSkillsQuerry);
            SpecializedSkills = new ObservableCollection<AbstractSkill>(specializedSkillsQuery);
        }
        #endregion Helped Methods

        #region Commands

        #endregion Commands
    }
}