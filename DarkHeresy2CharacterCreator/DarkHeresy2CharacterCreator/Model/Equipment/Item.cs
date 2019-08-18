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
    class Item : IItem
    {
        #region Fields
        private string name;
        private bool isEquiped = false;
        private Availability availability;
        private double weight;
        private string discription;
        private Craftsmanship craftsmanship = Craftsmanship.Common;

        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public bool IsEquiped { get => isEquiped; set => isEquiped = value; }
        public Availability Availability { get => availability; set => availability = value; }
        public double Weight { get => weight; set => weight = value; }

        public string Discription { get => discription; set => discription = value; }

        public Craftsmanship Craftsmanship { get => craftsmanship; set => craftsmanship = value; }
        #endregion

        public Item(string name, Availability availability, double weight, string discription)
        {
            Name = name;
            Availability = availability;
            Weight = weight;
            Discription = discription;
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
