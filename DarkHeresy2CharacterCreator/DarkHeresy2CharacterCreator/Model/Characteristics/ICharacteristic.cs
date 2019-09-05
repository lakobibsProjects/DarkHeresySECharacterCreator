using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    /// <summary>
    /// General functionality of characteristic
    /// </summary>
    public interface ICharacteristic : IAptitudeDependent, IPrerequisitable
    {
        CharacteristicName Name { get; }
    }
}
