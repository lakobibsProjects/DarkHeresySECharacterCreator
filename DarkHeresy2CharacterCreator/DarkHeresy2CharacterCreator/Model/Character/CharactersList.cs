using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    [AddINotifyPropertyChangedInterface]
    public static class CharactersList
    {
        public static ObservableCollection<ICharacter> Characters = new ObservableCollection<ICharacter>()
        {
            new Character()
            {
                CharacterName = "Unnamed Character",
                TotalExpirience = 1000
                
            }
        };
    }
}
