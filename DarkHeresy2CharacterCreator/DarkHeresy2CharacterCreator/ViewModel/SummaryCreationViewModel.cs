using DarkHeresy2CharacterCreator.Model;
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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class SummaryCreationViewModel
    {
        #region Fields
        private ICharacter createdcharacter;
        private Divinations divination;
        private RelayCommand setDivinationCommand;
        private RelayCommand setCharateristic;
        private RelayCommand setWounds;
        private RelayCommand setFateTreshhold;
        private RelayCommand changeHomeworldCommand;
        private RelayCommand changeBackgroundCommand;
        private RelayCommand changeRoleCommand;
        private RelayCommand exitCommand;
        private RelayCommand saveAndExitCommand;
        private RelayCommand openAddAvailableAptitudeWindowCommand;
        private RelayCommand addAptitudeCommand;
        private RelayCommand refreshCommand;
        private ICollectionView skills;
        private ICollectionView aptitudes;
        private ICollectionView availableAptitudes;
        private ICollectionView gear;
        private ICollectionView talentsAndTraits;
        private ICollectionView specialAbilities;

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
        public ICharacter CreatedCharacter
        {
            get { return createdcharacter; }
            set { createdcharacter = value; }
        }        
        #region Commands
        public ICommand SetDivinationCommand => setDivinationCommand;
        public ICommand SetCharateristic => setCharateristic;
        public ICommand SetWounds => setWounds;
        public ICommand SetFateTreshhold => setFateTreshhold;
        public ICommand ChangeHomeworldCommand => changeHomeworldCommand;
        public ICommand ChangeBackgroundCommand => changeBackgroundCommand;
        public ICommand ChangeRoleCommand => changeRoleCommand;
        public ICommand ExitCommand => exitCommand;
        public ICommand SaveAndExitCommand => saveAndExitCommand;
        public ICommand OpenAddAvailableAptitudeWindowCommand => openAddAvailableAptitudeWindowCommand;
        public ICommand AddAptitudeCommand => addAptitudeCommand;
        public ICommand RefreshCommand => refreshCommand;
        #endregion Commands

        #region Array-like properties
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

        public ICollectionView TalentsAndTraits { get { return talentsAndTraits; } }
        public ICollectionView Gear { get { return gear; } }

        public ICollectionView SpecialAbilities { get { return specialAbilities; } }
        

        public ICollectionView Skills { get { return skills; }  }
        #endregion Array-like properties
        #region Aptitudes bind properties
        public ICollectionView Aptitudes { get { return aptitudes; } }
        public ICollectionView AvailableAptitudes { get { return availableAptitudes; } }
        public int NotEnoughAptitude => Aptitudes == null ? 7 : 7 - 0;
        public bool AptitudesIsComplete => !(NotEnoughAptitude == 0);
        public string SelectedAvailableAptitude { get; set; }
        #endregion Aptitudes bind properties
        #endregion Properties

        #region Constructor
        public SummaryCreationViewModel()
        {
            CreatedCharacter = MainWindowVM.OpenedCharacter;
            //TalentsAndTraits = new ObservableCollection<string>();
            //Gear = new ObservableCollection<string>();           
            //Aptitudes = new ObservableCollection<string>();
            //SpecialAbilities = new ObservableCollection<string>();
            //AvailableAptitudes = new ObservableCollection<string>();

            skills = CollectionViewSource.GetDefaultView(CreatedCharacter.Skills);
            skills.Filter = skillsFilter;
            aptitudes = CollectionViewSource.GetDefaultView(CreatedCharacter.Aptitudes);
            availableAptitudes = CollectionViewSource.GetDefaultView((AptitudeName[])Enum.GetValues(typeof(AptitudeName)));
            availableAptitudes.Filter = availableAptitudesFilter;
            gear = CollectionViewSource.GetDefaultView(CreatedCharacter.Gear);
            talentsAndTraits = CollectionViewSource.GetDefaultView(new ObservableCollection<string>().
                Concat(CreatedCharacter.Talents.Select(t => t == null ? string.Empty : t.Discription)).
                Concat(CreatedCharacter.Traits.Select(t => t == null ? string.Empty : t.Discription)));

            #region Initialization commands
            setDivinationCommand = new RelayCommand(SetDivination);
            setCharateristic = new RelayCommand(RollCharacteristic);           
            setWounds = new RelayCommand(RollWounds);
            setFateTreshhold = new RelayCommand(RollEmperorsBlessing);
            changeHomeworldCommand = new RelayCommand(obj => CreatedCharacter.HomeWorld = null); 
            changeBackgroundCommand = new RelayCommand(obj => CreatedCharacter.Background = null);
            changeRoleCommand = new RelayCommand(obj => CreatedCharacter.Role = null);
            exitCommand = new RelayCommand(OnExit);
            saveAndExitCommand = new RelayCommand(OnSaveAndAxit);
            openAddAvailableAptitudeWindowCommand = new RelayCommand(OpenAddAvailableAptitudeWindow);
            addAptitudeCommand = new RelayCommand(AddAvailableAptitude);
            refreshCommand = new RelayCommand(Refresh);
            #endregion
            
        }

        private bool skillsFilter(object item)
        {
            AbstractSkill skill = item as AbstractSkill;
            return skill.Rank != Ranking.Unknown;
        }

        private bool availableAptitudesFilter(object item)
        {
            string aptitude = item as string;
            return !Aptitudes.Contains(aptitude);
        }

        private void Refresh(object obj)
        {

            //TalentsAndTraits.Clear();
            //Gear.Clear();           
            //Aptitudes.Clear();
            //SpecialAbilities.Clear();
            //AvailableAptitudes.Clear();
            Role role = obj as Role;
            skills.Refresh();
            aptitudes.Refresh();      
            availableAptitudes.Refresh();
            gear.Refresh();
            talentsAndTraits.Refresh();
            /*if (specialAbilities == null)
            {
                specialAbilities = CollectionViewSource.GetDefaultView(new ObservableCollection<string>()
                {
                    CreatedCharacter.Background.BackgroundBonuds,
                    CreatedCharacter.HomeWorld.HomeWorldBonus,
                    role.RoleBonus
                });
            }
            if(specialAbilities != null) specialAbilities.Refresh(); */
            
            /*foreach (var t in CreatedCharacter.Talents)
            {
                if (t != null && t.Discription != null)
                    TalentsAndTraits.Add(t.Discription);
            }
            foreach (var t in CreatedCharacter.Traits)
                TalentsAndTraits.Add(t.Discription);*/


            /*foreach (var g in CreatedCharacter.Gear)    //correct gearList and backgroungGearList (switch to enum)
            {
                if (g != null)
                    Gear.Add(g.Name);
            }*/


            /*var specialAbilities = new ObservableCollection<string>();
*/

            
           /* foreach (var item in notDuplicateAptitudes)
                Aptitudes.Add(item.ToString());*/
            
            //Aptitudes =  (ObservableCollection<string>)(aptitudes.GroupBy(x => x).Select(y => y.FirstOrDefault()));     // cast exception

           /* foreach (var apt in (AptitudeName[])Enum.GetValues(typeof(AptitudeName)))
            {
                foreach(var a in Aptitudes)
                {
                    if (AvailableAptitudes.Contains(a)) 
                        break;
                    
                    if (apt.ToString() != a && !AvailableAptitudes.Contains(a))
                        AvailableAptitudes.Add(apt.ToString());
                }
            }*/
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
        private void OnSaveAndAxit(object obj)
        {
            Window window = obj as Window;
            window.Close();
        }

        private void OnExit(object obj)
        {
            CharactersList.Characters.Remove(MainWindowVM.OpenedCharacter);
            Window window = obj as Window;
            window.Close();
        }
        private void OpenAddAvailableAptitudeWindow(object obj)
        {
            Window addAptitudeWindow = new View.AddAptitudeWindow();
            addAptitudeWindow.Show();
        }
        private void AddAvailableAptitude(object obj)
        {
            if(SelectedAvailableAptitude != null)
            {
                foreach (var apt in (AptitudeName[])Enum.GetValues(typeof(AptitudeName)))
                {
                    if (apt.ToString() == SelectedAvailableAptitude)                    
                        CreatedCharacter.Aptitudes.Add(apt);                    
                }
                Window window = obj as Window;
                window.Close();
            }
        }
        #endregion Helped Methods

    }
  
}
