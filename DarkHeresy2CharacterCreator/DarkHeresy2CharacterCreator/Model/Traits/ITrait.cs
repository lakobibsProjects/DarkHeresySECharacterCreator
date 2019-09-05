using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Traits
{
    /// <summary>
    /// General fuctionality to trait
    /// </summary>
    public interface ITrait : IPrerequisitable
    {
        string Name { get; set; }
        string Discription { get; set; }
        int Modifier { get; set; }
        bool HasModifire { get; set; }
    }
}
