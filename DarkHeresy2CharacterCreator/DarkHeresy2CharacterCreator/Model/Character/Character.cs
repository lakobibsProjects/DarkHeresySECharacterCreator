using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    class Character : ICharacter
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<ICharacteristic> Characteristics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<AbstractSkill> Skills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<ITalent> Talents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<IItem> Gear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<Aptitudes> Aptitudes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #region Subject of observervation
        public int State { get; set; } = -0;
       
        private List<IAptitudeDependent> observers = new List<IAptitudeDependent>();
        public void Attach(IAptitudeDependent observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IAptitudeDependent observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        #endregion
    }
}
