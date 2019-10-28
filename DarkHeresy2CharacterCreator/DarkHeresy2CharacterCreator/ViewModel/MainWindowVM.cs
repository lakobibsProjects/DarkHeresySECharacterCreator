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
using System.ComponentModel;
using DarkHeresy2CharacterCreator.Services;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVM
    {
        #region Fields
        private readonly DelegateCommand newCharacterCommand;
        private readonly DelegateCommand closeApplicationCommand;
        private readonly DelegateCommand loadCharacterCommand;

        public FileIOService FileIOService { get; private set; }

        private readonly DelegateCommand deleteCharacterCommand;
        public static ObservableCollection<ICharacter> characters = new ObservableCollection<ICharacter>();
        #endregion Fields

        #region Propreties
        public ICommand NewCharacterCommand => newCharacterCommand;
        public ICommand LoadCharacterCommand => loadCharacterCommand;
        public ICommand DeleteCharacterCommand => deleteCharacterCommand;
        public ICommand CloseApplicationCommand => closeApplicationCommand;
        public Character SelectedCharacter { get; set; }
        public static Character OpenedCharacter { get; set; }
        #endregion

        public MainWindowVM()
        {
            
            newCharacterCommand = new DelegateCommand(OnNewCharacter);
            closeApplicationCommand = new DelegateCommand(OnCloseApplication);
            deleteCharacterCommand = new DelegateCommand(OnDeleteCaharacter);
            loadCharacterCommand = new DelegateCommand(OnLoadCharacter);            
        }

        #region Command Handlers
        private void OnLoadCharacter(object obj)
        {
            if (SelectedCharacter != null)
            {
                OpenedCharacter = SelectedCharacter;
                if (SelectedCharacter.HomeWorld == null)
                {
                    Window homeWorldWindow = new HomeWorld();
                    homeWorldWindow.Show();
                    return;
                }
                if (SelectedCharacter.Background == null)
                {
                    Window backgroundWindow = new Background();
                    backgroundWindow.Show();
                    return;
                }
                if (SelectedCharacter.Role == null)
                {
                    Window roleWindow = new Role();
                    roleWindow.Show();
                    return;
                }                
                Window characterSheet = new CharacterSheetView();
                characterSheet.Show();
                Window currentWindow = obj as Window;
                currentWindow.Close();
            }
        }

        private void OnDeleteCaharacter(object obj)
        {
            try
            {
                if (SelectedCharacter != null)
                {
                    CharactersList.Characters.RemoveAt(CharactersList.Characters.IndexOf(SelectedCharacter));
                    CharactersList.CharactersIO.SaveData(CharactersList.Characters);
                }                                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }

        private void OnCloseApplication(object obj)
        {
            Application.Current.Shutdown();
        }

        private void OnNewCharacter(object obj)
        {
            Character newCharacter = new Character();            
            try
            {
                CharactersList.Characters.Add(newCharacter);
                CharactersList.CharactersIO.SaveData(CharactersList.Characters); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
            OpenedCharacter = newCharacter;
            Window homeWorldWindow = new HomeWorld();
            homeWorldWindow.Show();
        }
        #endregion
    }
}
