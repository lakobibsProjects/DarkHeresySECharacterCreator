using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    /// <summary>
    /// General functionality of weapon
    /// </summary>
    public interface IWeapon : IItem
    {
        WeaponType Type { get; }
        WeaponClass Class { get; }
        int Range { get; }
        Tuple<int, int, int> Damage { get; }
        DamageType DamageType { get; }
        int Penetration { get; }
        WeaponSpecialQualitie[] SpecialQualities { get; }
        IWeaponModification[] WeaponModifications { get; set; }
    }
}
