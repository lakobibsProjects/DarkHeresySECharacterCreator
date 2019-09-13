using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
using DarkHeresy2CharacterCreator.View.CharacterCreationView;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class HomeworldVM
    {
        #region Fields
        private readonly DelegateCommand nextWindowCommand;
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld> homeworlds;
        #endregion

        #region Properties
        public ICommand NextWindowCommand => nextWindowCommand;
        public ICommand PreviousWindowCommand => previousWindowCommand;
        public ICommand CancelCommand => cancelCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld> Homeworlds { get { return homeworlds; } set { homeworlds = value; } }
        public DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld SelectedHomeworld { get; set; }
        #endregion

        public HomeworldVM()
        {
            nextWindowCommand = new DelegateCommand(OnNextWindow);
            cancelCommand = new DelegateCommand(OnCancel);
            previousWindowCommand = new DelegateCommand(OnPreviousWindow);
            homeworlds = HomeWorldList.HomeWorlds;
        }

        #region Command Handlers
        private void OnPreviousWindow(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnCancel(object obj)           //TODO add fuctional to remove new created character
        {
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)           //TODO add functional to save homeworld-based variables to character
        {
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new Background();
            backgroundWindow.Show();
        }
        #endregion
    }
}
