using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{
    /// <summary>
    /// Instaniate a observableCollection of elements of gear
    /// </summary>
    public static class GearCollection
    {
        /// <summary>
        /// Collection of elements of gear
        /// </summary>
        public static ObservableCollection<IItem> Gear = new ObservableCollection<IItem>
        {
            new Item("Backpack", Availability.Abundant, 2, backpackDiscription),
            new Item("Chameleoline Cloack", Availability.Rare, 0.5, chameleolineCloackDiscription),
            new Item("Chrono", Availability.Plentiful, 0, chronoDiscription),
            new Item("Clothing", Availability.Abundant, 2, clothingDiscription),
            new Item ("Combat Vest", Availability.Scarce, 2, combatVestDiscription),
            new Item("Concealed Holster", Availability.Average, 1, concealedHolsterDiscription),
            new Item("Deadspace Earpiece", Availability.Very_Rare, 0, deadspaceEarpieceDiscription),
            new Item("Explosive Collar", Availability.Scarce, 3, explosiveCollarDiscription),
            new Item("Filtration Plugs", Availability.Common, 0, filtrationPlugsDiscription),
            new Item("Photo-Visors/Contacts", Availability.Scarce, 0.5, photoVisorsDiscription),
            new Item("Preyscense Goggles", Availability.Very_Rare, 0.5, preyscenseGogglesDiscription),
            new Item("Rebreather", Availability.Scarce, 1, rebreatherDiscription),
            new Item("Recoil Glove", Availability.Rare, 0.5, recoilGloveDiscription),
            new Item("Respirator/Gas Mask", Availability.Average, 0.5, respiratorGasMaskDiscription),
            new Item("Survival Suit", Availability.Average, 0, survivalSuitDiscription),
            new Item("Synskin", Availability.Very_Rare, 2, synskinDiscription),
            new Item("Void Suit", Availability.Scarce, 8, voidSuitDiscription)
        };

        #region Discriptions
        private static readonly string backpackDiscription = "These personal carrying items can range from containers of heavy cloth to elaborate, " +
            "body-conforming devices with internal bracing for comfort.They all allow the wearer to transport roughly 30 kg of extra weight, " +
            "but removing an object from the pack requires a Full Action.Only one backpack or combat vest can be worn at a time.";
        private static readonly string chameleolineCloackDiscription = "Chameleoline material is made up of mimic fibres that blend the coloration of the wearer into their surroundings," +
            " and is the garb of choice for snipers.The wearer gains a +20 bonus to Stealth tests.If he remains stationary during his turn, Ballistic Skill tests targeting " +
            "him suffer a –30 penalty until the beginning of his next turn.";
        private static readonly string chronoDiscription = "Chronos are small timepieces, and are essential for Acolytes to properly time their actions." +
            "Basic versions simply indicate local time and require manual setting, but finer models can synch to external datastreams for the greatest possible accuracy.";
        private static readonly string clothingDiscription = "Clothing styles vary greatly across the Imperium, some as basic protection with no thought to aesthetics, " +
            "some purely ornamental with no concern for environmental or other lesser worries.For some, clothing styles are set at birth or through factory dictates. " +
            "Others adopt the styles of their gang, sect, house, or other affiliation.While basic clothing common to a setting should be simple to acquire, " +
            "more elaborate garb of either higher status or specialised function should be more difficult, with the GM acting as final arbiter on Availability or creation.";
        private static readonly string combatVestDiscription = "While this outerwear vest offers no additional protection, it does include numerous pouches and " +
            "straps to keep extra weapon clips, sidearms, and grenades within easy reach.Common styles include hip packs, holsters, bandoliers, and vests and " +
            "can hold 15 kg comfortably. Items held in the combat vest can be drawn as a Free Action during the character’s turn. Only one backpack or combat vest can be worn at a time.";
        private static readonly string concealedHolsterDiscription = "These conformal pouches can hold a small pistol such as an autopistol or stub automatic, " +
            "and are worn under obscuring clothing to disguise the weapon from observers.Attempts to detect such a weapon suffer a –20 penalty, " +
            "but Ready actions for this weapon become a Full Action rather than a Half Action(or a Half Action instead of a Free Action where applicable).";
        private static readonly string deadspaceEarpieceDiscription = "Each of these tiny devices can limit high-volume sonic disturbances (such as explosions) " +
            "by automatically detecting and dampening the excessive noise down to a tolerable level.Users wearing this earpiece make any Toughness tests against " +
            "sonic effects or against the auditory effects of a Concussive weapon with a +20 bonus.";
        private static readonly string explosiveCollarDiscription = "These give penal legionnaires extra incentive to fight and expunge their sins to the Emperor, " +
            "as well as to keep captured prisoners in line.Each of these heavy collars comes with a remote, usually with a range of 1 km." +
            "The remote can either release or explode the collar, which automatically explodes if out of range of the remote for longer than 5 minutes. " +
            "When triggered, the explosive on the collar detonates.The resulting decapitation instantly kills the wearer, and counts as having a frag " +
            "grenade detonated at the location. Removing an explosive collar without the remote requires a Hard (–20) Tech-Use test." +
            "If the character trying to remove the collar fails by two or more degrees of failure, the collar explodes.";
        private static readonly string filtrationPlugsDiscription = "Worn in each nostril, filtration plugs screen out most pollutants and hazardous gases." +
            "A character wearing filtration plugs gains a +20 bonus to any Toughness test made to resist the effects of damaging gases." +
            "Good craftsmanship models add another +10 bonus, while Poor models must be replaced after five hours of usage as the filter becomes clogged and unusable.";
        private static readonly string photoVisorsDiscription = "These can be worn as corneal lenses or as outer eyewear, and amplify any low-level light to" +
            " allow the wearer to see as if normal lighting was present.Characters wearing these gain the Dark-sight trait. " +
            "Good craftsmanship visors also dampen the effects of photon flash grenades, making the wearer immune to their effects.";
        private static readonly string preyscenseGogglesDiscription = "This eyewear device reveals thermal images so that the wearer can detect things " +
            "that would be otherwise hidden in obscuring mists and shadow.Poor craftsmanship models cannot belie their true nature and are bulky goggles with glowing lenses; " +
            "Good and Best craftsmanship models are disguised as normal(if elaborate) eyeglasses." +
            "A character wearing these goggles suffers no penalties due to darkness, and gains a +20 bonus to vision-based Perception tests at night.";
        private static readonly string rebreatherDiscription = "These devices store and recycle breathable air via a mask and  external supply tank, " +
            "making the user to immune to toxic atmospheres, even allowing him to survive underwater.The air canister lasts only for about one hour and then must be replaced, " +
            "which takes a Full Action.Good craftsmanship models last two hours, while Poor ones take two Full Actions to replace the canister. Replacement canisters are Scarce.";
        private static readonly string recoilGloveDiscription = "This heavy gauntlet uses interlocking plates laced with memory wire to stiffen in a protective grip, " +
            "absorbing the shock from powerful hand weapons.A character using a recoil glove can fire a Basic weapon with one hand without the normal –20 penalty, " +
            "and can wield pistol weapons that normally require two hands in one hand without penalty.Note that specialised weapon training " +
            "is still required to use the weapon properly, without which the Untrained penalty of –20 still applies.";
        private static readonly string respiratorGasMaskDiscription = "A simple breathing mask that covers the nose and mouth or entire face, " +
            "these offer much better protection than filtration plugs.A character wearing a respirator gains a +30 bonus to a Toughness test made to resist the effects of gas " +
            "and can re-roll the test if failed.Good craftsmanship models add another +10 bonus, while Poor models must be replaced after 10 hours of usage as the filter becomes clogged and unusable.";
        private static readonly string survivalSuitDiscription = "When working in harsh and extreme conditions (especially when it is not known in advance what they will be), " +
            "survival suits are a must.No matter if it is too hot or too cold, the suit can maintain proper body temperature and hydration via excellent insulation capabilities." +
            "Using the differential between body temperature and outside temperature to drive thermoelectric power cells, it also has reclamation systems for turning sweat into drinking water." +
            "Most suits come complete with a hood, as well as goggles to protect the head and face.While it does not protect forever, for mediumduration emergencies " +
            "it can help sustain life until a rescue. The suit grants a +20 bonus to any tests to withstand the effects of extreme environments." +
            "Good and Best craftsmanship suits grant a +25 and +30 bonus, respectively, while Poor outfits only last three days before their internal mechanisms falter " +
            "and need removal from the extreme temperatures to recharge.";
        private static readonly string synskinDiscription = "Synskin is a bio-reactive body glove with an inert non-reflective surface that moulds itself to the wearer’s form." +
            "It grants 2 Armour points to all locations not already armoured and the wearer gains a +10 bonus to Stealth tests. It also renders the wearer invisible " +
            "to the use of preysense goggles and those with the Dark-sight trait.";
        private static readonly string voidSuitDiscription = "These fully-sealed suits are essential for operating in the vacuum of space, but can also be useful in toxic " +
            "or hostile environments.A Common craftsmanship void suit has 12 hours of air and imposes a –10 penalty to Agility tests. Poor craftsmanship versions have six " +
            "hours of air, while Good and Best craftsmanship versions eliminate the Agility penalty.";
        #endregion
    }
}
