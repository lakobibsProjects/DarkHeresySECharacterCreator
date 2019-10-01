using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.Equipment;
using DarkHeresy2CharacterCreator.Model.Equipment.Collections;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
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

namespace DarkHeresy2CharacterCreator.ViewModel.CharacterSheet
{
    [AddINotifyPropertyChangedInterface]
    public class GearVM
    {
        #region Fields
        private ObservableCollection<IItem> availableItems = new ObservableCollection<IItem>();
        //private ObservableCollection<IItem> ownItems = new ObservableCollection<IItem>();
        private string searchedAvailableItemName;
        private string searchedOwnItemName;
        private DelegateCommand removeItem;
        private DelegateCommand addItem;
        #endregion Fields

        #region Properties
        public ObservableCollection<String> Categories => new ObservableCollection<string> { "All", "Armor", "Cybernetics", "Drugs and consumables", "Gear", "Tools", "Weapons" };
        public ICharacter Character { get; set; }
        public IItem SelectedAvailableItem { get; set; }
        public IItem SelectedOwnItem { get; set; }
        public string SearchedAvailableItemName
        {
            get { return searchedAvailableItemName; }
            set
            {
                searchedAvailableItemName = value;
                FilterItemsCollection(searchedAvailableItemName, AvailableItems);
            }
        }
        public string SearchedOwnItemName
        {
            get { return searchedOwnItemName; }
            set
            {
                searchedOwnItemName = value;
                FilterItemsCollection(searchedOwnItemName, CharacterGear);
            }
        }
        public ObservableCollection<IItem> AvailableItems
        {
            get { return availableItems; }
            set { availableItems = value; }
        }
        //public ObservableCollection<IItem> OwnItems => Character.Gear;
        /*{
            get { return ownItems; }
            set { ownItems = value; }
        }*/
        public ObservableCollection<IItem> CharacterGear => Character.Gear;
        public ICommand RemoveItem => removeItem;
        public ICommand AddItem => addItem;

        #endregion Properties

        #region Costructor
        public GearVM()
        {
            try
            {
                Character = MainWindowVM.SelectedCharacter;
                FillItemsCollection();
                //ownItems = Character.Gear;
                removeItem = new DelegateCommand(RemoveItemCommans);
                addItem = new DelegateCommand(AddItemCommand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion Costructor

        #region Helped Methods
        private void FillItemsCollection()
        {
            try
            {
                foreach (var item in ArmorCollection.Armors)
                    availableItems.Add(item);
                foreach (var item in CyberneticCollection.Cybernetics)
                    availableItems.Add(item);
                foreach (var item in DrugsAndConsumablesCollection.DrugsAndConsumables)
                    availableItems.Add(item);
                foreach (var item in GearCollection.Gear)
                    availableItems.Add(item);
                foreach (var item in ToolsCollection.Tools)
                    availableItems.Add(item);
                foreach (var item in WeaponCollection.Weapons)
                    availableItems.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void FilterItemsCollection(string searchedItemName, ObservableCollection<IItem> items)
        {
            if (searchedItemName != null && searchedItemName.Length > 0)
                items = (ObservableCollection<IItem>)items.Where(i => i.Name.Contains(searchedItemName));

        }
        #endregion Helped Methods

        #region Commands
        private void AddItemCommand (object obj)
        {
            IItem item = obj as IItem;
            if (obj != null)            
                Character.Gear.Add(item);
            
        }
        private void RemoveItemCommans(object obj)
        {
            IItem item = obj as IItem;
            if (obj != null && Character.Gear.Contains(item))
                Character.Gear.Remove(item);
        }
        #endregion Commands
    }
}
