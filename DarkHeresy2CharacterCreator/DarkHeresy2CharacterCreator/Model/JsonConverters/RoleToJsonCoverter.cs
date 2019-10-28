using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
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
    /// Convert exeplar of Role class to Json and back
    /// </summary>
    class RoleToJsonCoverter : JsonConverter
    {
        /// <summary>
        /// Check input parameter
        /// </summary>
        /// <param name="objectType">Type of input parameter</param>
        /// <returns>Is input parameter exeplar of Role</returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(Role).IsAssignableFrom(objectType);
        }
        /// <summary>
        ///     Reads the JSON representation exemplar of the Role class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ObservableCollection<Role> roles = RoleList.Roles;
            var serachedRole = reader.Value.ToString();
            foreach (var item in roles)
            {
                if (item.Name == serachedRole)
                    return item;
            }

            return null;
        }

        /// <summary>
        /// Reads the JSON representation exemplar of the Role class.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to read from.</param>
        /// <param name="value">Value of object that being write</param>
        /// <param name="serializer">The calling serializer.</param>
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
