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
        Skill Name{ get; set; }
        Ranking Rank { get; set; }
        Aptitudes FirstAptitude { get; }
        Aptitudes SecondAptitude { get; }
        int Cost { get; }

    }
}
