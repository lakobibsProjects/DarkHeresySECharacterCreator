using DarkHeresy2CharacterCreator.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model
{
    interface IAptitudeDependent
    {
        Aptitudes FirstAptitude { get; }
        Aptitudes SecondAptitude { get; }
        int Cost { get; }
        void DetermineAdvanceCost(IEnumerable<Aptitudes> CharecterAptitudes);
        void Update(ICharacter character);
    }
}
