using DarkHeresy2CharacterCreator.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model
{
    /// <summary>
    /// Interface to classes, that have cost, that deteminite by aptitudes
    /// </summary>
    public interface IAptitudeDependent
    {
        AptitudeName FirstAptitude { get; }
        AptitudeName SecondAptitude { get; }
        int Cost { get; }
        void ChangeAdvanceCost(IEnumerable<AptitudeName> CharecterAptitudes);
    }
}
