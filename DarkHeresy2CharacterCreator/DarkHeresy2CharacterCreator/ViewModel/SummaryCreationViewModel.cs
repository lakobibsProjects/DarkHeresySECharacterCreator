using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.DiceRoller;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class SummaryCreationViewModel
    {
        private ICharacter createdcharacter;
        private Divinations divination;
        private DelegateCommand setDivinationCommand;
        public Divinations Divination
        {
            get { return divination; }
            set { divination = value; }
        }


        public ICharacter CreatedCharacter
        {
            get { return createdcharacter; }
            set { createdcharacter = value; }
        }
        public ICommand SetDivinationCommand => setDivinationCommand;


        public SummaryCreationViewModel()
        {
            CreatedCharacter = MainWindowVM.SelectedCharacter;
            setDivinationCommand = new DelegateCommand(setDivination);
        }
        
        private void setDivination(object obj)
        {
            CreatedCharacter.Divination = DiceRoller.Roll();
            Divination = new Divinations(CreatedCharacter.Divination);
        }

    }
}
