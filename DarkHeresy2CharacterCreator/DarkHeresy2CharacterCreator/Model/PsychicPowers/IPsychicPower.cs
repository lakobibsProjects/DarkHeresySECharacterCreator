using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.PsychicPowers
{
    public interface IPsychicPower : IPrerequisitable, INotifyPropertyChanged
    {
        string Name { get; }
        int Cost { get; }
        object[] Prerequisites { get; }
        ActionLong Action { get; }
        Tuple<int, Characteristics.CharacteristicName> FocusPower { get; }
        Tuple<int, string> Range { get; }
        ActionLong Sustained { get; }
        string Subtype { get; }
        string Effect { get; }
        PsychisSchools School { get; }

    }
}
