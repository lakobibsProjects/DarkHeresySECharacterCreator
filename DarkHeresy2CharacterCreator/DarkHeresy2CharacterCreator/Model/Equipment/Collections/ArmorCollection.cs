using DarkHeresy2CharacterCreator.Model.Equipment.Enums;
using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Collections
{
    /// <summary>
    /// Instaniate a observableCollection of armor
    /// </summary>
    public static class ArmorCollection
    {
        /// <summary>
        /// Collection of all armor
        /// </summary>
        public static ObservableCollection<IArmor> Armors = new ObservableCollection<IArmor>
        {
            #region Basic
            new Armor(ArmorName.Heavy_Leathers.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 1,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Common,
                LocationCovered = new LocationName[3]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor(ArmorName.Imperial_Robes.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 1,
                MaxAgility = 100,
                Weight = 4,
                Availability = Availability.Average,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor(ArmorName.Armoured_Bodyglove.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Right_Leg, LocationName.Left_Leg }
            },
            new Armor(ArmorName.Chainmail_Suit.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 3,
                MaxAgility = 35,
                Weight = 15,
                Availability = Availability.Common,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Right_Leg, LocationName.Left_Leg }
            },
            new Armor(ArmorName.Feudal_World_Plate.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 5,
                MaxAgility = 25,
                Weight = 30,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            new Armor(ArmorName.Xenos_Hide_Vest.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 6,
                MaxAgility = 50,
                Weight = 20,
                Availability = Availability.Very_Rare,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            #endregion Basic
            #region Flak
            new Armor(ArmorName.Flak_Helmet.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Average,
                LocationCovered = new LocationName[1]{ LocationName.Head }
            },
            new Armor(ArmorName.Flak_Gauntlets.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 1,
                Availability = Availability.Average,
                LocationCovered = new LocationName[2]{ LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor(ArmorName.Light_Flak_Cloak.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 55,
                Weight = 4,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor(ArmorName.Flak_Vest.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 60,
                Weight = 5,
                Availability = Availability.Average,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor(ArmorName.Flak_Cloak.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 55,
                Weight = 8,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor(ArmorName.Flak_Coat.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 60,
                Weight = 5,
                Availability = Availability.Average,
                LocationCovered = new LocationName[3]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor(ArmorName.Imperial_Guard_Flak_Armour.ToString())
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 4,
                MaxAgility = 50,
                Weight = 11,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            #endregion Flak
            #region Mesh
            new Armor(ArmorName.Mesh_Vest.ToString())
            {
                ArmorType = ArmorType.Mesh,
                ArmorPoints = 4,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor(ArmorName.Mesh_Cloak.ToString())
            {
                ArmorType = ArmorType.Mesh,
                ArmorPoints = 4,
                MaxAgility = 60,
                Weight = 3,
                Availability = Availability.Very_Rare,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            #endregion Mesh
            #region Carapace
            new Armor(ArmorName.Carapace_Helm.ToString())
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 4,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Head }
            },
            new Armor(ArmorName.Carapace_Gauntlets.ToString())
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 5,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[2]{ LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor(ArmorName.Carapace_Greaves.ToString())
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 3,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[2]{ LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor(ArmorName.Enforcer_Light_Carapace.ToString())
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 5,
                MaxAgility = 45,
                Weight = 15,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            new Armor(ArmorName.Carapace_Chestplate.ToString())
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 6,
                MaxAgility = 55,
                Weight = 7,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor(ArmorName.Militarum_Tempestus_Carapace.ToString())
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 6,
                MaxAgility = 45,
                Weight = 15,
                Availability = Availability.Very_Rare,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            #endregion Carapace
            #region Power
            new Armor(ArmorName.Light_Power_Armour.ToString())
            {
                ArmorType = ArmorType.Power,
                ArmorPoints = 7,
                MaxAgility = 40,
                Weight = 40,
                Availability = Availability.Very_Rare,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
	        #endregion Power          
        };
    };
}
