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
    /// Instaniate a observableCollection of weapons
    /// </summary>
    public static class WeaponCollection
    {
        //todo: require mechanism to add numeric value of weapon special qualities
        /// <summary>
        /// Collection of weapons
        /// </summary>
        public static ObservableCollection<IWeapon> Weapons = new ObservableCollection<IWeapon>
        {
            #region Ranged
            #region Bolt
            new RangedWeapon()
            {
                Name = WeaponName.Bolt_Pistol.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Boltgun.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Heavy_Bolter.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Storm_Bolter.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[2]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault(),
                WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Storm.ToString()).Select(n=>n).FirstOrDefault()}
            },
            #endregion
            #region Flame
            new RangedWeapon()
            {
                Name = WeaponName.Hand_Flamer.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Flame.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Spray.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Flamer.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Flame.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Spray.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Hevy_Flamer.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Flame.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Spray.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Flame
            #region Las
            new RangedWeapon()
            {
                Name = WeaponName.Laspistiol.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Lasgun.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Laslock.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unreliable.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Long_Las.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Accurate.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Felling.ToString()).Select(n=>n).FirstOrDefault(), //add numeric 
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Hotshot_Laspistol.ToString(),
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
                Name = WeaponName.Hotshot_Lasgun.ToString(),
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
                Name = WeaponName.Grenade_Launcher.ToString(),
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
                Name = WeaponName.Missile_Launcher.ToString(),
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
                Name = WeaponName.Bolas.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Inaccurate.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == WeaponQualitieName.Snare.ToString()).Select(n => n).FirstOrDefault()        //add numeric
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Bow.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == WeaponQualitieName.Primitive.ToString()).Select(n => n).FirstOrDefault()        //add numeric
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Crossbow.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n => n.Name == WeaponQualitieName.Primitive.ToString()).Select(n => n).FirstOrDefault()  }//add numeric
            },
            #endregion Low-Tech Ranged
            #region Melta
            new RangedWeapon()
            {
                Name = WeaponName.Inferno_Pistol.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Melta.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Meltagun.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Melta.ToString()).Select(n=>n).FirstOrDefault() }
            },
            #endregion Melta
            #region Plasma
            new RangedWeapon()
            {
                Name = WeaponName.Plasma_Pistol.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Maximal.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Overheats.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Plasma_Gun.ToString(),
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Maximal.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Overheats.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Plasma
            #region Solid Projectile
            new RangedWeapon()
            {
                Name = WeaponName.Autopistol.ToString(),
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
                Name = WeaponName.Autogun.ToString(),
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
                Name = WeaponName.Autocannon.ToString(),
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon()
            {
                Name = WeaponName.Hand_Cannon.ToString(),
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
            new RangedWeapon(WeaponName.Heavy_Stubber.ToString())
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
            new RangedWeapon(WeaponName.Shotgun.ToString())
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Scatter.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon(WeaponName.Shotgun_Combat.ToString())
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Scatter.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new RangedWeapon(WeaponName.Sniper_Rifle.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Accurate.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon(WeaponName.Stub_Automatic.ToString())
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
            new RangedWeapon(WeaponName.Stub_Revolver.ToString())
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
                SpecialQualities = new WeaponSpecialQualitie[1]{ WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Reliable.ToString()).Select(n=>n).FirstOrDefault() }
            },
            #endregion Solid Projectile
            #region Exotic Ranged
            new RangedWeapon(WeaponName.Grav_Pistol.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Concussive.ToString()).Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Graviton.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon(WeaponName.Graviton_Gun.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Concussive.ToString()).Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Graviton.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new RangedWeapon(WeaponName.Needle_Pistol.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Accurate.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Felling.ToString()).Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Toxic.ToString()).Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon(WeaponName.Needle_Rifle.ToString())
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
                     WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Accurate.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Felling.ToString()).Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Toxic.ToString()).Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            new RangedWeapon(WeaponName.Web_Pistol.ToString())
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
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Snare.ToString()).Select(n=>n).FirstOrDefault() }    //add numeric                
            },
            new RangedWeapon(WeaponName.Webber.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Blast.ToString()).Select(n=>n).FirstOrDefault(),  //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Snare.ToString()).Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            #endregion Exotic Ranged
            #endregion Ranged
            #region Grenades
            new RangedWeapon(WeaponName.Blind_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Choke_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Frag_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Hallucinogenic_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Krak_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Haywire_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Photon_Flash_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Smoke_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Stun_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Web_Grenade.ToString())
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
            new RangedWeapon(WeaponName.Frag_Missile.ToString())
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
            new RangedWeapon(WeaponName.Krak_Missile.ToString())
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
            new Weapon(WeaponName.Chainblade.ToString())
            {
                Type = WeaponType.Chain,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1,10,1),
                DamageType = DamageType.Rending,
                Penetration = 1,
                Weight = 2,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new Weapon(WeaponName.Chainaxe.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Chainsword.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Balanced.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Eviscerator.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Tearing.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Razor_Sharp.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unwieldly.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Chain
            #region Force
            new Weapon(WeaponName.Force_Sword.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Force.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Balanced.ToString()).Select(n=>n).FirstOrDefault(),
                }
            },
            new Weapon(WeaponName.Force_Staff.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Force.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault(),
                }            },
            #endregion Force
            #region Low-Tech Melee
            new Weapon(WeaponName.Great_Weapon.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unbalanced.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Hunting_Lance.ToString())
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(2,10,3),
                DamageType = DamageType.Explosive,
                Penetration = 7,
                Weight = 4,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Concussive.ToString()).Select(n=>n).FirstOrDefault() }    //add numeric
            },
            new Weapon(WeaponName.Improvised.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unbalanced.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Knife.ToString())
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
            new Weapon(WeaponName.Shield.ToString())
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 5, 0),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Common,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Defensive.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new Weapon(WeaponName.Spear.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault(),    //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Staff.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Balanced.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault(),    //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Sword.ToString())
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Rending,
                Penetration = 0,
                Weight = 3,
                Availability = Availability.Common,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Balanced.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new Weapon(WeaponName.Trucheon.ToString())
            {
                Type = WeaponType.Low_Tech,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 0),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 2,
                Availability = Availability.Plentiful,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault() } //add numeric
            },
            new Weapon(WeaponName.Warhammer.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Concussive.ToString()).Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault(),   //add numeric
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Whip.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Flexible.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Primitive.ToString()).Select(n=>n).FirstOrDefault()     //add numeric
                }
            },
            #endregion Low-Tech Melee
            #region Power
            new Weapon(WeaponName.Omnissian_Axe.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Power_Field.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unwieldly.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Power_Fist.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Power_Field.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unwieldly.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Power_Sword.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Power_Field.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Balanced.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Power_Axe.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Power_Field.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Unbalanced.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Two_Handed.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Power_Maul_Heigh.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Power_Field.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Shoking.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            new Weapon(WeaponName.Power_Maul_Low.ToString())
            {
                Type = WeaponType.Power,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 1),
                DamageType = DamageType.Energy,
                Penetration = 2,
                Weight = 3.5,
                Availability = Availability.Very_Rare,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Shoking.ToString()).Select(n=>n).FirstOrDefault() }
            },
            #endregion Power
            #region Shock
            new Weapon(WeaponName.Shock_Maul.ToString())
            {
                Type = WeaponType.Shock,
                Class = WeaponClass.Melee,
                Range = 0,
                Damage = new Tuple<int, int, int>(1, 10, 3),
                DamageType = DamageType.Impact,
                Penetration = 0,
                Weight = 2.5,
                Availability = Availability.Scarce,
                SpecialQualities = new WeaponSpecialQualitie[1] { WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Shoking.ToString()).Select(n=>n).FirstOrDefault() }
            },
            new Weapon(WeaponName.Shock_Whip.ToString())
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
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Shoking.ToString()).Select(n=>n).FirstOrDefault(),
                    WeaponSpecialQuilitieCollection.WeaponSpecialQualities.Where(n =>  n.Name == WeaponQualitieName.Flexible.ToString()).Select(n=>n).FirstOrDefault()
                }
            },
            #endregion Shock            
            #endregion Melee                                   
        };
    }
}
