using System;
using System.Collections.Generic;
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
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Discription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Pair Source => throw new NotImplementedException();

        public Aptitudes FirstAptitude => throw new NotImplementedException();

        public Aptitudes SecondAptitude => throw new NotImplementedException();

        public int Cost => throw new NotImplementedException();

        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion

        public void ChangeAdvanceCost(IEnumerable<Aptitudes> CharecterAptitudes)
        {
            throw new NotImplementedException();
        }
    }
}
