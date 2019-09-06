using DarkHeresy2CharacterCreator.Model.Equipment;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.PsychicPowers
{
    class AttackPsychicPower : PsychicPower, IRangedWeapon
    {
        public Tuple<int, int, int> RateOfFire => throw new NotImplementedException();

        public int Clip => throw new NotImplementedException();

        public double Reload => throw new NotImplementedException();

        public WeaponType Type => throw new NotImplementedException();

        public WeaponClass Class => throw new NotImplementedException();

        public Tuple<int, int, int> Damage => throw new NotImplementedException();

        public DamageType DamageType => throw new NotImplementedException();

        public int Penetration => throw new NotImplementedException();

        public WeaponSpecialQualitie[] SpecialQualities => throw new NotImplementedException();

        public IWeaponModification[] WeaponModifications { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEquiped { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Availability Availability => throw new NotImplementedException();

        public double Weight => throw new NotImplementedException();

        public string Discription => throw new NotImplementedException();

        public Craftsmanship Craftsmanship { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int IWeapon.Range => throw new NotImplementedException();

        string IItem.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
