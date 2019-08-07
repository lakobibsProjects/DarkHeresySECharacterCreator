using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace DarkHeresy2CharacterCreator.Model.Talents
{
    class Talent : ITalent
    {
        #region Fields
        private string name;
        private string discription;
        private SourceList sourceBook;
        private int sourcePage;
        private int tier;
        private Aptitudes first;
        private Aptitudes second;
        private int cost;
        private string[] prerequisites;
        private ObservableCollection<string> specializations;
        private readonly int[,] costTable = { { 600, 900, 1200}, { 300, 450, 600 }, { 200, 300, 400 } };
        #endregion Fields
        #region Properties
        public string Name { get { return name; } set { name = value; } }
        public string Discription { get { return discription; } set { discription = value; } }

        public Aptitudes FirstAptitude { get { return first; } protected set { first = value; } }
        public Aptitudes SecondAptitude { get { return second; } protected set { second = value; } }
        public int Cost { get { return cost; } private set { cost = value; OnPropertyChanged("Cost"); } }

        public int Tier { get { return tier; } protected set { tier = value; } }

        public SourceList SourceBook { get { return sourceBook; } protected set { sourceBook = value; } }

        public int SourcePage { get { return sourcePage; } protected set { sourcePage = value; } }

        public string[] Prerequisites { get { return prerequisites; } protected set { prerequisites = value; } }

        public ObservableCollection<string> Specializations { get { return specializations; } set { specializations = value; OnPropertyChanged("Specializations"); } }
        #endregion Properties
        #region Consturctors
        public Talent(string Name, string Discription, Aptitudes FirstAptitude, Aptitudes SecondAptitude, int Tier)
        {
            this.Name = Name;
            this.Discription = Discription;
            this.FirstAptitude = FirstAptitude;
            this.SecondAptitude = SecondAptitude;
            this.Tier = Tier;
            Cost = costTable[0, 0];
            SourceBook = SourceList.Core_Rulebook_2_edition;
            SourcePage = 119;
        }
        public Talent(string Name, string Discription, Aptitudes FirstAptitude, Aptitudes SecondAptitude, int Tier, SourceList SourceBook, int SourcePage)
            : this(Name, Discription, FirstAptitude, SecondAptitude, Tier)
        {
            this.SourceBook = SourceBook;
            this.SourcePage = SourcePage;
        }
        #endregion Constructors

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion

        public void ChangeAdvanceCost(IEnumerable<Aptitudes> CharecterAptitudes)
        {
            int haveAptitudes = 0;
            foreach (Aptitudes a in CharecterAptitudes)
                if (a == FirstAptitude || a == SecondAptitude) haveAptitudes++;
            Cost = costTable[haveAptitudes, tier - 1];
        }
    }
}
