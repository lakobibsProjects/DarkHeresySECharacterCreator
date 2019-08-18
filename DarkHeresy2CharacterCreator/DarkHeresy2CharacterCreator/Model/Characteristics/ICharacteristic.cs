using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    public interface ICharacteristic : IAptitudeDependent, IPrerequisitable,INotifyPropertyChanged
    {
        CharacteristicName Name { get; }
    }
}
