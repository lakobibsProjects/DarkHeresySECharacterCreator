using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    class CommonSkill : AbstractSkill
    {      
        public CommonSkill(SkillName skillName, AptitudeName firstAptitude, AptitudeName secondAptitude, Ranking skillRank = 0)
        {
            Name = skillName;
            Rank = skillRank;
            FirstAptitude = firstAptitude;
            SecondAptitude = secondAptitude;
        }       

    }
}
