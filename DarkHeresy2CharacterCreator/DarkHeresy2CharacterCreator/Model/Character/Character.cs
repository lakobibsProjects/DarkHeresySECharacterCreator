using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.PsychicPowers;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.Model.Talents;
using DarkHeresy2CharacterCreator.Model.Traits;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    class Character : ICharacter
    {
        public string CharacterName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public HomeWorld HomeWorld { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Background Background { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Role Role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Divinations Divination { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PlayerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Build { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Complexion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Hair { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Quirks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Superstitions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Mementos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalExpirience { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SpendExpirience { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FateTreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentFate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MentalDisorders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Malignacies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Mutations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }        
        public int[] Movements { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FatiqueTreshold => throw new NotImplementedException();
        public int CurrentFatique { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalWounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentWounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CriticalDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }        
        public int MaxCarry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentCarry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }




        public ObservableCollection<IEliteAdvance> EliteAdvances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<string> Allies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<string> Enemies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<ITrait> Traits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<IPsychicPower> PsychicPowers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<string> Conditions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<ICharacteristic> Characteristics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<AbstractSkill> Skills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<ITalent> Talents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<IItem> Gear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<Aptitudes> Aptitudes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
