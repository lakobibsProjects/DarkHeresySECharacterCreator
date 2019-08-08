using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.PsychicPowers
{
    interface IPsychicPower : INotifyPropertyChanged
    {
        string Name { get; }
        int Cost { get; }
        object[] Prerequisites { get; }
        Action Action { get; }
        Tuple<int, Characteristics.Characteristics> FocusPower { get; }
        Tuple<int, string> Range { get; }
        Action Sustained { get; }
        string Subtype { get; }
        string Effect { get; }
        PsychisSchools School { get; }
        
    }
}
