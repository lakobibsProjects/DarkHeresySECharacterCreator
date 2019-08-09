using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    interface IWeapon : IItem
    {
        string Type { get; }
        WeaponClasses Class { get; }
        int Range { get; }
        int Damage { get; }
        DamageTypes DamageType { get; }
        int Penetration { get; }
        WeaponSpecialQualities[] SpecialQualities { get; }
        IWeaponModification[] WeaponModifications { get; set; }
    }
}
