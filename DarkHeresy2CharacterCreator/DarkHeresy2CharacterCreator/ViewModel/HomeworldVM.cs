using DarkHeresy2CharacterCreator.View.CharacterCreationView;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
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
        private readonly DelegateCommand nextWindowCommand;
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand;

        public ICommand NextWindowCommand => nextWindowCommand;
        public ICommand PreviousWindowCommand => previousWindowCommand;
        public ICommand CancelCommand => cancelCommand;

        public HomeworldVM()
        {
            nextWindowCommand = new DelegateCommand(OnNextWindow);
            cancelCommand = new DelegateCommand(OnCancel);
            previousWindowCommand = new DelegateCommand(OnPreviousWindow);
        }

        private void OnPreviousWindow(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnCancel(object obj)
        {
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)
        {
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new Background();
            backgroundWindow.Show();
        }

    }
}
