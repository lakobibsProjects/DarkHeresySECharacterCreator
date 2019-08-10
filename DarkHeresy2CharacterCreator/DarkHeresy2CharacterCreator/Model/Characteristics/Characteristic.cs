using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    class Characteristic : ICharacteristic
    {
        private CharacteristicName name;
        private AptitudeName first;
        private AptitudeName second;
        private int rank;
        private int cost;
        private readonly int[,] costTable = new int[,] { { 500, 750, 1000, 1500, 2500 }, { 250, 500, 750, 1000, 1500 }, { 100, 250, 500, 750, 1250 } };
        public CharacteristicName Name { get { return name; } protected set {name = value;} }

        public AptitudeName FirstAptitude { get { return first; } protected set { first = value; } }
        public AptitudeName SecondAptitude { get { return second; } protected set { second = value; } }
        public int Cost { get { return cost; } private set { cost = value; OnPropertyChanged("Cost"); } }
        public int Rank
        {
            get { return rank; }
            set
            {
                if (rank > 5 || rank < 0)
                    throw new ArgumentException("Rank cannot bean more than 5 or lower 0");
                rank = value;
                OnPropertyChanged("CharacteristicRank");
            }
        }

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion

        public void ChangeAdvanceCost(IEnumerable<AptitudeName> charecterAptitudes)
        {
            int haveAptitudes = 0;
            foreach (AptitudeName a in charecterAptitudes)
                if (a == FirstAptitude || a == SecondAptitude) haveAptitudes++;
            Cost = costTable[rank - 1, haveAptitudes];
        }
    }
}
