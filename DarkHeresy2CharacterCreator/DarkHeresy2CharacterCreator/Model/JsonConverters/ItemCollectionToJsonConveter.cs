﻿using DarkHeresy2CharacterCreator.Model.Equipment;
using DarkHeresy2CharacterCreator.Model.Equipment.Collections;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    /// <summary>
    /// Convert ObservableCollection<IItem> to Json and back
    /// </summary>
    class ItemCollectionToJsonConveter : JsonConverter<ObservableCollection<IItem>>
    {
        //modify method to work with names of items
        /// <summary>
        ///     Reads the JSON representation exemplar of the ObservableCollection<IItem> class.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override ObservableCollection<IItem> ReadJson(JsonReader reader, Type objectType, ObservableCollection<IItem> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            ObservableCollection<IItem> result = new ObservableCollection<IItem>();
            if (existingValue != null || existingValue.Count != 0)
            {
                foreach (var item in existingValue)
                {
                    if (ArmorCollection.Armors.Contains(item))
                        result.Add((ArmorCollection.Armors[ArmorCollection.Armors.IndexOf((IArmor)item)]));
                    if (CyberneticCollection.Cybernetics.Contains(item))
                        result.Add(CyberneticCollection.Cybernetics[CyberneticCollection.Cybernetics.IndexOf(item)]);
                    if (DrugsAndConsumablesCollection.DrugsAndConsumables.Contains(item))
                        result.Add(DrugsAndConsumablesCollection.DrugsAndConsumables[DrugsAndConsumablesCollection.DrugsAndConsumables.IndexOf(item)]);
                    if (GearCollection.Gear.Contains(item))
                        result.Add(GearCollection.Gear[GearCollection.Gear.IndexOf(item)]);
                    if (ToolsCollection.Tools.Contains(item))
                        result.Add(ToolsCollection.Tools[ToolsCollection.Tools.IndexOf(item)]);
                    if (WeaponCollection.Weapons.Contains(item))
                        result.Add(WeaponCollection.Weapons[WeaponCollection.Weapons.IndexOf((IWeapon)item)]);
                }
            }
            return result;
        }
        /// <summary>
        /// Reads the JSON representation exemplar of the ObservableCollection<IItem> class.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to read from.</param>
        /// <param name="value">Value of object that being write</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, ObservableCollection<IItem> value, JsonSerializer serializer)
        {
            writer.WriteValue(new JavaScriptSerializer().Serialize(value.Where(i => i != null).Select(i => i.Name == null ? string.Empty : i.Name)));
        }
    }
}
