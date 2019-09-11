using DarkHeresy2CharacterCreator.View;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using PropertyChanged;
using System.Windows.Input;
using DarkHeresy2CharacterCreator.View.CharacterCreationView;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVM
    {
        private readonly DelegateCommand newCharacterCommand;
        private readonly DelegateCommand closeApplicationCommand;
        private readonly DelegateCommand loadCharacterCommand;
        private readonly DelegateCommand deleteCharacterCommand;
        public ICommand NewCharacterCommand => newCharacterCommand;
        public ICommand LoadCharacterCommand => loadCharacterCommand;
        public ICommand DeleteCharacterCommand => deleteCharacterCommand;
        public ICommand CloseApplicationCommand => closeApplicationCommand;
                
        public MainWindowVM()
        {
            newCharacterCommand = new DelegateCommand(OnNewCharacter);
            closeApplicationCommand = new DelegateCommand(OnCloseApplication);
            deleteCharacterCommand = new DelegateCommand(OnDeleteCaharacter);
            loadCharacterCommand = new DelegateCommand(OnLoadCharacter);
        }

        private void OnLoadCharacter(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnDeleteCaharacter(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnCloseApplication(object obj)
        {
            Application.Current.Shutdown();
        }

        private void OnNewCharacter(object obj)
        {
            Window homeWorldWindow = new HomeWorld();
            homeWorldWindow.Show();
        }
    }
}
