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
using System.Windows.Controls;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class HomeworldVM
    {
        #region Fields
        private readonly DelegateCommand nextWindowCommand; //not use
        private readonly DelegateCommand cancelCommand;
        private readonly DelegateCommand previousWindowCommand; //not use
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld> homeworlds;
        #endregion

        #region Properties
        public ICommand NextWindowCommand => nextWindowCommand; //not use
        public ICommand PreviousWindowCommand => previousWindowCommand; //not use
        public ICommand CancelCommand => cancelCommand; //not use
        public ObservableCollection<DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld> Homeworlds { get { return homeworlds; } set { homeworlds = value; } }
        public DarkHeresy2CharacterCreator.Model.GeneralSuppliment.HomeWorld SelectedHomeworld { get; set; }
        public bool HomeworldIsSelected =>  SelectedHomeworld != null;
        public string CharacteristicsString
        {
            get
            {
                if (SelectedHomeworld != null)
                
                    return string.Format("+{0}; +{1}; -{2} ", SelectedHomeworld.Characteristics[0].ToString().Replace("_", " "),
                        SelectedHomeworld.Characteristics[1].ToString().Replace("_", " "), SelectedHomeworld.Characteristics[2].ToString().Replace("_", " "));
                return string.Empty;                
            }
        }
        public string HomeworldAptitudeString
        {
            get
            {
                if (SelectedHomeworld != null)
                    return SelectedHomeworld.HomeWorldAptitude.ToString();
                return string.Empty;
            }
        }
        public string RecomendedBackgroundsString
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                string result = string.Empty;
                if (SelectedHomeworld != null)
                {
                    if (SelectedHomeworld.RekommendedBackgrouns.Length > 0)
                    {
                        foreach (var item in SelectedHomeworld.RekommendedBackgrouns)
                            temp.Append(item.ToString()).Append(", ");
                        result = temp.ToString().Substring(0, temp.Length - 2);
                    }
                }
                return result;
            }
        }
        #endregion

        public HomeworldVM()
        {
            if (MainWindowVM.OpenedCharacter.HomeWorld != null)
                MainWindowVM.OpenedCharacter.RemoveHomeworld();
            nextWindowCommand = new DelegateCommand(OnNextWindow); //not use
            cancelCommand = new DelegateCommand(OnCancel); //not use
            previousWindowCommand = new DelegateCommand(OnPreviousWindow); //not use
            homeworlds = HomeWorldList.HomeWorlds;
        }

        #region Command Handlers
        private void OnPreviousWindow(object obj) //not use
        {
            throw new NotImplementedException();
        }

        private void OnCancel(object obj) //not use           //TODO add fuctional to remove new created character
        {
            MainWindowVM.OpenedCharacter.RemoveHomeworld();
            Window window = obj as Window;
            window.Close();
        }

        private void OnNextWindow(object obj)  //not use          //TODO add functional to save homeworld-based variables to character
        {
            MainWindowVM.OpenedCharacter.AddHomeworld(SelectedHomeworld);
            Window window = obj as Window;
            window.Close();
            Window backgroundWindow = new Background();
            backgroundWindow.Show();
        }
        #endregion
    }
}
