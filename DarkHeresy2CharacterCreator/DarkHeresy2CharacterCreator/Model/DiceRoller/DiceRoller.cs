using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.DiceRoller
{
    /// <summary>
    /// Roll some dices
    /// </summary>
    public static class DiceRoller
    {
        /// <summary>
        /// Roll dices
        /// </summary>
        /// <param name="dice">Dice value. By default 100</param>
        /// <param name="numberOfDices">Number of rolled dices. By default 1</param>
        /// <returns>Array of result of roll</returns>
        #region roll
        public static int[] Roll(int dice = 100, int numberOfDices = 1)
        {
            if (dice < 1 || numberOfDices < 1)
                throw new ArgumentException("Dice and number of dices cannot being lower 1");
            int[] temp = new int[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, dice + 1);
            return temp;
        }
        /// <summary>
        /// Roll one d100
        /// </summary>
        /// <returns></returns>
        public static int Roll()
        {
            return new Random().Next(1, 101);
        }
        #endregion roll

        /// <summary>
        /// Roll d5
        /// </summary>
        /// <returns>Result of roll d5</returns>
        #region Five
        public static int RollFive()
        {
            return new Random().Next(1, 6);
        }

        /// <summary>
        /// Roll dome d5
        /// </summary>
        /// <param name="numberOfDices">Number of rolled dices. By default 1</param>
        /// <returns>Array of result of roll</returns>
        public static int[] RollFive(int numberOfDices = 1)
        {
            if (numberOfDices < 1)
                throw new ArgumentException("Number of dices cannot being lower 1");
            int[] temp = new int[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, 6);
            return temp;
        }
        #endregion Five

        /// <summary>
        /// Roll d10
        /// </summary>
        /// <returns>Result of roll</returns>
        #region Ten
        public static int RollTen()
        {
            return new Random().Next(1, 11);
        }
        /// <summary>
        /// Roll dome d10
        /// </summary>
        /// <param name="numberOfDices">Number of rolled dices. By default 1</param>
        /// <returns>Array of result of roll</returns>
        public static int[] RollTen(int numberOfDices = 1)
        {
            if (numberOfDices < 1)
                throw new ArgumentException("Number of dices cannot being lower 1");
            int[] temp = new int[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
                temp[i] = new Random().Next(1, 6);
            return temp;
        }
        #endregion Ten
    }
}
