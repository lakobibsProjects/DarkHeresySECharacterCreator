using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.DiceRoller
{
    public static class DiceRoller
    {
        static int Roll()
        {
            return new Random().Next(1, 101);
        }
        static int Roll(int dice)
        {
            return new Random().Next(1, dice + 1);
        }
    }
}
