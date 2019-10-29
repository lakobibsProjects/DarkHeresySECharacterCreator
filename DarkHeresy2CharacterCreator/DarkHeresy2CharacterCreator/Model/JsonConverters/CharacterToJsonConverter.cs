using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    //Not work. Fix later. Or delete.
    internal class CharacterToJsonConverter : JsonConverter<DarkHeresy2CharacterCreator.Model.Character.Character>
    {
        /// <summary>
        ///     Reads the JSON representation exemplar of the Character class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override DarkHeresy2CharacterCreator.Model.Character.Character ReadJson(JsonReader reader, Type objectType, DarkHeresy2CharacterCreator.Model.Character.Character existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            Character.Character character = JsonConvert.DeserializeObject<Character.Character>(reader.Value.ToString());// existingValue;

            while (reader.Read())
            {
                var val = (reader.Value as string) ?? string.Empty;
                if (val.StartsWith("bg "))
                    character.Background = BackgroundCollection.Backgrounds.Where(b => b.Name == val.Substring(3)).FirstOrDefault();
                if (val.StartsWith("hw "))
                    character.HomeWorld = HomeWorldList.HomeWorlds.Where(b => b.Name == val.Substring(3)).FirstOrDefault();
                if (val.StartsWith("rl "))
                    character.Role = RoleList.Roles.Where(b => b.Name == val.Substring(3)).FirstOrDefault();
            }
            return character;
        }

        public override void WriteJson(JsonWriter writer, DarkHeresy2CharacterCreator.Model.Character.Character value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
            foreach (var item in value.GetType().GetProperties())
            {
                var type = item.PropertyType;
                if (item.GetValue(value) != null)
                {
                    if (type == typeof(Background) && item != null)
                        writer.WriteValue(string.Format("bg {0}", ((Background)item.GetValue(value)).Name));

                    if (type == typeof(HomeWorld) && item != null)
                        writer.WriteValue(string.Format("hw {0}", ((HomeWorld)item.GetValue(value)).Name));

                    if (type == typeof(Role) && item != null)
                        writer.WriteValue(string.Format("rl {0}", ((Role)item.GetValue(value)).Name));
                }
                /*if (type == typeof(int) || type == typeof(string))                
                    writer.WriteValue(item.GetValue(value));  */

            }
        }
    }
}
