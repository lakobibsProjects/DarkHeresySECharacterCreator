using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.View;
using DarkHeresy2CharacterCreator.ViewModel.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.CharacterSheet
{
    [AddINotifyPropertyChangedInterface]
    public class CharacterWindowVM
    {
        #region Fields
        private DelegateCommand changeCharacterCommand;
        private DelegateCommand saveCommand;
        private DelegateCommand saveAndExitCommand;
        private DelegateCommand exitCommand;

        #endregion Fields

        #region Properties
        public ICharacter Character { get; set; }
        public ICommand ChangeCharacterCommand => changeCharacterCommand;
        public ICommand SaveCommand => saveCommand;
        public ICommand SaveAndExitCommand => saveAndExitCommand;
        public ICommand ExitCommand => exitCommand;
        #endregion Properties

        #region Contructors
        public CharacterWindowVM()
        {
            Character = MainWindowVM.OpenedCharacter;
            changeCharacterCommand = new DelegateCommand(OnChangeCharacter);
            saveCommand = new DelegateCommand(OnSave);
            saveAndExitCommand = new DelegateCommand(OnSaveAndExit);
            exitCommand = new DelegateCommand(OnExit);
        }
        #endregion Contructors

        #region Asistant Methods
        private void OnChangeCharacter(object obj)
        {
            Window window = obj as Window;
            window.Close();
            Window mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void OnSave(object obj)
        {
            try
            {
                if (Character != null)
                {
                    CharactersList.CharactersIO.SaveData(CharactersList.Characters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }
        private void OnSaveAndExit(object obj)
        {
            try
            {
                if (Character != null)
                {
                    CharactersList.CharactersIO.SaveData(CharactersList.Characters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
            Application.Current.Shutdown();
        }
        private void OnExit(object obj)
        {
            Application.Current.Shutdown();
        }
        #endregion Asistant Methods
    }
}
