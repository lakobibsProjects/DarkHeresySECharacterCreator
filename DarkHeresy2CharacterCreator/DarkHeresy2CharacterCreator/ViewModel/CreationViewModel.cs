using DarkHeresy2CharacterCreator.Model.Character;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
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
    class CreationViewModel
    {
        #region Fields
        private ICharacter createdcharacter;
        private readonly RelayCommand showBackgroundViewCommand;
        private readonly RelayCommand showHomewroldViewCommand;
        private readonly RelayCommand showRoleViewCommand;
        private readonly RelayCommand showSummaryViewCommand;
        private readonly RelayCommand cancelCommand;
        #endregion Fields

        #region Propreties
        public ICharacter CreatedCharacter
        {
            get { return createdcharacter; }
            set { createdcharacter = value; }
        }
        public ICommand ShowBackgroundViewCommand => showBackgroundViewCommand;
        public ICommand ShowRoleViewCommand => showRoleViewCommand;
        public ICommand ShowSummaryViewCommand => showSummaryViewCommand;
        public ICommand ShowHomewroldViewCommand => showHomewroldViewCommand;
        public ICommand CancelCommand => cancelCommand;
        public bool BackgroundViewIsVisible { get; set; } = false;
        public bool HomewroldViewIsVisible { get; set; } = true;
        public bool RoleViewIsVisible { get; set; } = false;
        public bool SummaryViewIsVisible { get; set; } = false;
        public bool CreaitonIsComplete { get; set; } = false;
        public bool CreationIsNotComplete => !CreaitonIsComplete;
        #endregion

        public CreationViewModel()
        {
            CreatedCharacter = MainWindowVM.OpenedCharacter;
            showBackgroundViewCommand = new RelayCommand(OnShowBackgroundView);
            showHomewroldViewCommand = new RelayCommand(OnShowHomewroldView);
            showRoleViewCommand = new RelayCommand(OnShowRoleView);
            showSummaryViewCommand = new RelayCommand(OnShowSummaryView);
            cancelCommand = new RelayCommand(OnCancel);
        }

        #region Command Handlers
        private void OnShowHomewroldView(object obj)
        {
            if(CreatedCharacter.HomeWorld != null)
                CreatedCharacter.RemoveHomeworld();
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = true;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = false;
        }
        private void OnShowBackgroundView(object obj)
        {
            if (CreatedCharacter.Background != null)
                CreatedCharacter.RemoveBackround();
            if (obj is HomeWorld)
                CreatedCharacter.AddHomeworld((HomeWorld)obj);            
            BackgroundViewIsVisible = true;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = false;
        }
        private void OnShowRoleView(object obj)
        {
            if (CreatedCharacter.Role != null)
                CreatedCharacter.RemoveRole();
            if (obj is Background)
                CreatedCharacter.AddBackround((Background)obj);
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = true;
            SummaryViewIsVisible = false;            

            
        }
        private void OnShowSummaryView(object obj)
        {
            if (obj is HomeWorld)
                CreatedCharacter.AddHomeworld((HomeWorld)obj);
            if (obj is Background)
                CreatedCharacter.AddBackround((Background)obj);
            if (obj is Role)
                CreatedCharacter.AddRole((Role)obj);
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = true;
            CreaitonIsComplete = true;
        }
        private void OnCancel(object obj)
        {
            CharactersList.Characters.Remove(CreatedCharacter);
            /*if(MainWindowVM.OpenedCharacter.Background != null)
                MainWindowVM.OpenedCharacter.RemoveBackround();
            if (MainWindowVM.OpenedCharacter.HomeWorld != null)
                MainWindowVM.OpenedCharacter.RemoveHomeworld();
            if (MainWindowVM.OpenedCharacter.Role != null)
                MainWindowVM.OpenedCharacter.RemoveRole();*/
            Window window = obj as Window;
            window.Close();
        }
        #endregion
    }
}
