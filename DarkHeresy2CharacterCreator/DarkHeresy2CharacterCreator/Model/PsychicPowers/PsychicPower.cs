using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace DarkHeresy2CharacterCreator.Model.PsychicPowers
{
    public class PsychicPower : IPsychicPower
    {
        #region Fields
        private string name;
        private int cost;
        private object[] prerequisites;
        private ActionLong action;
        private ActionLong toSustained;
        private Tuple<int, Characteristics.CharacteristicName> focusPower;
        private Tuple<int, string> range;
        private string subtype;
        private string effect;
        private PsychisSchools school;

        #endregion Fields

        #region Properties;
        public string Name { get { return name; } protected set { name = value; } }

        public int Cost { get { return cost; } protected set { cost = value; } }
        public object[] Prerequisites { get { return prerequisites; } protected set { prerequisites = value; } }

        public ActionLong Action { get { return action; } protected set { action = value; } }

        public Tuple<int, Characteristics.CharacteristicName> FocusPower { get { return focusPower; } protected set { focusPower = value; } }

        public Tuple<int, string> Range { get { return range; } protected set { range = value; } }

        public ActionLong Sustained { get { return toSustained; } protected set { toSustained = value; } }

        public string Subtype { get { return subtype; } protected set { subtype = value; } }

        public string Effect { get { return effect; } protected set { effect = value; } }

        public PsychisSchools School { get { return school; } protected set { school = value; } }
        #endregion Properties

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }

        #endregion
    }
}
