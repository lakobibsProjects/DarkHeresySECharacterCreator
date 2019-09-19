using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Characteristics
{
    /// <summary>
    /// Instaniate a observableCollection of characteristic
    /// </summary>
    internal static class CharacteristicList
    {
        /// <summary>
        /// Collection of all charateristic
        /// </summary>
        internal static ObservableCollection<Characteristic> Characteristics { get; } = new ObservableCollection<Characteristic>
        {
            new Characteristic(CharacteristicName.Agility, AptitudeName.Agility , AptitudeName.Finesse),
            new Characteristic(CharacteristicName.Balistic_Skill, AptitudeName.Balistic_Skill , AptitudeName.Finesse),
            new Characteristic(CharacteristicName.Fellowship, AptitudeName.Fellowship, AptitudeName.Social),
            new Characteristic(CharacteristicName.Intelligence, AptitudeName.Intelligence, AptitudeName.Knowledge),
            new Characteristic(CharacteristicName.Perception, AptitudeName.Perception, AptitudeName.Fieldcraft),
            new Characteristic(CharacteristicName.Strength, AptitudeName.Strength, AptitudeName.Offence),
            new Characteristic(CharacteristicName.Toughness, AptitudeName.Toughness, AptitudeName.Defence),
            new Characteristic(CharacteristicName.Weapon_Skill, AptitudeName.Weapon_Skill, AptitudeName.Offence),
            new Characteristic(CharacteristicName.Willpower , AptitudeName.Willpower , AptitudeName.Psyker),
            new Characteristic(CharacteristicName.Influence, AptitudeName.None, AptitudeName.None)
        };

    }
}
