using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    /// <summary>
    /// General functionality of weapons modifications
    /// </summary>
    public interface IWeaponModification : IItem
    {
       WeaponClass appropriateWeaponClass{get;}
    }
}
