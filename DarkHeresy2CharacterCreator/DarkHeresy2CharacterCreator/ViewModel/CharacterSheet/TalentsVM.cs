using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Talents;
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
    public class TalentsVM
    {
        #region Fields
        private ObservableCollection<Talent> allTalents = TalentList.Talents;

        private DelegateCommand addTalent;
        private DelegateCommand removeTalent;
        #endregion Fields

        #region Propeties
        public ICharacter Character { get; set; }
        public int ExpirienceToAdd { get; set; }
        public ICommand AddTalent => addTalent;
        public ICommand RemoveTalent => removeTalent;
        public ITalent SelectedAvailableTalent { get; set; }
        public ITalent SelectedOwnTalent{ get; set; }
        public ObservableCollection<Talent> AllTalents
        {
            get { return allTalents; }
            set { allTalents = value; }
        }

        #endregion Propeties

        #region Constructor
        public TalentsVM()
        {
            Character = MainWindowVM.SelectedCharacter;
            addTalent = new DelegateCommand(obj => Character.Talents.Add(obj as Talent));
            removeTalent = new DelegateCommand(obj => Character.Talents.Remove(obj as Talent));
        }
        #endregion Constructor

        #region Helped Methods

        #endregion Helped Methods

        #region Commands

        #endregion Commands
    }
}
