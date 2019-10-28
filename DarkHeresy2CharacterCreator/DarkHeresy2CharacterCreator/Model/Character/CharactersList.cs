using DarkHeresy2CharacterCreator.Services;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    [AddINotifyPropertyChangedInterface]
    public class CharactersList
    {
        public static readonly string CHARACTERLISTPATH = $"{Environment.CurrentDirectory}\\CharactersList.json";
        private static FileIOService charactersIO;
        public static ObservableCollection<Character> Characters { get; set; }

        public static FileIOService CharactersIO
        {
            get { return charactersIO; }
            set { charactersIO = value; }
        }

        public CharactersList()
        {
            CharactersIO = new FileIOService(CHARACTERLISTPATH);
            try
            {
                 Characters = CharactersIO.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }
        /*{
            new Character()
            {
                CharacterName = "Unnamed Character",
                TotalExpirience = 1000
                
            }
        };*/
    }
}
