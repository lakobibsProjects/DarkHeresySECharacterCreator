﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    /// <summary>
    /// General functionality of armor
    /// </summary>
    public interface IArmor : IItem
    {
        ArmorType ArmorType { get; }
        LocationName[] LocationCovered { get; }
        int ArmorPoints { get; }
        int MaxAgility { get; }

    }
}
