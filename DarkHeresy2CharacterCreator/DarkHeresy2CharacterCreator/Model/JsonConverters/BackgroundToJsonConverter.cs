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

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    public class BackgroundToJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Background).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ObservableCollection<Background> bgs = BackgroundsCollection.Backgrounds;
            //if (existingValue != null)            
                return BackgroundsCollection.Backgrounds.Where(b => b.Name == reader.Value.ToString()).FirstOrDefault();                
            
            //return null;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if(value != null)
            {
                Background background = value as Background;
                writer.WriteValue(background.Name);
            }
            
        }
    }
}
