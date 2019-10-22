using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
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
    class RoleVM
    {
        #region Fields
        private readonly RelayCommand nextWindowCommand; //not use
        private readonly RelayCommand cancelCommand; //not use
        private readonly RelayCommand previousWindowCommand; //not use
        #endregion

        #region Properties
        public ICommand NextWindowCommand => nextWindowCommand; //not use
        public ICommand PreviousWindowCommand => previousWindowCommand; //not use
        public ICommand CancelCommand => cancelCommand; //not use
        public DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Role SelectedRole { get; set; }
        public bool RoleIsSelected => SelectedRole != null;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Role> Roles{ get; set; }
        public string TalentsString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                if (SelectedRole != null)
                {
                    if (SelectedRole.RoleTalent.Item2 != null && SelectedRole.RoleTalent.Item1 != null)
                        temp.Append(SelectedRole.RoleTalent.Item1.ToString()).Append(" or ").Append(SelectedRole.RoleTalent.Item2.ToString());
                    else if (SelectedRole.RoleTalent.Item1 != null)
                        temp.Append(SelectedRole.RoleTalent.Item1.ToString());
                }

                return temp.ToString().Substring(0, temp.Length);
            }
        }
        public string AptitudesString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                if (SelectedRole != null)
                {
                    if (SelectedRole.Aptitudes.Count > 0)
                    {
                        foreach (var item in SelectedRole.Aptitudes)
                        {
                                if (item.Item2 == null)
                                    temp.Append(item.Item1.ToString()).Append(", ");
                                else
                                    temp.Append(item.Item1.ToString()).Append(" or ").Append(item.Item2.ToString()).Append(", ");        
                        }
                    }
                    return temp.ToString().Substring(0, temp.Length - 2);
                }
                return string.Empty;
            }
        }
        #endregion

        public RoleVM()
        {
            if (MainWindowVM.OpenedCharacter.Role != null)
                MainWindowVM.OpenedCharacter.RemoveRole();
            nextWindowCommand = new RelayCommand(OnNextWindow); //not use
            cancelCommand = new RelayCommand(OnCancel); //not use
            previousWindowCommand = new RelayCommand(OnPreviousWindow); //not use
            Roles = RoleList.Roles;

        }

        #region Command Handlers  
 
        private void OnPreviousWindow(object obj) //not use           //TODO add functional to remove role-based variables to character
        {
            MainWindowVM.OpenedCharacter.RemoveRole();
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new View.CharacterCreationView.Background();
            backgroundWindow.Show();
        }

        private void OnCancel(object obj) //not use           //TODO add fuctional to remove new created character
        {
            MainWindowVM.OpenedCharacter.RemoveHomeworld();
            MainWindowVM.OpenedCharacter.RemoveBackround();
            MainWindowVM.OpenedCharacter.RemoveRole();
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj) //not use           //TODO add functional to save role-based variables to character and add character to collection
        {
            MainWindowVM.OpenedCharacter.AddRole(SelectedRole);
            Window summaryWindow = new View.CharacterCreationView.SummaryCreationView();
            summaryWindow.Show();
            Window window = obj as Window;
            window.Close();
        }
        #endregion
    }
}
