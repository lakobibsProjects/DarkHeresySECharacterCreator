using DarkHeresy2CharacterCreator.Model.Characteristics;
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
    /// Convert exemplar of Characteristic class to Json and back
    /// </summary>
    class CharacteristicsToJsonConverter : JsonConverter
    {
        /// <summary>
        /// Check input parameter
        /// </summary>
        /// <param name="objectType">Type of input parameter</param>
        /// <returns>Is input parameter exeplar of Characteristic</returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(Characteristic).IsAssignableFrom(objectType);
        }
        /// <summary>
        ///     Reads the JSON representation exemplar of the Characteristic class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string temp = reader.Value.ToString();
            string name = temp.Substring(0, temp.IndexOf("Value: ") - 2).Substring(temp.IndexOf("Name: ") + 6);          
            int value = int.Parse(temp.Substring(0, temp.IndexOf("Rank: ") - 2).Substring(temp.IndexOf("Value: ") + 7));
            int rank = int.Parse(temp.Substring(temp.IndexOf("Rank: ") + 6).Trim());

            foreach (var item in CharacteristicList.Characteristics)
            {
                if (item.Name.ToString() == name)
                {
                    item.Value = value;
                    item.Rank = rank;
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Reads the JSON representation exemplar of the Characteristic class.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to read from.</param>
        /// <param name="value">Value of object that being write</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                Characteristic characteristic = value as Characteristic;
                    writer.WriteValue(string.Format("Name: {0}, Value: {1}, Rank: {2}",
                        characteristic.Name, characteristic.Value, characteristic.Rank));                
            }
        }
    }
}
