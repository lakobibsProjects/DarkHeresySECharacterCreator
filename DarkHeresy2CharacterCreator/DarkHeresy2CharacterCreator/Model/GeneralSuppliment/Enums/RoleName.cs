using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    /// <summary>
    /// Names of roles
    /// </summary>
    public enum RoleName
    {
        Assassin,
        Chirurgeon,
        Desperado,
        Hierophant,
        Mystic,
        Sage,
        Seeker,
        Warrior,
        Fanatic = 200,  //rulebook: enemy within
        Penitent,
        Ace = 300,     //rulebook: enemy without
        Crusader = 400 //rulebook: enemy beyond
    }
}
