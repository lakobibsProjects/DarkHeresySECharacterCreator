using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.DiceRoller;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.Skills;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    /// <summary>
    /// ViewModel for SummaryCreationWindow
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class SummaryCreationViewModel
    {
        #region Fields
        private Character createdcharacter;
        private Divinations divination;
        private DelegateCommand setDivinationCommand;
        private DelegateCommand setCharateristic;
        private DelegateCommand getAptitudes;
        private DelegateCommand setWounds;
        private DelegateCommand setFateTreshhold;
        private DelegateCommand exitCommand;
        private DelegateCommand saveAndExitCommand;
        private Characteristic weaponSkill = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Weapon_Skill).FirstOrDefault();
        private Characteristic ballisticSkill = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Balistic_Skill).FirstOrDefault();
        private Characteristic strength = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Strength).FirstOrDefault();
        private Characteristic toughness = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Toughness).FirstOrDefault();
        private Characteristic intelligence = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Intelligence).FirstOrDefault();
        private Characteristic perception = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Perception).FirstOrDefault();
        private Characteristic influence = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Influence).FirstOrDefault();
        private Characteristic agility = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Agility).FirstOrDefault();
        private Characteristic willpower = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Willpower).FirstOrDefault();
        private Characteristic fellowship = CharacteristicList.Characteristics.Where(c => c.Name == CharacteristicName.Fellowship).FirstOrDefault();
        #endregion Fields

        #region Properties
        public Divinations Divination
        {
            get { return divination; }
            set { divination = value; }
        }


        public Character CreatedCharacter
        {
            get { return createdcharacter; }
            set { createdcharacter = value; }
        }
        public ICommand SetDivinationCommand => setDivinationCommand;
        public ICommand SetCharateristic => setCharateristic;
        public ICommand GetAptitudes => getAptitudes;
        public ICommand SetWounds => setWounds;
        public ICommand SetFateTreshhold => setFateTreshhold;

        public ICommand ExitCommand => exitCommand;
        public ICommand SaveAndExitCommand => saveAndExitCommand;
        public Characteristic WeaponSkill { get => weaponSkill; set => weaponSkill = value; }
        public Characteristic BallisticSkill { get => ballisticSkill; set => ballisticSkill = value; }
        public Characteristic Strength { get => strength; set => strength = value; }
        public Characteristic Toughness { get => toughness; set => toughness = value; }
        public Characteristic Intelligence { get => intelligence; set => intelligence = value; }
        public Characteristic Perception { get => perception; set => perception = value; }
        public Characteristic Influence { get => influence; set => influence = value; }
        public Characteristic Agility { get => agility; set => agility = value; }
        public Characteristic Willpower { get => willpower; set => willpower = value; }
        public Characteristic Fellowship { get => fellowship; set => fellowship = value; }
        public List<string> Aptitudes
        {
            get
            {
                var result = new List<string>();
                foreach (var a in CreatedCharacter.Aptitudes)
                    result.Add(a.ToString());
                return result;
            }
        }
        public List<string> TalentsAndTraits
        {
            get
            {
                var result = new List<string>();
                foreach (var t in CreatedCharacter.Talents)
                {
                    if(t != null && t.Discription != null)
                        result.Add(t.Discription);
                }
                foreach (var t in CreatedCharacter.Traits)
                    result.Add(t.Discription);
                return result;
            }
        }
        public List<string> Gear
        {
            get
            {
                var result = new List<string>();
                foreach (var g in CreatedCharacter.Gear)    //correct gearList and backgroungGearList (switch to enum)
                {
                    if (g != null)                    
                        result.Add(g.Name);
                }
                return result;
            }
        }

        public ObservableCollection<string> SpecialAbilities
        {
            get
            {
                var result = new ObservableCollection<string>();
                result.Add(CreatedCharacter.HomeWorld.HomeWorldBonus);         
                result.Add(CreatedCharacter.Role.RoleBonus);                   
                result.Add(CreatedCharacter.Background.BackgroundBonuds);     
                return result;
            }
        }
        public ObservableCollection<DGSkill> Skills
        {
            get
            {
                var result = new ObservableCollection<DGSkill>();
                foreach (var s in CreatedCharacter.Skills)
                {                    
                    if (s != null && s.Rank > 0)
                        result.Add(new DGSkill (s));
                }
                return result;
            }
        }
        #endregion Properties

        #region Constructor
        public SummaryCreationViewModel()
        {
            CreatedCharacter = MainWindowVM.OpenedCharacter;
            setDivinationCommand = new DelegateCommand(SetDivination);
            setCharateristic = new DelegateCommand(RollCharacteristic);
            setWounds = new DelegateCommand(RollWounds);
            setFateTreshhold = new DelegateCommand(RollEmperorsBlessing);
            exitCommand = new DelegateCommand(OnExit);
            saveAndExitCommand = new DelegateCommand(OnSaveAndExit);
        }

        #endregion Constructor

        #region Helped Methods
        private void SetDivination(object obj)
        {
            CreatedCharacter.Divination = DiceRoller.Roll();
            Divination = new Divinations(CreatedCharacter.Divination);
        }

        private void RollWounds(object wounds)
        {
            CreatedCharacter.TotalWounds = CreatedCharacter.HomeWorld.Wounds + DiceRoller.RollFive();
        }

        private void RollEmperorsBlessing(object obj)
        {
            CreatedCharacter.FateTreshold = DiceRoller.RollTen() > CreatedCharacter.HomeWorld.EmperorsBlessing ?
                CreatedCharacter.HomeWorld.FateTreshold + 1 : CreatedCharacter.HomeWorld.FateTreshold;
        }
        private void RollCharacteristic(object characteristic)
        {
            var c = characteristic as Characteristic;
            c.Value = 20 + DiceRoller.RollTen() + DiceRoller.RollTen();
            foreach (var cc in CreatedCharacter.Characteristics)
            {
                if (cc.Name.ToString() == c.Name.ToString())
                    cc.Value = c.Value;
            }
        }
        private void OnExit(object obj)
        {
            try
            {
                if (CreatedCharacter != null && CharactersList.Characters.Contains(CreatedCharacter))
                {
                    CharactersList.Characters.Remove(CreatedCharacter);
                    CharactersList.CharactersIO.SaveData(CharactersList.Characters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
            Window window = obj as Window;
            window.Close();
        }
        private void OnSaveAndExit(object obj)
        {
            try
            {
                if (CreatedCharacter != null)
                {
                    CharactersList.CharactersIO.SaveData(CharactersList.Characters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
            Window window = obj as Window;
            window.Close();
        }
        #endregion Helped Methods

    }

    //remove and change to simple binding to collection of skills that contains in exemplar of character
    /// <summary>
    /// Asistance class to correctable information in skills DataGrid
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class DGSkill
    {
        public string Name { get; set; }
        public bool IsKnow { get; set; } = false;
        public bool IsTrained { get; set; } = false;
        public bool IsExperienced { get; set; } = false;
        public bool IsVeteran { get; set; } = false;

        public DGSkill(AbstractSkill basicSkill)
        {
            Name = basicSkill.Name.ToString();
            if (basicSkill.Rank > Ranking.Unknown)
                IsKnow = true;
            if (basicSkill.Rank > Ranking.Known)
                IsTrained = true;
            if (basicSkill.Rank > Ranking.Trained)
                IsExperienced = true;
            if (basicSkill.Rank > Ranking.Experienced)
                IsVeteran = true;
        }
        /// <summary>
        /// Asistance class to correctable information in skills DataGrid
        /// </summary>
        [AddINotifyPropertyChangedInterface]
        public class DGSpecialAbilities
        {
            string[] SpecialAbilites { get; set; } = new string[3];
            public DGSpecialAbilities(ICharacter character)
            {
                SpecialAbilites[0] = character.HomeWorld.HomeWorldBonus;
                SpecialAbilites[1] = character.Role.RoleBonus;
                SpecialAbilites[2] = character.Background.BackgroundBonuds;
            } 
        }
    }
}
