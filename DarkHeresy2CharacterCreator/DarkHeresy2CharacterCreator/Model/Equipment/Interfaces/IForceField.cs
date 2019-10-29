using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    /// <summary>
    /// General functionality of force fields
    /// </summary>
    interface IForceField : IItem
    {
        int ProtectionRating { get; }
    }
}
