using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{

    /// <summary>
    /// Instantiate logic of weapon
    /// </summary>
    internal class Weapon : IWeapon
    {
        #region Fields
        private string name;
        private WeaponType type;
        private WeaponClass weaponClass;
        private int range;
        private Tuple<int, int, int> damage;
        private DamageType damageType;
        private int penetration;
        private WeaponSpecialQualitie[] weaponSpecialQualities;
        private IWeaponModification[] weaponModifications = new IWeaponModification[4];
        private bool isEquiped;
        private Availability availability;
        private double weight;
        private string discription;
        private Craftsmanship craftsmanship = Craftsmanship.Common;
        #endregion Fields

        #region Properties
        public WeaponType Type { get => type; set => type = value; }

        public WeaponClass Class { get => weaponClass; set => weaponClass = value; }

        public int Range { get => range; set => range = value; }

        public Tuple<int, int, int> Damage { get => damage; set => damage = value; }

        public DamageType DamageType { get => damageType; set => damageType = value; }

        public int Penetration { get => penetration; set => penetration = value; }

        public WeaponSpecialQualitie[] SpecialQualities { get => weaponSpecialQualities; set => weaponSpecialQualities = value; }

        public IWeaponModification[] WeaponModifications { get => weaponModifications; set => weaponModifications = value; }
        public string Name { get => name; set => name = value; }
        public bool IsEquiped { get => isEquiped; set => isEquiped = value; }

        public Availability Availability { get => availability; set => availability = value; }

        public double Weight { get => weight; set => weight = value; }

        public string Discription { get => discription; set => discription = value; }

        public Craftsmanship Craftsmanship { get => craftsmanship; set => craftsmanship = value; }
        #endregion Properties
        public Weapon()
        {

        }
        public Weapon(string name)
        {
            Name = name;
        }

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion
    }
}
