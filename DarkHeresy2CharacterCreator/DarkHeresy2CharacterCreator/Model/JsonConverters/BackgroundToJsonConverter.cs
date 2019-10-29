using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    /// <summary>
    /// Convert exemplar of Background class to Json and back
    /// </summary>
    public class BackgroundToJsonConverter : JsonConverter
    {
        /// <summary>
        /// Check input parameter
        /// </summary>
        /// <param name="objectType">Type of input parameter</param>
        /// <returns>Is input parameter exeplar of Background</returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(Background).IsAssignableFrom(objectType);
        }
        /// <summary>
        ///     Reads the JSON representation exemplar of the Background class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                ObservableCollection<Background> bgs = BackgroundsCollection.Backgrounds;
                var serachedBackground = reader.Value.ToString();
                foreach (var item in bgs)
                {
                    if (item.Name == serachedBackground)
                        return item;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show(ex.InnerException.InnerException.Message);
                Application.Current.Shutdown();
            }

            return null;
        }

        /// <summary>
        /// Reads the JSON representation exemplar of the Background class.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to read from.</param>
        /// <param name="value">Value of object that being write</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                Background background = value as Background;
                writer.WriteValue(background.Name);
            }

        }
    }
}
