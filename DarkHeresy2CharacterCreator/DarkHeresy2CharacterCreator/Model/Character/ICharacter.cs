using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.PsychicPowers;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using DarkHeresy2CharacterCreator.Model.Traits;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    /// <summary>
    /// Interface with general fuctionality of character
    /// </summary>
    public interface ICharacter
    {
        string CharacterName { get; set; }
        HomeWorld HomeWorld { get; set; }
        Background Background { get; set; }
        Role Role { get; set; }
        int Divination { get; set; }
        ObservableCollection<IEliteAdvance> EliteAdvances { get; set; }
        string PlayerName { get; set; }
        string Gender { get; set; }
        int Age { get; set; }
        string Build { get; set; }
        string Complexion { get; set; }
        string Hair { get; set; }
        string Quirks { get; set; }
        string Superstitions { get; set; }
        string Mementos { get; set; }
        ObservableCollection<string> Allies { get; set; }
        ObservableCollection<string> Enemies { get; set; }
        int TotalExpirience { get; set; }
        int SpendExpirience { get; set; }
        int FateTreshold { get; set; }
        int CurrentFate { get; set; }
        string MentalDisorders { get; set; }
        string Malignacies { get; set; }
        string Mutations { get; set; }
        ObservableCollection<ITrait> Traits { get; set; }
        int[] Movements { get; set; }
        int FatiqueTreshold { get; }
        int CurrentFatique { get; set; }
        int TotalWounds { get; set; }
        int CurrentWounds { get; set; }
        int CriticalDamage { get; set; }
        ObservableCollection<string> Conditions { get; set; }
        int MaxCarry { get; set; }
        int CurrentCarry { get; set; }
        int Insanity { get; set; }
        int Corruption { get; set; } 

        ObservableCollection<IPsychicPower> PsychicPowers { get; set; }
        ObservableCollection<Characteristic> Characteristics { get; set; }
        ObservableCollection<AbstractSkill> Skills { get; set; }
        ObservableCollection<ITalent> Talents { get; set; }
        ObservableCollection<IItem> Gear { get; set; }
        ObservableCollection<AptitudeName> Aptitudes { get; set; }
        ObservableCollection<Tuple<string, string, int>> Advances { get; set; }
        int NotSpendExp { get; }

        void AddAdvance(string name, string type, int cost);
        void AddBackround(Background background);
        void AddHomeworld(HomeWorld homeworld);
        void AddRole(Role role);
        void RemoveAdvance(string name, string type, int cost);
        void RemoveBackround();
        void RemoveHomeworld();
        void RemoveRole();
    }
}
