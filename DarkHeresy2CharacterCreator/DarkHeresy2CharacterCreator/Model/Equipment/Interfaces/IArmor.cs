using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    interface IArmor : IItem
    {
        ArmorTypes ArmorType { get; }
        Locations LocationCovered { get; }
        int ArmorPoints { get; }
        int MaxAgility { get; }

    }
}
