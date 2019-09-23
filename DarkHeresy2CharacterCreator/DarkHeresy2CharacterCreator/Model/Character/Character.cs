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
using NUnit.Framework.Internal;
using PropertyChanged;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    /// <summary>
    /// Complete character
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Character : ICharacter
    {
        #region Fields
        private string characterName;
        private HomeWorld homeworld;
        private Background background;
        private Role role;
        private int divination;
        private string playerName;
        private string gender;
        private int age;
        private string build;
        private string complexion;
        private string hair;
        private string quirks;
        private string superstitions;
        private string mementos;
        private int totalExpirience;
        private int spendExpirience;
        private int fateTreshold;
        private int currentFate;
        private string mentalDisorders;
        private string malignacies;
        private string mutations;
        private int[] movements;
        private int fatiqueTreshold;
        private int currentFatique;
        private int totalWounds;
        private int currentWounds;
        private int criticalDamage;
        private int maxCarry;
        private int currentCarry;
        private int insanity;
        private int corruption;

        #region CollectionFields
        private ObservableCollection<IEliteAdvance> eliteAdvances;
        private ObservableCollection<string> allies;
        private ObservableCollection<string> enemies;
        private ObservableCollection<ITrait> traits = new ObservableCollection<ITrait>();
        private ObservableCollection<IPsychicPower> psychicPowers = new ObservableCollection<IPsychicPower>();
        private ObservableCollection<string> conditions = new ObservableCollection<string>();
        private ObservableCollection<Characteristic> characteristics = new ObservableCollection<Characteristic>();
        private ObservableCollection<AbstractSkill> skills = new ObservableCollection<AbstractSkill>();
        private ObservableCollection<ITalent> talents = new ObservableCollection<ITalent>();
        private ObservableCollection<IItem> gear = new ObservableCollection<IItem>();
        private ObservableCollection<AptitudeName> aptitudes = new ObservableCollection<AptitudeName>();
        #endregion CollectionFields
        #endregion Fields

        #region Properties
        public string CharacterName { get => characterName; set => characterName = value; }
        public HomeWorld HomeWorld { get => homeworld; set => homeworld = value; }
        public Background Background { get => background; set => background = value; }
        public Role Role { get => role; set => role = value; }
        public int Divination { get => divination; set => divination = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Build { get => build; set => build = value; }
        public string Complexion { get => complexion; set => complexion = value; }
        public string Hair { get => hair; set => hair = value; }
        public string Quirks { get => quirks; set => quirks = value; }
        public string Superstitions { get => superstitions; set => superstitions = value; }
        public string Mementos { get => mementos; set => mementos = value; }
        public int TotalExpirience { get => totalExpirience; set => totalExpirience = value; }
        public int SpendExpirience { get => spendExpirience; set => spendExpirience = value; }
        public int FateTreshold { get => fateTreshold; set => fateTreshold = value; }
        public int CurrentFate { get => currentFate; set => currentFate = value; }
        public string MentalDisorders { get => mentalDisorders; set => mentalDisorders = value; }
        public string Malignacies { get => malignacies; set => malignacies = value; }
        public string Mutations { get => mutations; set => mutations = value; }        
        public int[] Movements { get => movements; set => movements = value; }
        public int FatiqueTreshold => fatiqueTreshold;
        public int CurrentFatique { get => currentFatique; set => currentFatique = value; }
        public int TotalWounds { get => totalWounds; set => totalWounds = value; }
        public int CurrentWounds { get => currentWounds; set => currentWounds = value; }
        public int CriticalDamage { get => criticalDamage; set => criticalDamage = value; }        
        public int MaxCarry { get => maxCarry; set => maxCarry = value; }
        public int CurrentCarry { get => currentCarry; set =>  currentCarry= value; }
        public int Insanity { get => insanity; set => insanity = value; }
        public int Corruption { get => corruption; set => corruption = value; }


        #region CollectionProperties
        public ObservableCollection<IEliteAdvance> EliteAdvances { get => eliteAdvances; set => eliteAdvances = value; }
        public ObservableCollection<string> Allies { get => allies; set => allies = value; }
        public ObservableCollection<string> Enemies { get => enemies; set => enemies = value; }
        public ObservableCollection<ITrait> Traits { get => traits; set =>  traits= value; }
        public ObservableCollection<IPsychicPower> PsychicPowers { get => psychicPowers; set => psychicPowers = value; }
        public ObservableCollection<string> Conditions { get => conditions; set => conditions = value; }
        public ObservableCollection<Characteristic> Characteristics { get => characteristics; set => characteristics = value; }
        public ObservableCollection<AbstractSkill> Skills { get => skills; set => skills = value; }
        public ObservableCollection<ITalent> Talents { get => talents; set => talents = value; }
        public ObservableCollection<IItem> Gear { get => gear; set =>  gear = value; }
        public ObservableCollection<AptitudeName> Aptitudes { get => aptitudes; set => aptitudes = value; }
        #endregion CollectionProperties
        #endregion Properties

        public Character()
        {
            foreach (var c in CharacteristicList.Characteristics)            
                characteristics.Add(c);
            
            
        }
        
        //think about remove (was created extensions with this methods)
        #region Add and remove general suppliments
        public void AptitudesChanged()
        {
            foreach (var item in Characteristics)
                if (item != null) item.ChangeAdvanceCost(Aptitudes);
            foreach (var item in Skills)
                if (item != null) (item as IAptitudeDependent).ChangeAdvanceCost(Aptitudes);
            foreach (var item in Talents)
                if(item != null) item.ChangeAdvanceCost(Aptitudes);
        }

        public void AddHomeworld(HomeWorld homeworld)
        {
            try
            {
                this.HomeWorld = homeworld;
                this.FateTreshold = homeworld.FateTreshold;
                this.TotalWounds = homeworld.Wounds;
                this.Aptitudes.Add(homeworld.HomeWorldAptitude);
                AptitudesChanged();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public void RemoveHomeworld()
        {
            if(this.HomeWorld != null)
            {
                this.Aptitudes.Remove(HomeWorld.HomeWorldAptitude);
                this.HomeWorld = null;
                this.FateTreshold = 0;
                this.TotalWounds = 0;
                AptitudesChanged();
            }
        }

        public void AddBackround(Background background)
        {
            this.Background = background;

            foreach (var b in background.BackgroundSkills)            
                Skills.Add(b.Item1);
            
            foreach (var t in background.BackgroundsTalents)            
                Talents.Add(t.Item1);            

            foreach (var item in background.BackgroundEquipment)            
                Gear.Add(item.Item1);            

            this.Aptitudes.Add(background.BackgroundAptitude.Item1);
            AptitudesChanged();

            if (background.Trait != null)
                this.Traits.Add(background.Trait);
        }
        public void RemoveBackround()
        {
            if (background != null)
            {
                foreach (var b in background.BackgroundSkills)
                    Skills.Remove(b.Item1);

                foreach (var t in background.BackgroundsTalents)
                    Talents.Remove(t.Item1);

                foreach (var item in background.BackgroundEquipment)
                    Gear.Remove(item.Item1);

                this.Aptitudes.Remove(background.BackgroundAptitude.Item1);
                AptitudesChanged();

                if (background.Trait != null)
                    this.Traits.Remove(background.Trait);

                this.Background = null;
            }
        }

        public void AddRole(Role role)
        {
            this.Role = role;

            foreach (var a in role.Aptitudes)
            {
                this.Aptitudes.Add(a.Item1);
                AptitudesChanged();
            }            

            this.Talents.Add(role.RoleTalent.Item1);
        }

        public void RemoveRole()
        {
            foreach (var a in role.Aptitudes)
            {
                this.Aptitudes.Remove(a.Item1);
                AptitudesChanged();
            }

            this.Talents.Remove(role.RoleTalent.Item1);

            this.Role = null;
        }

        #endregion
    }
}
