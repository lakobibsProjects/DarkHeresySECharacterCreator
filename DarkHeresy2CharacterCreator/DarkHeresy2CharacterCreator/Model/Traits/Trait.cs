using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Traits
{
    internal class Trait : ITrait
    {
        #region Fields
        private string name;
        private string discription;
        private int modifire;
        private bool hasModifire;
        #endregion Fields
        
        #region Properties
        public string Name { get => name; set => name = value; }
        public string Discription { get => discription; set => discription = value; }
        public int Modifier { get => modifire; set => modifire = value; }
        public bool HasModifire { get => hasModifire; set => hasModifire = value; }
        #endregion Properties

        public Trait(string name, string discription, bool hasModifire)
        {
            Name = name;
            Discription = discription;
            HasModifire = hasModifire;
        }
        //require add mechanism to operate with modifire
        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string pror = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pror));
        }
        #endregion
    }
}
