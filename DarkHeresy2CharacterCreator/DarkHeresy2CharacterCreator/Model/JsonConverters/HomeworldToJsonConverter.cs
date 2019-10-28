using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    /// <summary>
    /// Convert exeplar of HomeWorld class to Json and back
    /// </summary>
    class HomeworldToJsonConverter : JsonConverter
    {
        /// <summary>
        /// Check input parameter
        /// </summary>
        /// <param name="objectType">Type of input parameter</param>
        /// <returns>Is input parameter exeplar of HomeWorld</returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(HomeWorld).IsAssignableFrom(objectType);
        }
        /// <summary>
        ///     Reads the JSON representation exemplar of the HomeWorld class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ObservableCollection<HomeWorld> homeworlds = HomeWorldList.HomeWorlds;
            var serachedHomewrold = reader.Value.ToString();
            foreach (var item in homeworlds)
            {
                if (item.Name == serachedHomewrold)
                    return item;
            }

            return null;
        }

        /// <summary>
        /// Reads the JSON representation exemplar of the HomeWorld class.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to read from.</param>
        /// <param name="value">Value of object that being write</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                HomeWorld homeworld = value as HomeWorld;
                writer.WriteValue(homeworld.Name);
            }

        }
    }
}
