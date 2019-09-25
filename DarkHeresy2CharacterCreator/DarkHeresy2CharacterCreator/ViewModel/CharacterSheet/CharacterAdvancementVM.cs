using DarkHeresy2CharacterCreator.Model.Character;
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
    public class CharacterAdvancementVM
    {
        #region Fields
        private DelegateCommand addExpierience;
        #endregion Fields

        #region Propeties
        public ICharacter Character { get; set; }
        public int ExpirienceToAdd { get; set; }
        public ICommand AddExpierience => addExpierience;
        #endregion Propeties

        #region Constructor
        public CharacterAdvancementVM()
        {
            Character = MainWindowVM.SelectedCharacter;
            addExpierience = new DelegateCommand(obj => Character.TotalExpirience += ExpirienceToAdd);
        }
        #endregion Constructor

        #region Helped Methods

        #endregion Helped Methods

        #region Commands

        #endregion Commands
    }
}
