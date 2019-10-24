using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.JsonConverters
{
    class RoleToJsonCoverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Role).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //if (existingValue != null)
                return RoleList.Roles.Where(b => b.Name == reader.Value).FirstOrDefault();

           // return null;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                Role role = value as Role;
                writer.WriteValue(role.Name);
            }

        }
    }
}
