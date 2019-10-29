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
    /// Instaniate a observableCollection of weapons
    /// </summary>
    public static class WeaponCollection
    {
        //require mechanism to add numeric value of weapon special qualities
        /// <summary>
        /// Collection of weapons
        /// </summary>
        public static ObservableCollection<IWeapon> Weapons = new ObservableCollection<IWeapon>
        {
            #region Ranged
            #region Bolt
            new RangedWeapon()
            {
                Name = "Bolt Pistol",
                Type = WeaponType.Bolt,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                Penetration = 4,
                DamageType = DamageType.Explosive,
                Range = 30,
                Weight = 3.5,
                Clip = 8,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Boltgun",
                Type = WeaponType.Bolt,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                Penetration = 4,
                DamageType = DamageType.Explosive,
                Range = 100,
                Weight = 7,
                Clip = 24,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Heavy Bolter",
                Type = WeaponType.Bolt,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Heavy,
                Damage = new Tuple<int, int, int>(1, 10, 8),
                Penetration = 5,
                DamageType = DamageType.Explosive,
                Range = 150,
                Weight = 40,
                Clip = 60,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(0, 0, 6),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Storm Bolter",
                Type = WeaponType.Bolt,
                Availability = Availability.Extremely_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                Penetration = 4,
                DamageType = DamageType.Explosive,
                Range = 90,
                Weight = 9,
                Clip = 60,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault(),
                WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Storm").Select(n=>n).FirstOrDefault()}
            },
            #endregion
            #region Flame
            new RangedWeapon()
            {
                Name = "Hand Flamer",
                Type = WeaponType.Flame,
                Availability = Availability.Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 2,
                DamageType = DamageType.Energy,
                Range = 10,
                Weight = 3.5,
                Clip = 2,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Flame").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Spray").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = "Flamer",
                Type = WeaponType.Flame,
                Availability = Availability.Scarce,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 2,
                DamageType = DamageType.Energy,
                Range = 20,
                Weight = 6,
                Clip = 6,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Flame").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Spray").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = "Heavy Flamer",
                Type = WeaponType.Flame,
                Availability = Availability.Rare,
                Class = WeaponClass.Heavy,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                Penetration = 4,
                DamageType = DamageType.Energy,
                Range = 30,
                Weight = 45,
                Clip = 10,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Flame").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Spray").Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Flame
            #region Las
            new RangedWeapon()
            {
                Name = "Laspistol",
                Type = WeaponType.Las,
                Availability = Availability.Common,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 2),
                Penetration = 0,
                DamageType = DamageType.Energy,
                Range = 30,
                Weight = 1.5,
                Clip = 30,
                Reload = 0.5,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Lasgun",
                Type = WeaponType.Las,
                Availability = Availability.Common,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 0,
                DamageType = DamageType.Energy,
                Range = 100,
                Weight = 4,
                Clip = 60,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Laslock",
                Type = WeaponType.Las,
                Availability = Availability.Plentiful,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 0,
                DamageType = DamageType.Energy,
                Range = 70,
                Weight = 4,
                Clip = 1,
                Reload = 0.5,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unreliable").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Longlas",
                Type = WeaponType.Las,
                Availability = Availability.Scarce,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 1,
                DamageType = DamageType.Energy,
                Range = 150,
                Weight = 4.5,
                Clip = 40,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Accurate").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Felling").Select(n=>n).FirstOrDefault(), //add numeric 
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = "Hot-shot Laspistol",
                Type = WeaponType.Las,
                Availability = Availability.Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 7,
                DamageType = DamageType.Energy,
                Range = 20,
                Weight = 4,
                Clip = 40,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0)
            },
            new RangedWeapon()
            {
                Name = "Hot-shot Lasgun",
                Type = WeaponType.Las,
                Availability = Availability.Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 7,
                DamageType = DamageType.Energy,
                Range = 60,
                Weight = 6,
                Clip = 30,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0)
            },
            #endregion Las
            #region Laucher 
            new RangedWeapon()
            {
                Name = "Grenade Launcher",
                Type = WeaponType.Laucher,
                Availability = Availability.Average,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                DamageType = DamageType.Explosive,
                Range = 60,
                Weight = 12,
                Clip = 6,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0)
            },
            new RangedWeapon()
            {
                Name = "Missile Laucher",
                Type = WeaponType.Laucher,
                Availability = Availability.Rare,
                Class = WeaponClass.Heavy,
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                DamageType = DamageType.Explosive,
                Range = 300,
                Weight = 35,
                Clip = 1,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0)
            },
            #endregion Launcher
            #region Low-Tech Ranged
            new RangedWeapon()
            {
                Name = "Bolas",
                Type = WeaponType.Low_Tech,
                Availability = Availability.Average,
                Class = WeaponClass.Throw,
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 4,
                DamageType = DamageType.Explosive,
                Range = 10,
                Weight = 1.5,
                Clip = 1,
                Reload = 0,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Inaccurate").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == "Snare").Select(n => n).FirstOrDefault()        //add numeric
                }
            },
            new RangedWeapon()
            {
                Name = "Bow",
                Type = WeaponType.Low_Tech,
                Availability = Availability.Common,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                Penetration = 0,
                DamageType = DamageType.Rending,
                Range = 30,
                Weight = 2,
                Clip = 1,
                Reload = 0.5,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == "Primitive").Select(n => n).FirstOrDefault()        //add numeric
                }
            },
            new RangedWeapon()
            {
                Name = "Crossbow",
                Type = WeaponType.Low_Tech,
                Availability = Availability.Common,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                Penetration = 0,
                DamageType = DamageType.Rending,
                Range = 30,
                Weight = 3,
                Clip = 1,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == "Primitive").Select(n => n).FirstOrDefault()  }//add numeric
            },
            #endregion Low-Tech Ranged
            #region Melta
            new RangedWeapon()
            {
                Name = "Inferno Pistol",
                Type = WeaponType.Melta,
                Availability = Availability.Near_Unique,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(2, 10, 10),
                Penetration = 12,
                DamageType = DamageType.Energy,
                Range = 10,
                Weight = 3,
                Clip = 3,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Melta").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Meltagun",
                Type = WeaponType.Melta,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(2, 10, 10),
                Penetration = 12,
                DamageType = DamageType.Energy,
                Range = 20,
                Weight = 15,
                Clip = 5,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Melta").Select(n=>n).FirstOrDefault() }
            },
            #endregion Melta
            #region Plasma
            new RangedWeapon()
            {
                Name = "Plasma Pistol",
                Type = WeaponType.Plasma,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 6),
                Penetration = 6,
                DamageType = DamageType.Energy,
                Range = 30,
                Weight = 3.5,
                Clip = 10,
                Reload = 3,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Maximal").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Overheats").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = "Plasma Gun",
                Type = WeaponType.Plasma,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 7),
                Penetration = 6,
                DamageType = DamageType.Energy,
                Range = 90,
                Weight = 18,
                Clip = 40,
                Reload = 5,
                RateOfFire = new Tuple<int, int, int>(1, 2, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Maximal").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Overheats").Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Plasma
            #region Solid Projectile
            new RangedWeapon()
            {
                Name = "Autopistol",
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Average,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 2),
                Penetration = 0,
                DamageType = DamageType.Impact,
                Range = 30,
                Weight = 1.5,
                Clip = 18,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 6)
            },
            new RangedWeapon()
            {
                Name = "Autogun",
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Average,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 0,
                DamageType = DamageType.Impact,
                Range = 100,
                Weight = 5,
                Clip = 30,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 3, 10)
            },
            new RangedWeapon()
            {
                Name = "Autocannon",
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Heavy,
                Damage = new Tuple<int, int, int>(3, 10, 8),
                Penetration = 6,
                DamageType = DamageType.Impact,
                Range = 300,
                Weight = 40,
                Clip = 24,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = "Hand Cannon",
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Scarce,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 2,
                DamageType = DamageType.Impact,
                Range = 35,
                Weight = 3.0,
                Clip = 5,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0)
            },
            new RangedWeapon("Heavy Stubber")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Rare,
                Class = WeaponClass.Heavy,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 3,
                DamageType = DamageType.Impact,
                Range = 100,
                Weight = 30,
                Clip = 80,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(0, 0, 8)
            },
            new RangedWeapon("Shotgun")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Average,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 0,
                DamageType = DamageType.Explosive,
                Range = 30,
                Weight = 5,
                Clip = 8,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Scatter").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon("Shotgun (Combat)")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Scarce,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 0,
                DamageType = DamageType.Explosive,
                Range = 30,
                Weight = 6.5,
                Clip = 18,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Scatter").Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon("Sniper Rifle")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Scarce,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                Penetration = 3,
                DamageType = DamageType.Explosive,
                Range = 200,
                Weight = 5,
                Clip = 20,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Accurate").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon("Stub Atumatic")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Average,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 0,
                DamageType = DamageType.Impact,
                Range = 30,
                Weight = 1.5,
                Clip = 9,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0)
            },
            new RangedWeapon("Stub Revolver")
            {
                Type = WeaponType.Solid_Projectile,
                Availability = Availability.Plentiful,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 0,
                DamageType = DamageType.Impact,
                Range = 30,
                Weight = 1.5,
                Clip = 9,
                Reload = 6,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Reliable").Select(n=>n).FirstOrDefault() }
            },
            #endregion Solid Projectile
            #region Exotic Ranged
            new RangedWeapon("Grav Pistol")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Near_Unique,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                Penetration = 6,
                DamageType = DamageType.Impact,
                Range = 15,
                Weight = 3,
                Clip = 6,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Graviton").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon("Graviton Gun")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Extremely_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 6),
                Penetration = 8,
                DamageType = DamageType.Impact,
                Range = 30,
                Weight = 6,
                Clip = 9,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 3, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Graviton").Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon("Needle Pistol")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                Penetration = 4,
                DamageType = DamageType.Rending,
                Range = 30,
                Weight = 1.5,
                Clip = 6,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Accurate").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Felling").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Toxic").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon("Needle Rifle")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                Penetration = 0,
                DamageType = DamageType.Rending,
                Range = 180,
                Weight = 2,
                Clip = 6,
                Reload = 2,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Accurate").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Felling").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Toxic").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon("Web Pistol")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Pistol,
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                DamageType = DamageType.Rending,
                Range = 300,
                Weight = 3.5,
                Clip = 1,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Snare").Select(n=>n).FirstOrDefault() }    //add numeric                
            },
            new RangedWeapon("Webber")
            {
                Type = WeaponType.Exotic,
                Availability = Availability.Rare,
                Class = WeaponClass.Basic,
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                DamageType = DamageType.Rending,
                Range = 50,
                Weight = 8,
                Clip = 1,
                Reload = 1,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Snare").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            #endregion Exotic Ranged
            #endregion Ranged
            #region Grenades
            new RangedWeapon("Blind Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Scarce,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                 SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Smoke").Select(n=>n).FirstOrDefault() }//add numeric
            },
            new RangedWeapon("Choke Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Scarce,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault() }//add numeric
            },
            new RangedWeapon("Frag Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Common,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(2, 10, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault() }//add numeric
            },
            new RangedWeapon("Hallucinogenic Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Scarce,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Hallucinogenic").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon("Krak Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Rare,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(2, 10, 4),
                Penetration = 6,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault() } //add numeric                                
            },
            new RangedWeapon("Harwire Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Very_Rare,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Haywire").Select(n=>n).FirstOrDefault() } //add numeric                                

            },
            new RangedWeapon("Photon Flash Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Rare,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault() } //add numeric                                

            },
            new RangedWeapon("Smoke Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Common,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Smoke").Select(n=>n).FirstOrDefault() } //add numeric                                

            },
            new RangedWeapon("Stun Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Common,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                DamageType = DamageType.Explosive,
                                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon("Web Grenade")
            {
                Type = WeaponType.Grenade,
                Availability = Availability.Rare,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(0, 0, 0),
                Penetration = 0,
                Weight = 0.5,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Snare").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon("Frag Missile")
            {
                Availability = Availability.Average,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(2, 10, 2),
                Penetration = 2,
                Weight = 1,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Blast").Select(n=>n).FirstOrDefault() } //add numeric                                

            },
            new RangedWeapon("Krak Missile")
            {
                Availability = Availability.Scarce,
                Class = WeaponClass.Throw,
                RateOfFire = new Tuple<int, int, int>(1, 0, 0),
                Damage = new Tuple<int, int, int>(3, 10, 8),
                Penetration = 8,
                Weight = 1,
                DamageType = DamageType.Explosive,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault(),   //add numeric   
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Proven").Select(n=>n).FirstOrDefault()        //add numeric   
                }

            },
            #endregion Grenades
            #region Melee
            #region Chain
            new Weapon("Chainblade")
            {
                Type = WeaponType.Chain,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,1),
                DamageType = DamageType.Rending,
                Penetration = 1,
                Weight = 2,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault() }
            },
            new Weapon("Chainaxe")
            {
                Type = WeaponType.Chain,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 4),
                DamageType = DamageType.Rending,
                Penetration = 2,
                Weight = 13,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Chainsword")
            {
                Type = WeaponType.Chain,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,2),
                DamageType = DamageType.Rending,
                Penetration = 2,
                Weight = 6,
                Availability = Availability.Average,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Balanced").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Eviscerator")
            {
                Type = WeaponType.Chain,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2,10,0),
                DamageType = DamageType.Rending,
                Penetration = 12,
                Weight = 15,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[4]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Tearing").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Razor Sharp").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unwieldly").Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Chain
            #region Force
            new Weapon("Force Sword")
            {
                Type = WeaponType.Force,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,1),
                DamageType = DamageType.Rending,
                Penetration = 2,
                Weight = 5,
                Availability = Availability.Near_Unique,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Force").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Balanced").Select(n=>n).FirstOrDefault(),
                }
            },
            new Weapon("Force Staff")
            {
                Type = WeaponType.Force,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,0),
                DamageType = DamageType.Impact,
                Penetration = 2,
                Weight = 2,
                Availability = Availability.Extremely_Rare,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Force").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault(),
                }            },
            #endregion Force
            #region Low-Tech Melee
            new Weapon("Great Weapon")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2,10,0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 7,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unbalanced").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Hunting Lance")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2,10,3),
                DamageType = DamageType.Explosive,
                Penetration = 7,
                Weight = 4,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault() }    //add numeric
            },
            new Weapon("Improvised")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,-2),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 0,
                Availability = Availability.Plentiful,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unbalanced").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Knife")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 5,
                Damage = new Tuple<int, int, int>(1, 5, 0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 1,
                Availability = Availability.Plentiful
            },
            new Weapon("Shield")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 5, 0),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Common,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Defensive").Select(n=>n).FirstOrDefault() }
            },
            new Weapon("Spear")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Common,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault(),    //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Staff")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Plentiful,
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Balanced").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault(),    //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Sword")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Common,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Balanced").Select(n=>n).FirstOrDefault() }
            },
            new Weapon("Truncheon")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 2,
                Availability = Availability.Plentiful,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault() } //add numeric
            },
            new Weapon("Warhammer")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                DamageType = DamageType.Impact,
                Penetration = 1,
                Weight = 4.5,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Concussive").Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Whip")
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 3,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 2,
                Availability = Availability.Average,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Flexible").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Primitive").Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            #endregion Low-Tech Melee
            #region Power
            new Weapon("Omnissian Axe")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2,10,4),
                DamageType = DamageType.Energy,
                Penetration = 6,
                Weight = 8,
                Availability = Availability.Extremely_Rare,
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Power Filed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unwieldly").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Power Fist")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2, 10, 0),
                DamageType = DamageType.Energy,
                Penetration = 9,
                Weight = 13,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Power Filed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unwieldly").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Power Sword")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                DamageType = DamageType.Energy,
                Penetration = 5,
                Weight = 3,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Power Filed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Balanced").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Power Axe")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 7),
                DamageType = DamageType.Energy,
                Penetration = 7,
                Weight = 6,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[3]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Power Filed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Unbalanced").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Two-Handed").Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon("Power Maul (High)")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 5),
                DamageType = DamageType.Energy,
                Penetration = 4,
                Weight = 3.5,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Power Filed").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Shoking").Select(n=>n).FirstOrDefault()
                }
            },
             new Weapon("Power Maul (Low)")
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 1),
                DamageType = DamageType.Energy,
                Penetration = 2,
                Weight = 3.5,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Shoking").Select(n=>n).FirstOrDefault() }
            },
            #endregion Power
            #region Shock
            new Weapon("Shock Maul")
            {
                Type = WeaponType.Shock,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 2.5,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Shoking").Select(n=>n).FirstOrDefault() }
            },
            new Weapon("Shock Whip")
            {
                Type = WeaponType.Shock,
                Class = WeaponClass.Melee,
                Range = 3,
                Damage = new Tuple<int, int, int>(1, 10, 1),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Rare,
                SpecialQualities = new WeaponSpecialQualitie[2]
                {
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Shoking").Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == "Flexible").Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Shock            
            #endregion Melee                                   
        };
    }
}
