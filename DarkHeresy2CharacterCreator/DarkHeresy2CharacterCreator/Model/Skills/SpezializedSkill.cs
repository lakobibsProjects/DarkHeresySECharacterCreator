using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    /// <summary>
    /// Instantiate logic of skill with specialization
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    class SpecializedSkill : CommonSkill
    {
        String specialization;
        String specializationDiscription;
        public string SpecializationDiscription { get { return specializationDiscription; } set { specializationDiscription = value; } }
        public string Specialization { get { return specialization; } set { specialization = value;  } }

        public SpecializedSkill(SkillName skillName, AptitudeName firstAptitude, AptitudeName secondAptitude, String Specialization, String SpecializationDiscription, Ranking skillRank = 0) 
            :base(skillName, firstAptitude, secondAptitude, skillRank)
        {
            this.Specialization = Specialization;
            this.SpecializationDiscription = SpecializationDiscription;
        }
    }
}
