using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
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
    public class BackgroundVM
    {
        #region Fields
        private readonly DelegateCommand nextWindowCommand;
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background> backgrounds;


        #endregion

        #region Properties
        public ICommand NextWindowCommand => nextWindowCommand;
        public ICommand PreviousWindowCommand => previousWindowCommand;
        public ICommand CancelCommand => cancelCommand;
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background> Backgrounds { get { return backgrounds; } set { backgrounds = value; } }
        public DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Background SelectedBackground { get; set; }
        public bool BackgroundIsSelected { get { return SelectedBackground != null; } }
        public string AptitudeString
        {
            get
            {
                if (SelectedBackground != null)
                {
                    StringBuilder temp = new StringBuilder();
                    temp.Append(SelectedBackground.BackgroundAptitude.Item1.ToString()).Append(" or ").Append(SelectedBackground.BackgroundAptitude.Item2.ToString());

                    return temp.ToString().Substring(0, temp.Length);
                }
                return string.Empty;
            }
        }
        public string SkillsString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                if (SelectedBackground != null)
                {
                    if (SelectedBackground.BackgroundSkills.Count > 0)
                    {
                        foreach (var item in SelectedBackground.BackgroundSkills)
                        {

                            if (item.Item1 != null)
                            {
                                if (item.Item2 == null)
                                    temp.Append(item.Item1.Name.ToString()).Append(", ");
                                else
                                    temp.Append(item.Item1.Name.ToString()).Append(" or ").Append(item.Item2.Name.ToString()).Append(", ");
                            }

                        }
                    }
                    return temp.ToString().Substring(0, temp.Length - 2);
                }
                return string.Empty;
            }
        }
        public string TalentsString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                string result = string.Empty;
                if (SelectedBackground != null)
                {
                    if (SelectedBackground.BackgroundsTalents.Count > 0)
                    {
                        foreach (var item in SelectedBackground.BackgroundsTalents)
                        {
                            if (item.Item1 != null)
                            {
                                if (item.Item2 == null)
                                    temp.Append(item.Item1.Name.ToString()).Append(", ");
                                temp.Append(item.Item1.Name.ToString()).Append(" or ").Append(item.Item2.Name.ToString()).Append(", ");

                                result = temp.ToString().Substring(0, temp.Length - 2);
                            }
                        }
                    }
                }
                return result;
            }
        }
        public string EquipmentString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                string result = string.Empty;
                if (SelectedBackground != null)
                {
                    if (SelectedBackground.BackgroundEquipment.Count > 0)
                    {
                        foreach (var item in SelectedBackground.BackgroundEquipment)
                        {
                            if (item.Item1 != null)
                            {
                                if (item.Item2 == null)
                                    temp.Append(item.Item1.Name.ToString()).Append(", ");
                                else
                                    temp.Append(item.Item1.Name.ToString()).Append(" or ").Append(item.Item2.Name.ToString()).Append(", ");

                                result = temp.ToString().Substring(0, temp.Length - 2);
                            }
                        }
                    }
                }
                return result;
            }
        }
        public string RolesString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                string result = string.Empty;
                if (SelectedBackground != null)
                {
                    if (SelectedBackground.RecommendedRoles.Count > 0)
                    {
                        foreach (var item in SelectedBackground.RecommendedRoles)
                        {
                            temp.Append(item.ToString()).Append(", ");
                            result = temp.ToString().Substring(0, temp.Length - 2);
                        }
                    }
                }
                return result;
            }
        }
        #endregion

        public BackgroundVM()
        {
            nextWindowCommand = new DelegateCommand(OnNextWindow);
            cancelCommand = new DelegateCommand(OnCancel);
            previousWindowCommand = new DelegateCommand(OnPreviousWindow);
            try
            {
                backgrounds = BackgroundsCollection.Backgrounds;
            }
            catch (Exception e )
            {
                try
                {
                    MessageBox.Show(e.InnerException.InnerException.StackTrace);
                }
                catch { }
                throw;
            }
        }

        #region  Command Handlers
        private void OnPreviousWindow(object obj)           //TODO add functional to remove background-based variables to character
        {
            MainWindowVM.OpenedCharacter.RemoveBackround();
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new View.CharacterCreationView.HomeWorld();
            backgroundWindow.Show();
        }

        private void OnCancel(object obj)           //TODO add fuctional to remove new created character
        {
            MainWindowVM.OpenedCharacter.RemoveHomeworld();
            MainWindowVM.OpenedCharacter.RemoveBackround();
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)           //TODO add functional to save background-based variables to character
        {
            MainWindowVM.OpenedCharacter.AddBackround(SelectedBackground);
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new View.CharacterCreationView.Role();
            backgroundWindow.Show();
        }
        #endregion
    }
}
