using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    interface IWeaponModification : IItem
    {
       WeaponClasses appropriateWeaponClass{get;}
    }
}
