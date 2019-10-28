using DarkHeresy2CharacterCreator.Model.Character;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Services
{
    public class FileIOService
    {
        private readonly string PATH;

        public ObservableCollection<Character> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new ObservableCollection<Character>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return fileText == string.Empty ? new ObservableCollection<Character>() : JsonConvert.DeserializeObject<ObservableCollection<Character>>(fileText);
            }
        }

        public void SaveData(ObservableCollection<Character> characters)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(characters, Formatting.Indented);
                writer.Write(output);
            }
        }
        /*public void SaveData(object character)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(character, Formatting.Indented);
                writer.Write(output);
            }
        }*/

        public FileIOService(string path)
        {
            PATH = path;
        }

    }
}
