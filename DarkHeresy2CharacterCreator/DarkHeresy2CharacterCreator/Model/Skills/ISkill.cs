using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    interface ISkill : INotifyPropertyChanged
    {
        Skill Name{ get; }
        Ranking Rank { get; set; }
        Aptitudes firstAptitude { get; }
        Aptitudes secondAptitude { get; }
        int Cost { get; }

    }
}
