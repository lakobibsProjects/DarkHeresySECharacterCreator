using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
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
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BackgroundVM
    {
        #region Fields
        private readonly DelegateCommand nextWindowCommand;
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background> backgrounds;


        #endregion

        #region Properties
        public ICommand NextWindowCommand => nextWindowCommand;
        public ICommand PreviousWindowCommand => previousWindowCommand;
        public ICommand CancelCommand => cancelCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background> Backgrounds { get { return backgrounds; } set { backgrounds = value; } }
        public DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background SelectedBackground { get; set; }
        #endregion

        public BackgroundVM()
        {
            nextWindowCommand = new DelegateCommand(OnNextWindow);
            cancelCommand = new DelegateCommand(OnCancel);
            previousWindowCommand = new DelegateCommand(OnPreviousWindow);
            try
            {
                backgrounds = BackgroundsCollection.Backgrounds;
            }
            catch (Exception e )
            {
                try
                {
                    MessageBox.Show(e.InnerException.InnerException.StackTrace);
                }
                catch { }
                throw;
            }
        }

        #region  Command Handlers
        private void OnPreviousWindow(object obj)           //TODO add functional to remove background-based variables to character
        {
            MainWindowVM.SelectedCharacter.RemoveBackround();
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new View.CharacterCreationView.HomeWorld();
            backgroundWindow.Show();
        }

        private void OnCancel(object obj)           //TODO add fuctional to remove new created character
        {
            MainWindowVM.SelectedCharacter.RemoveHomeworld();
            MainWindowVM.SelectedCharacter.RemoveBackround();
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)           //TODO add functional to save background-based variables to character
        {
            MainWindowVM.SelectedCharacter.AddBackround(SelectedBackground);
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new View.CharacterCreationView.Role();
            backgroundWindow.Show();
        }
        #endregion
    }
}
