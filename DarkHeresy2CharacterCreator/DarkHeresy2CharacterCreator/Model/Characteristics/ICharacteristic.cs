using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    interface ICharacteristic : INotifyPropertyChanged
    {
        Characteristics Name { get; set; }
        Aptitudes firstAptitude { get; }
        Aptitudes secondAptitude { get; }
        int Cost { get; }
    }
}
