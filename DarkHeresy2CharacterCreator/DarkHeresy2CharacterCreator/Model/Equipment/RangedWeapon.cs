using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{
    class RangedWeapon : Weapon, IRangedWeapon
    {
        private Tuple<int, int, int> rateOfFire;
        private int clip;
        private double reload;
        public Tuple<int, int, int> RateOfFire { get => rateOfFire; set => rateOfFire = value; }

        public int Clip { get => clip; set => clip = value; }

        public double Reload { get => reload; set => reload = value; }
        public RangedWeapon()
        {

        }
        public RangedWeapon(string name)
        {
            Name = name;
        }
    }
}
