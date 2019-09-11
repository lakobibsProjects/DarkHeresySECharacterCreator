using DarkHeresy2CharacterCreator.View.CharacterCreationView;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    class BackgroundVM
    {
        private readonly DelegateCommand nextWindowCommand;
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand;

        public ICommand NextWindowCommand => nextWindowCommand;
        public ICommand PreviousWindowCommand => previousWindowCommand;
        public ICommand CancelCommand => cancelCommand;

        public BackgroundVM()
        {
            nextWindowCommand = new DelegateCommand(OnNextWindow);
            cancelCommand = new DelegateCommand(OnCancel);
            previousWindowCommand = new DelegateCommand(OnPreviousWindow);
        }

        private void OnPreviousWindow(object obj)           //TODO add functional to remove background-based variables to character
        {
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new HomeWorld();
            backgroundWindow.Show();
        }

        private void OnCancel(object obj)           //TODO add fuctional to remove new created character
        {
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)           //TODO add functional to save background-based variables to character
        {
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new Role();
            backgroundWindow.Show();
        }
    }
}
