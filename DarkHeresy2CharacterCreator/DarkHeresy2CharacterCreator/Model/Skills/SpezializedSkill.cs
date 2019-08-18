using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    class SpecializedSkill : CommonSkill
    {
        String specialization;
        String specializationDiscription;
        public string SpecializationDiscription { get { return specializationDiscription; } set { specializationDiscription = value; OnPropertyChanged("SpecializationDiscription"); } }
        public string Specialization { get { return specialization; } set { specialization = value; OnPropertyChanged("Specialization"); } }

        public SpecializedSkill(SkillName skillName, AptitudeName firstAptitude, AptitudeName secondAptitude, String Specialization, String SpecializationDiscription, Ranking skillRank = 0) 
            :base(skillName, firstAptitude, secondAptitude, skillRank)
        {
            this.Specialization = Specialization;
            this.SpecializationDiscription = SpecializationDiscription;
        }
    }
}
