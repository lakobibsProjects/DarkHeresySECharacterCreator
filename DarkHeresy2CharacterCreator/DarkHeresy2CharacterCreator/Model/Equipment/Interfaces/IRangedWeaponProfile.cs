﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    interface IRangedWeapon : IWeapon
    {
        int[] RateOfFire { get; }
        int Clip { get; }
        double Reload { get; }
    }
}
