using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.DiceRoller
{
    public static class DiceRoller
    {
        #region roll
        static int Roll(int dice = 100)
        {
            return new Random().Next(1, dice + 1);
        }
        static int[] Roll(int dice, int numberOfDices)
        {
            int[] temp = new int[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, dice + 1);
            return temp;
        }
        #endregion roll

        #region Five
        static int RollFive()
        {
            return new Random().Next(1, 6);
        }
        static int[] RollFive(int numberOfDices)
        {
            int[] temp = new int [numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, 6);            
            return temp;
        }
        #endregion Five

        #region Ten
        static int RollTen()
        {
            return new Random().Next(1, 11);
        }
        static int[] RollTen(int numberOfDices)
        {
            int[] temp = new int[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, 6);
            return temp;
        }
        #endregion Ten
    }
}
