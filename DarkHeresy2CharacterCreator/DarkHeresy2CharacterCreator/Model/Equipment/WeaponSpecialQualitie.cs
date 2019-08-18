using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{
    public class WeaponSpecialQualitie
    {
        #region Fields
        string name;
        bool hasNumeric = false;
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
        public WeaponSpecialQualitie(string name, string discription)
        {
            Name = name;
            Discription = discription;
            Numeric = null;
        }
        public WeaponSpecialQualitie(string name, string discription, bool hasNumeric) : this(name, discription)
        {
            HasNumeric = hasNumeric;
        }
        #endregion Constructors
    }
}
