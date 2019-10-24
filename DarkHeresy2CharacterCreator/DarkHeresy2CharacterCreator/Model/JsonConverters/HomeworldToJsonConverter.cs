using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    class HomeworldToJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(HomeWorld).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //if (existingValue != null)
                return HomeWorldList.HomeWorlds.Where(b => b.Name == reader.Value).FirstOrDefault();

            //return null;

        }

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
