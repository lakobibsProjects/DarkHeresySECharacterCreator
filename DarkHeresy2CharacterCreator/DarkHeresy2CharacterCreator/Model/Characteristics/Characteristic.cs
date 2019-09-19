using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    /// <summary>
    /// Comlete characteristic
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Characteristic
    {
        #region Fields
        private CharacteristicName name;
        private AptitudeName first;
        private AptitudeName second;
        private int value;
        private int rank;
        private int cost;
        private readonly int[,] costTable = new int[,] { { 500, 750, 1000, 1500, 2500 }, { 250, 500, 750, 1000, 1500 }, { 100, 250, 500, 750, 1250 } };
        #endregion Fields
        #region Properties
        /// <summary>
        /// Name of characteristic
        /// </summary>
        public CharacteristicName Name { get { return name; } protected set {name = value;} }
        /// <summary>
        /// Aptitude of characteristic
        /// </summary>
        public AptitudeName FirstAptitude { get { return first; } protected set { first = value; } }
        /// <summary>
        /// Aptitude of characteristic
        /// </summary>
        public AptitudeName SecondAptitude { get { return second; } protected set { second = value; } }
        /// <summary>
        /// Cost to advance characteristic
        /// </summary>
        public int Cost { get { return cost; } private set { cost = value; } }
        /// <summary>
        /// Value of characteristic
        /// </summary>
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Rank of characteristics advance
        /// </summary>
        public int Rank
        {
            get { return rank; }
            set
            {
                if (rank > 5 || rank < 0)
                    throw new ArgumentException("Rank cannot bean more than 5 or lower 0");
                rank = value;
            }
        }
        #endregion Properties
        /// <summary>
        /// Create characteristic
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstAptitude"></param>
        /// <param name="secondAptitude"></param>
        /// <param name="rank"></param>
        public Characteristic(CharacteristicName name, AptitudeName firstAptitude, AptitudeName secondAptitude, int rank = 0)
        {
            Name = name;
            FirstAptitude = firstAptitude;
            SecondAptitude = secondAptitude;
            Rank = rank;
        }

        /// <summary>
        /// Determine cost to advance characteristic
        /// </summary>
        /// <param name="charecterAptitudes">Aptitudes of character</param>
        public void ChangeAdvanceCost(IEnumerable<AptitudeName> charecterAptitudes)
        {
            int haveAptitudes = 0;
            foreach (AptitudeName a in charecterAptitudes)
                if (a == FirstAptitude || a == SecondAptitude) haveAptitudes++;
            Cost = costTable[rank - 1, haveAptitudes];
        }
    }
}
