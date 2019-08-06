using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    interface ICharacter
    {
        string Name { get; set; }
        ObservableCollection<ICharacteristic> Characteristics { get; set; }
        ObservableCollection<AbstractSkill> Skills { get; set; }
        ObservableCollection<ITalent> Talents { get; set; }
        ObservableCollection<IItem> Gear { get; set; }
        ObservableCollection<Aptitudes> Aptitudes { get; set; }

        #region Observer
        // Присоединяет наблюдателя к издателю.
        void Attach(IAptitudeDependent observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(IAptitudeDependent observer);

        // Уведомляет всех наблюдателей о событии.
        void Notify();
        #endregion
    }
}
