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
        SkillName Name{ get; set; }
        Ranking Rank { get; set; }
        AptitudeName FirstAptitude { get; }
        AptitudeName SecondAptitude { get; }
        int Cost { get; }

    }
}
