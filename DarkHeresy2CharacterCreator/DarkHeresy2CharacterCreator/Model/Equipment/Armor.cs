using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using PropertyChanged;
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
    /// Instantiate logic of armor
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    internal class Armor : IArmor
    {
        #region Fields
        private string name;
        private ArmorType armorType;
        private LocationName[] locationCovered;
        private int armorPoints;
        private int maxAgility;
        private bool isEquiped = false;
        private Availability availability;
        private double weight;
        private string discription;
        private Craftsmanship craftsmanship = Craftsmanship.Common;

        #endregion Fields
        #region Discription
        public ArmorType ArmorType { get => armorType; set => armorType = value; }

        public LocationName[] LocationCovered { get => locationCovered; set => locationCovered = value; }

        public int ArmorPoints { get => armorPoints; set => armorPoints = value; }

        public int MaxAgility { get => maxAgility; set => maxAgility = value; }

        public string Name { get => name; set => name = value; }
        public bool IsEquiped { get => isEquiped; set => isEquiped = value; }

        public Availability Availability { get => availability; set => availability = value; }

        public double Weight { get => weight; set => weight = value; }

        public string Discription { get => discription; set => discription = value; }

        public Craftsmanship Craftsmanship { get => craftsmanship; set => craftsmanship = value; }
        #endregion Discription
        #region Constructor
        public Armor()
        {

        }
        public Armor(string name)
        {
            Name = name;
        }
        #endregion Constructor
    }
}
