using DarkHeresy2CharacterCreator.Model.Character;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CharacterSheetVM
    {
        #region Properties
        public ICharacter Character{ get; set; }
        #endregion

        public CharacterSheetVM()
        {
            Character = MainWindowVM.SelectedCharacter;
        }
    }
}
