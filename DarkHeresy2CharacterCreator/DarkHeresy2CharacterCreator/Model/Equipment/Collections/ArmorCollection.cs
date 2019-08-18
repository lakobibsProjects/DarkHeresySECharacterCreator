using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Collections
{
    public static class ArmorCollection
    {
        public static ObservableCollection<IArmor> Armors = new ObservableCollection<IArmor>
        {
            #region Basic
            new Armor("Heavy Leathers")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 1,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Common,
                LocationCovered = new LocationName[3]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm }                
            },
            new Armor("Imperial Robes")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 1,
                MaxAgility = 100,
                Weight = 4,
                Availability = Availability.Average,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor("Armoured Bodyglove")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Right_Leg, LocationName.Left_Leg }
            },
            new Armor("Chainmail Suit")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 3,
                MaxAgility = 35,
                Weight = 15,
                Availability = Availability.Common,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Right_Leg, LocationName.Left_Leg }
            },
            new Armor("Feodal World Plate")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 5,
                MaxAgility = 25,
                Weight = 30,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            new Armor("Xenos Hide Vest")
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
            new Armor("Flak Helmet")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Average,
                LocationCovered = new LocationName[1]{ LocationName.Head }
            },
            new Armor("Flak Gauntlents")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 100,
                Weight = 1,
                Availability = Availability.Average,
                LocationCovered = new LocationName[2]{ LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor("Light Flak Cloack")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 2,
                MaxAgility = 55,
                Weight = 4,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor("Flak Vest")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 60,
                Weight = 5,
                Availability = Availability.Average,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor("Flak Cloack")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 55,
                Weight = 8,
                Availability = Availability.Scarce,
                LocationCovered = new LocationName[5]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor("Flak Coat")
            {
                ArmorType = ArmorType.Flak,
                ArmorPoints = 3,
                MaxAgility = 60,
                Weight = 5,
                Availability = Availability.Average,
                LocationCovered = new LocationName[3]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor("Imperial Guard Flak Armor")
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
            new Armor("Mesh Vest")
            {
                ArmorType = ArmorType.Mesh,
                ArmorPoints = 4,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor("Mesh Cloack")
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
            new Armor("Carapace Helm")
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 4,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Head }
            },
            new Armor("Carapace Gauntlet")
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 5,
                MaxAgility = 100,
                Weight = 2,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[2]{ LocationName.Left_Arm, LocationName.Right_Arm }
            },
            new Armor("Carapace Greaves")
            {
                ArmorType = ArmorType.Basic,
                ArmorPoints = 3,
                MaxAgility = 100,
                Weight = 5,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[2]{ LocationName.Left_Leg, LocationName.Right_Leg }
            },
            new Armor("Enforcer Light Carapace")
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 5,
                MaxAgility = 45,
                Weight = 15,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[6]{ LocationName.Body, LocationName.Left_Arm, LocationName.Right_Arm, LocationName.Left_Leg, LocationName.Right_Leg, LocationName.Head }
            },
            new Armor("Carapace Chestplate")
            {
                ArmorType = ArmorType.Carapace,
                ArmorPoints = 6,
                MaxAgility = 55,
                Weight = 7,
                Availability = Availability.Rare,
                LocationCovered = new LocationName[1]{ LocationName.Body }
            },
            new Armor("Militarum Tempestus Carapace")
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
            new Armor("Loght Power Armour")
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
