using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Talents
{
    interface ITalent : INotifyPropertyChanged
    {
        string Name { get; set; }
        Aptitudes firstAptitude { get; }
        Aptitudes secondAptitude { get; }
        int Cost { get; }
        string Discription { get; set; }
    }
}
