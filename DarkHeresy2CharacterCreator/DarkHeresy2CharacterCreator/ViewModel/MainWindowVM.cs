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
        public ObservableCollection<ICharacter> characters = new ObservableCollection<ICharacter>();
        #endregion Fields

        #region Propreties
        public ICommand NewCharacterCommand => newCharacterCommand;
        public ICommand LoadCharacterCommand => loadCharacterCommand;
        public ICommand DeleteCharacterCommand => deleteCharacterCommand;
        public ICommand CloseApplicationCommand => closeApplicationCommand;
        public ObservableCollection<ICharacter> Characters { get { return characters; } set { characters = value; } }
        public ICharacter SelectedCharacter { get; set; }
        public static ICharacter OpenedCharacter { get; set; }
        #endregion

        public MainWindowVM()
        {
            
            newCharacterCommand = new DelegateCommand(OnNewCharacter);
            closeApplicationCommand = new DelegateCommand(OnCloseApplication);
            deleteCharacterCommand = new DelegateCommand(OnDeleteCaharacter);
            loadCharacterCommand = new DelegateCommand(OnLoadCharacter);
            try
            {
                characters = CharactersList.Characters;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
            
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
            if(SelectedCharacter != null)
                Characters.Remove(SelectedCharacter);
        }

        private void OnCloseApplication(object obj)
        {
            Application.Current.Shutdown();
        }

        private void OnNewCharacter(object obj)
        {
            Character newCharacter = new Character();            
            Characters.Add(newCharacter);
            OpenedCharacter = newCharacter;
            Window homeWorldWindow = new HomeWorld();
            homeWorldWindow.Show();
        }
        #endregion
    }
}
