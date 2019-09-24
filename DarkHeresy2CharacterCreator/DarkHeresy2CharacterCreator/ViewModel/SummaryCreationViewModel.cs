﻿using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Characteristics;
using DarkHeresy2CharacterCreator.Model.DiceRoller;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class SummaryCreationViewModel
    {
        #region Fields
        private ICharacter createdcharacter;
        private Divinations divination;
        private DelegateCommand setDivinationCommand;
        private DelegateCommand setCharateristic;
        private DelegateCommand getAptitudes;
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
        public ICommand SetDivinationCommand => setDivinationCommand;
        public ICommand SetCharateristic => setCharateristic;
        public ICommand GetAptitudes => getAptitudes;

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

        public List<string> SpecialAbilities
        {
            get
            {
                var result = new List<string>();
                result.Add(CreatedCharacter.HomeWorld.HomeWorldBonus);         //null
                result.Add(CreatedCharacter.Role.RoleBonus);                   //null
                result.Add(CreatedCharacter.Background.BackgroundBonuds);     //null
                return result;
            }
        }
        public List<string> Skills
        {
            get
            {
                var result = new List<string>();
                foreach (var s in CreatedCharacter.Skills)
                {
                    if (s != null)
                        result.Add(s.Name.ToString());
                }
                return result;
            }
        }

        #endregion Properties

        #region Constructor
        public SummaryCreationViewModel()
        {
            CreatedCharacter = MainWindowVM.SelectedCharacter;
            setDivinationCommand = new DelegateCommand(SetDivination);
            setCharateristic = new DelegateCommand(RollCharacteristic);
            getAptitudes = new DelegateCommand(ReturnAptitudes);

        }

        private void ReturnAptitudes(object obj)
        {
            var temp = CreatedCharacter.Aptitudes;
        }
        #endregion Constructor

        #region Helped Methods
        private void SetDivination(object obj)
        {
            CreatedCharacter.Divination = DiceRoller.Roll();
            Divination = new Divinations(CreatedCharacter.Divination);
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

        #endregion Helped Methods

    }
}