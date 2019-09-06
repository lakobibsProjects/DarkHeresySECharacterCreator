using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    /// <summary>
    /// General functionality of ranged weapon
    /// </summary>
    internal interface IRangedWeapon : IWeapon
    {
        Tuple<int, int, int> RateOfFire { get; }
        int Clip { get; }
        double Reload { get; }
    }
}
