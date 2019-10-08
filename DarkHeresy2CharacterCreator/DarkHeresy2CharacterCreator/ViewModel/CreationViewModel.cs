using DarkHeresy2CharacterCreator.Model.Character;
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
        private readonly DelegateCommand showBackgroundViewCommand;
        private readonly DelegateCommand showHomewroldViewCommand;
        private readonly DelegateCommand showRoleViewCommand;
        private readonly DelegateCommand showSummaryViewCommand;
        private readonly DelegateCommand cancelCommand;
        #endregion Fields

        #region Propreties
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
            showBackgroundViewCommand = new DelegateCommand(OnShowBackgroundView);
            showHomewroldViewCommand = new DelegateCommand(OnShowHomewroldView);
            showRoleViewCommand = new DelegateCommand(OnShowRoleView);
            showSummaryViewCommand = new DelegateCommand(OnShowSummaryView);
            cancelCommand = new DelegateCommand(OnCancel);
        }

        #region Command Handlers
        private void OnShowRoleView(object obj)
        {
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = true;
            SummaryViewIsVisible = false;            

            
        }
        private void OnShowBackgroundView(object obj)
        {
            BackgroundViewIsVisible = true;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = false;


        }
        private void OnShowHomewroldView(object obj)
        {
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = true;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = false;
        }
        private void OnShowSummaryView(object obj)
        {
            BackgroundViewIsVisible = false;
            HomewroldViewIsVisible = false;
            RoleViewIsVisible = false;
            SummaryViewIsVisible = true;
            CreaitonIsComplete = true;
        }
        private void OnCancel(object obj)
        {
            CharactersList.Characters.Remove(MainWindowVM.OpenedCharacter);
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
