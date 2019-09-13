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
using System.Collections.ObjectModel;
using DarkHeresy2CharacterCreator.Model.Character;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVM
    {
        #region Fields
        private readonly DelegateCommand newCharacterCommand;
        private readonly DelegateCommand closeApplicationCommand;
        private readonly DelegateCommand loadCharacterCommand;
        private readonly DelegateCommand deleteCharacterCommand;
        public ObservableCollection<ICharacter> characters;
        #endregion Fields

        #region Propreties
        public ICommand NewCharacterCommand => newCharacterCommand;
        public ICommand LoadCharacterCommand => loadCharacterCommand;
        public ICommand DeleteCharacterCommand => deleteCharacterCommand;
        public ICommand CloseApplicationCommand => closeApplicationCommand;
        public ObservableCollection<ICharacter> Characters { get { return characters; } set { characters = value; } }
        #endregion

        public MainWindowVM()
        {
            newCharacterCommand = new DelegateCommand(OnNewCharacter);
            closeApplicationCommand = new DelegateCommand(OnCloseApplication);
            deleteCharacterCommand = new DelegateCommand(OnDeleteCaharacter);
            loadCharacterCommand = new DelegateCommand(OnLoadCharacter);
            characters = CharactersList.Characters;
        }

        #region Command Handlers
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
        #endregion
    }
}
