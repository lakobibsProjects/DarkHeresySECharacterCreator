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
        ObservableCollection<ISkill> Skills { get; set; }
        ObservableCollection<ITalent> Talents { get; set; }
        ObservableCollection<IItem> Gear { get; set; }
    }
}
