using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.CharacterSheet
{
    [AddINotifyPropertyChangedInterface]
    public class CharacterSheetVM
    {
        #region Fields
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
        private DelegateCommand upCharateristic;
        private ArithmeticCommand increace;        
        private ArithmeticCommand decreace;
        private ArithmeticCommand increaceExp;
        private ArithmeticCommand decreaceExp;

        #endregion Fields

        #region Properties
        public ICharacter Character { get; set; }
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
        public ICommand UpCharateristic => upCharateristic;
        public ICommand Increace => increace;
        public ICommand Decreace => decreace;
        public ICommand IncreaceExp => increaceExp;
        public ICommand DecreaceExp => decreaceExp;
        #endregion

        #region Constructor
        public CharacterSheetVM()
        {
            Character = MainWindowVM.SelectedCharacter;
            upCharateristic = new DelegateCommand(IncreaceCharacteristic);
            decreace = new ArithmeticCommand(v => v--);
            increace = new ArithmeticCommand(v => v++);
            decreaceExp = new ArithmeticCommand(v => v -= 50);
            increaceExp = new ArithmeticCommand(v => v += 50);
        }
        #endregion Constructor

        #region Commands
        private void IncreaceCharacteristic(object obj)
        {
            Characteristic characteristic = obj as Characteristic;
            if ((Character.TotalExpirience - Character.SpendExpirience) >= characteristic.Cost && characteristic.Rank < 6)
            {
                if(characteristic.Value < 95)                
                    characteristic.Value += 5;                
                else                
                    characteristic.Value = 99;
                characteristic.Rank++;
                characteristic.ChangeAdvanceCost(Character.Aptitudes);
                Character.SpendExpirience += characteristic.Cost;
                
            }
        }
        
        #endregion Commands

    }
}
