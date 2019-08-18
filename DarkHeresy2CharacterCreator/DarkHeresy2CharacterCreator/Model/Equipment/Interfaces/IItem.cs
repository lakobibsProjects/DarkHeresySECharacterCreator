using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Interfaces
{
    public interface IItem : INotifyPropertyChanged
    {
        string Name { get; set; }
        bool IsEquiped { get; set; }
        Availability Availability { get; }
        double Weight { get; }
        string Discription { get; }
        Craftsmanship Craftsmanship { get; set; }
    }
}
