using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DarkHeresy2CharacterCreator.Model.Character;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    abstract class AbstractSkill : IAptitudeDependent, INotifyPropertyChanged
    {
        #region Fields
        private Skill name;
        private Ranking rank;
        private Aptitudes first;
        private Aptitudes second;
        private int bonus = -20;
        private int cost;
        private readonly int[,] costTable = new int[,] { { 300, 600, 900, 1200 } , { 200, 400, 600, 800 }, { 100, 200, 300, 400 } };
        private string discription;
        #endregion Fields
        #region Properties
        public Skill Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public Ranking Rank
        {
            get { return rank; }
            set { rank = value; OnPropertyChanged("Rank"); }
        }
        public Aptitudes FirstAptitude { get { return first; } protected set { first = value; } }
        public Aptitudes SecondAptitude { get { return second; } protected set { second = value; } }
        public int Cost { get { return cost; } private set { cost = value; OnPropertyChanged("Cost"); } }
        public int SkillBonus
        {
            get { return bonus; }
            private set {
                switch (Rank)
                {
                    case Ranking.Unknown:
                        bonus = -20;
                        break;
                    case Ranking.Known:
                        bonus = 0;
                        break;
                    case Ranking.Trained:
                        bonus = 10;
                        break;
                    case Ranking.Experienced:
                        bonus = 20;
                        break;
                    case Ranking.Veteran:
                        bonus = 30;
                        break;
                }
                OnPropertyChanged("SkillBonus");
            }
        }

        public string Discription { get { return discription; } internal set { discription = value; } }
        #endregion Properties
        protected void ChangeAdvanceCost(IEnumerable<Aptitudes> CharecterAptitudes)
        {
            int haveAptitudes = 0;
            foreach(Aptitudes a in CharecterAptitudes)
                if (a == FirstAptitude || a ==SecondAptitude) haveAptitudes++;
            Cost = costTable[(int)rank - 1, haveAptitudes];
        }

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion

        void IAptitudeDependent.DetermineAdvanceCost(IEnumerable<Aptitudes> CharecterAptitudes)
        {
            throw new NotImplementedException();
        }

        public void Update(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
