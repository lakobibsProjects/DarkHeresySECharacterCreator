using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Traits
{
    static class TraitList
    {
        internal static ObservableCollection<ITrait> Traits { get; } = new ObservableCollection<ITrait>();
    }
}
