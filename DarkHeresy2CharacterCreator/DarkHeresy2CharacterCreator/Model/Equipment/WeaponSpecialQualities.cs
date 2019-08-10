using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{
    class WeaponSpecialQualities
    {
        #region Fields
        string name;
        bool hasNumeric;
        int? numeric;
        string discription;
        #endregion Fields
        #region Properties
        public string Name { get => name; set => name = value; }
        public bool HasNumeric { get => hasNumeric; protected set => hasNumeric = value; }
        public int? Numeric { get => numeric; set => numeric = value; }
        public string Discription { get => discription; set => discription = value; }
        #endregion Properties
        #region Constructors
        public WeaponSpecialQualities(string name, string discription)
        {
            Name = name;
            Discription = discription;
            HasNumeric = false;
            Numeric = null;
        }
        public WeaponSpecialQualities(string name, string discription, int numeric) : this(name, discription)
        {
            HasNumeric = true;
            Numeric = numeric;
        }
        #endregion Constructors
    }
}
