using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Traits
{
    /// <summary>
    /// Intantiate a colletion of traits
    /// </summary>
    public static class TraitList
    {
        #region Discription
        private readonly static string amorphousDiscription = "Not every entity is constrained by a rigid skeleton; some organisms possess a malleable shape," +
            " or are made of a host of smaller beings, and can alter their forms as desired or due to changing environmental conditions." +
            "A creature with this trait may increase or decrease its Size trait value by 1 as a Free Action (though doing so does not change its movement values)." +
            " A creature with this trait also has the Crawler trait.";
        private static string amphibiousDiscription = "The creature can breathe water as well as air and can stay underwater indefinitely" +
            " without the need to surface.If this trait is taken by a creature with the ability to breathe another substance other than air " +
            "(i.e., water, ammonia, carbon-dioxide, etc.) then it can breathe air as well as its native atmosphere.";
        private static string autoStabilisedDiscription = "For exceptionally large creatures, even the most unstable of heavy weapons mean" +
            " little compared to their huge limbs, gripping talons, or sheer bulk.These beings always count as braced when firing heavy weapons" +
            " and therefore may fire a weapon on full or semi-automatic without taking the Brace action first, and not suffer any penalties to hit.";
        private readonly static string banefulPresenceDiscription = "The creature’s very existence is anathema to nearby mortals, " +
            "and permeates its surroundings with the taint of the unnatural.All characters suffer a –10 penalty to Willpower tests taken while within X metres of the creature.";
        private readonly static string bestialDiscription = "A creature with this trait is animalistic, tending to behave instinctively rather than rationally." +
            "No matter how high its Intelligence score is, it is still bestial. A creature with this trait never needs to make a Survival test whilst in its natural" +
            " habitat.Unless starving or desperate, a Bestial creature must make a Challenging (+0) Willpower test when frightened, startled, or injured.If it fails, the creature flees.";
        private readonly static string blindDiscription = "Blind creatures automatically fail all tests based on vision, and automatically fail all Ballistic Skill tests." +
            "Such creatures take a –30 penalty to Weapon Skill tests and most other tests that ordinarily involve or are benefited by vision." +
            "Note that this trait indicates not only that the creature cannot see but that it also has no other senses which would provide the same benefit as eyes" +
            " (such as Unnatural Senses). The Blind Fighting talent reduces the penalty to Weapon Skill tests as normal for Blind creatures, from –30 to –15.";
        private readonly static string brutalChargeDiscription = "A creature with this trait is often massive and powerful, nearly unstoppable in combat." +
            "When Charging, the creature deals an extra(X) points of damage on each hit it inflicts that turn.";
        private readonly static string burrowerDiscription = "A creature with this trait can move through solid objects by burrowing through them." +
            "The number in parentheses(X) indicates its speed when burrowing.Such creatures can burrow through soil, rock, sand, and so on, though some" +
            "(expressed in the creature entry) can even burrow through metal.When a creature burrows, it leaves behind a tunnel." +
            "Characters with a Size trait value lower than the burrower can enter these areas without impediment.At the end of each round after the burrower passes," +
            " roll 1d10; on a result of 5 or lower, the tunnel collapses behind the creature.";
        private readonly static string crawlerDiscription = "Worms, serpents, and similar creatures crawl and slither along the surface rather than walk upright." +
            "The base move for a creature with this trait is half its normal movement rate (round up) as determined by its Agility bonus, but it does not take penalties" +
            " for moving over difficult terrain.";
        private readonly static string daemonicDiscription = "Daemonic creatures are denizens of the Warp, but can manifest in real space either through sheer strength of will, " +
            "hunger, or occult rituals.Creatures with this trait increase their Toughness bonus against all damage by the number indicated in the parentheses (X), " +
            "in the same manner as an Unnatural Characteristic, and stack if the latter also increases Toughness." +
            "This increase is negated by damage inflicted from force weapons, psychic powers, holy attacks, or other creatures with this trait." +
            "Daemonic creatures also have the Undying trait, and gain benefits when using psychic powers.";
        private readonly static string darkSightDiscription = "Some species are sensitive to different wavelengths of light than man, and can detect sights otherwise invisible." +
            "A creature with this trait sees normally even in areas of total darkness, and never takes a penalty for fighting in areas of dim or no lighting.";
        private readonly static string deadlyNaturalWeaponsDiscription = "This creature’s natural attacks are powerful enough to crush plasteel or punch through armour." +
            "The creature gains all the benefits of the Natural Weapons trait, except that its attacks no longer have the Primitive weapon quality.";
        private readonly static string fearDiscription = "A creature with this trait has an unnerving appearance. Some prey upon humanity’s visceral terrors, " +
            "while others depend on the inherent corruptive power of the Warp.The Fear trait always has an associated rating (1–4) to reflect how awful the creature is to behold; " +
            "this is indicated by the number in parentheses(X). The higher the Fear rating, the harder it is for others to resist going insane from the encounter." +
            "When a character encounters a creature with this trait, the character must make a Willpower test with a penalty based on the creature’s Fear rating." +
            "If he succeeds, the character suffers no ill effects; if he fails, he must roll Shock, adding +10 to the roll for every degree of failure on the test.";
        private readonly static string flyerDiscription = "A creature with this trait has the natural ability to fly, whether with broad leathery wings, " +
            "strange warp energies, or inflatable gas sacs. The number in parentheses (X) indicates its speed when flying. " +
            "This number replaces the creature’s Agility bonus for movement actions while airborne.";
        private readonly static string fromBeyondDiscription = "Some creatures are free from the limitations of normal physiology, having emerged from the impossible realm " +
            "of the Warp or perhaps using bodies forged from cold metal and circuitry.Their minds are beyond the petty frailties and precarious sanity of a mortal mind. " +
            "Such a creature is immune to Fear, Pinning, Insanity points, and psychic powers used to cloud, control, or delude its mind.";
        private readonly static string hovererDiscription = "Creatures with this trait have a limited capability for flight, flying no higher than two metres." +
            "The number in parentheses (X) indicates its speed when hovering; this number replaces its Agility bonus for purposes of calculating Movement while airborne.";
        private readonly static string incorporealDiscription = "This creature is insubstantial and weightless, able to pass through solid objects such as walls and weapons. " +
            "Incorporeal creatures gain the Hoverer(6) trait and a +30 bonus on Stealth tests due to their ability to merge with objects and nearly silent movement. " +
            "An Incorporeal creature is also immune to normal weapons, which simply pass ineffectually through its body. Daemons, psychic powers, Warp creatures, " +
            "other Incorporeal creatures, and opponents armed with force weapons can all injure an Incorporeal creature normally." +
            "An Incorporeal creature cannot usually affect the mortal world, and thus cannot damage normal opponents unless it has a suitable special ability or talent." +
            "Certain devices can keep these creatures at bay, though, most notably a Void Shield or a spaceship’s Gellar Field, which acts as an impenetrable barrier to them.";
        private readonly static string machineDiscription = "A creature with this trait is fashioned from inorganic materials and is generally more rigorous then fleshy beings." +
            "Machines do not breathe, are immune to vacuum, extremes of cold, and mind-influencing psychic effects.Machines have a certain number of Armour points " +
            "(indicated by the number in parentheses). This armour stacks with worn armour, but not with the Natural Armour trait, and can damage from Fire.";
        private readonly static string mindLockDiscription = "Many flesh-constructs or mindless creatures are implanted with control mechanisms, complete with " +
            "programmed behavioural instructions.This helps ensure the creature acts properly within its designed parameters, but also can lead to stalled actions " +
            "when it faces circumstances for which it has no guidance.If faced with a situation outside of its programming and with no recognised master to issue orders, " +
            "the creature must pass a Routine (+20) Intelligence test or be Stunned for 1 round.Due to its essentially mindless nature, at the GM’s discretion it is immune " +
            "to all Opposed Social tests.";
        private readonly static string multipleArmsDiscription = "This creature has more than one pair of arms. The exact number of arms is indicated in parentheses(X), " +
            "so a Genestealer with Multiple Arms(4) has four arms total.It gains a +10 bonus on Athletics tests involving climbing and swimming. " +
            "In addition, for each full pair of arms it has (the Multiple Arms value divided by 2) it can make an additional attack as if wielding multiple melee weapons." +
            "In this case, the creature must either have natural weapons or actual melee weapons to wield for this to take effect. Note that a creature still requires " +
            "the Two-Weapon Wielder (Melee or Ranged) talent to make multiple attacks in the same turn.";
        private readonly static string mechinicusImplantsDiscription = "The character is a servant of the Machine-God, and has been entrusted with a suite of specialised implants:" +
            "\n* Cranial CirCuitry Cranial circuitry is a series of linked processors, implants, and cortical circuits that enhances mental capacities." +
            "Most sit within a housing bolted onto the skull, whilst others nestle within the brain itself. " +
            "\n* The Cyber-mantle is a framework of metal, wires, and impulse transmitters bolted onto the spine and lower ribcage." +
            "As the initiate gains further cybernetics such as mechadendrites, the mantle acts as a sub-dermal anchorage point." +
            "Many in the Mechanicum often refer to it as “the true flesh.” " +
            "\n* Electro-graft - small device is grafted into the nervous system, " +
            "allowing the adept to better commune with the many holy mechanisms that are now part of his life.It comes in many forms, such as skull shunts, " +
            "finger probes, or spine jacks, depending on the forge world." +
            "\n* Electoo Inductors are palm-sized metal skin grafts that appear much like tattoos to the uninitiated. " +
            "They are wired into the nervous system, where they derive power from the bioelectrical emanations of the flesh and the sacred mysteries of the Potentia Coil." +
            "With training, they can be used to emit or siphon power in many ways. " +
            "\n* Potentia Coil Cradled within the cyber-mantle is a power unit known as the Potentia Coil." +
            "This mass can store energy and produce various types of fields.Coils come in many types, from small crystal stack affairs to bulky electrical galvinators, " +
            "and a trained user can manipulate the stored energy into a variety of attacks and unique effects.";
        private readonly static string naturalArmourDiscription = "This creature has a naturally tough hide or an exoskeleton, affording it some protection against attacks." +
            "The number in parentheses (X) indicates how many Armour points the creature gains to all locations. Natural Armour stacks with worn armour, but not with the Machine trait.";
        private readonly static string naturalWeaponsDiscription = "This creature has sharp claws, teeth, spines or some other natural weapon with which it can tear apart its foes." +
            "It counts as being armed even when not wielding weapons, with attacks that deal 1d10 points of damage plus its Strength bonus.The creature can make attacks with its " +
            "Natural Weapons using its Weapon Skill, though it cannot Parry with its natural weapons, nor can it be disarmed unless, of course, its limbs are hacked off." +
            "In general, creatures with Natural Weapons are immune to the Power Field quality, as it is assumed they have enough teeth, claws, or spines to ignore a few being removed." +
            "Natural weapons have the Primitive (7) weapon quality unless stated otherwise in the profile.";
        private readonly static string phaseDiscription = "A creature with this trait can transform its body into an insubstantial state, passing ghost-like through" +
            " solid objects or barriers of any sort.As a Half Action, the creature may gain or remove the Incorporeal trait, becoming insubstantial or solid.";
        private readonly static string psykerDiscription = "Whether due to unnatural influences, the study of forbidden lore, or simply sheer force of will, " +
            "this individual is a psyker.Though this trait has no benefits on its own, it allows characters to purchase the Psyniscience skill and psychic powers." +
            "All psykers have a psy rating.";
        private readonly static string quadrupedDiscription = "Quadrupeds are much quicker over a distance than their bipedal counterparts, and their movement is double that normally " +
            "indicated by their Agility bonus(see page 245). This trait is intended to cover creatures that travel on their hind legs and forepaws, rapidly crossing surface" +
            " terrain or tall foliage.Creatures with more than four legs may gain this trait as well, increasing their movement as indicated above but adding an additional 2" +
            " (after doubling) to their final movement rate for each set of legs beyond the first two pairs (i.e., +2 for 6 legs, +4 for 8 legs, etc.).";
        private readonly static string regenerationDiscription = "Physiological enhancements, mutations, xenos physiology, and even Warp-corruption can all result in organisms " +
            "that heal from injury at an inconceivable pace.Each round, at the start of its turn, the creature can make a Toughness test to remove an amount of damage indicated " +
            "in the parentheses after the trait.";
        private readonly static string sanctionedDiscription = "As part of the tithes every world owes the Imperium, each must collect all who show any sign of psychic abilities " +
            "for the Black Ships to carry to Terra.There, the Adeptus Astra Telepathica conduct fearsome testing known as sanctioning for power levels, mental strength, and other " +
            "factors that decide each psyker’s fate. To survive is to have passed these tests, and gone on to serve the Emperor as a Sanctioned Psyker." +
            "If a Sanctioned character gains the Psyker elite advance, he does not gain the Corruption normally inflicted with that advance and starts at psy rating of 2 instead of 1.";
        private readonly static string sizeDiscription = "Creatures come in one of ten different size categories, as shown on Table 4–6: Size.Size affects movement, " +
            "how well the creature can hide and move undetected, and how easy or hard it is to strike in combat.When calculating movement, apply the size modifier first, " +
            "and then other modifiers from other traits or talents(such as Quadruped). Note that a creature’s movement cannot be reduced to less than 1.";
        private readonly static string sonarSenseDiscription = "A creature with this trait perceives its surroundings by emitting uniquely toned pulses, " +
            "allowing the creature to locate the position of any solid object within 30 metres.Other creatures within this 30 metre range that succeed on a " +
            "Difficult (–10) Awareness skill can detect the oddly-pitched sounds echoing around them.";
        private readonly static string soulBoundDiscription = "The soul of this creature is bound to a higher power or being, in return for a measure of protection." +
            "When this trait is first gained, the entity to which the soul is bound must be decided. Many Imperial psykers, especially Astropaths, are soul bound to the Emperor, " +
            "for example, whereas Chaos Sorcerers may be bound to one of the Ruinous Powers. A soul bound psyker rolls an extra die when forced to roll Perils of the Warp, " +
            "then replaces either the ones die or the tens die with the extra die he rolled to determine the final result. Upon becoming soul-bound, " +
            "the psyker must choose one of the following effects: 3d10 Insanity points, the permanent loss of his sight, permanent loss of 1d10 points from one characteristic, " +
            "or a random mutation.In addition, a soul bound character is permanently indebted to the entity, which undoubtedly entails all manner of other duties and consequences.";
        private readonly static string stampedeDiscription = "Whenever a creature with this trait fails a Willpower test, it automatically moves in a straight line " +
            "forwards as far as possible, overrunning anything in its path until the source of danger is escaped or crushed under hoof.Anyone in the way suffers a single hit " +
            "from the creature’s Natural Weapons(or 1d5+SB Impact damage if it does not have that trait). One stampeding creature automatically causes all other creatures " +
            "with the same trait within sight to stampede as well. The stampede lasts until the source of danger is no longer visible or for 1d10 minutes, whichever occurs last.";
        private readonly static string stuffOfNightmaresDiscription = "Some Warp entities are so terribly powerful that the willpower perpetuating their bodies in reality is almost impossible to " +
            "break or disrupt.Such creatures count as having the Undying trait, and are completely immune to most environmental hazards, Blood Loss, and Stunning. " +
            "They also ignore any Critical Effect other than one that would destroy them outright, unless it was caused by a psychic power, force weapon, or holy attack.";
        private readonly static string sturdyDiscription = "Sturdy creatures are hard to move, and thus gain a +20 bonus to tests made to resist Grappling and Knock Down actions, " +
            "and uses of the Takedown talent.";
        private readonly static string touchedByTheFaithDiscription = "Where the naive might see only luck, those who have glimpsed the true nature of the galaxy can see " +
            "when powers outside this realm have made their favour known. The NPC has a number of Fate points shown in parentheses (X). " +
            "It can use these Fate points in exactly the same way as Player Characters and can even burn a Fate point to survive death and destruction at the GM’s discretion. " +
            "The NPC’s attacks also use the rules for Righteous Fury.";
        private readonly static string toxicDiscription = "A creature with this trait has corrosive blood or other exotic defensive mechanisms that inflict harm when it is struck." +
            "A character that successfully deals damage to a Toxic creature in melee combat must make a Toughness test at the end of his turn with a penalty equal to " +
            "10 times the number in parentheses(X), or suffer 1d10 points of Energy damage not reduced by Armour or Toughness.For example, a creature with Toxic (4) would impose a –40 " +
            "on Toughness tests.Some creatures carry additional effects with their toxins, or inflict more damage as indicated in their individual descriptions.";
        private readonly static string undyingDiscription = "This creature has a strange and barely understood physiology.It cannot be harmed by diseases, poisons, " +
            "or toxic effects.It also has no need to breathe, and thus can survive unaided in a vacuum.";
        private readonly static string unnaturalCharacteristicDiscription = "One or more of the creature’s characteristics is unnaturally enhanced.This is indicated " +
            "by a number that is then added directly to the relevant Characteristic bonus. For example, a creature with a Strength of 41 normally has a Strength bonus of 4. " +
            "If the creature had Unnatural Strength (3) then its Strength bonus increases to 7 (4+3). A creature can have this trait more than once, but each time must be applied " +
            "to a new characteristic.Successful tests using a characteristic tied to this trait gain a number of bonus degrees of success equal to half the Unnatural Characteristic value.";
        private readonly static string unnaturalSensesDiscription = "The creature can perceive its surroundings using senses other than sight or hearing, such as special organs, " +
            "fine hairs, or some other disturbing ability.This trait always includes a range in metres indicated by the number in parentheses(X).";
        private readonly static string warpInstabilityDiscription = "Most Warp-entities have a tenuous hold on reality, often maintained only by horror and bloodshed, " +
            "and can be disrupted if sufficient harm can be done to their manifested forms.If a creature with this trait takes damage and does not deal any damage or I" +
            "nsanity points to another creature by the end of its next turn, it must make a Willpower test.The creature suffers 1 point of damage for failing, " +
            "plus 1 additional point of damage for each degree of failure.If this would deal damage equal to (or in excess of) the creature’s wounds, it is cast back into the Warp.";
        private readonly static string warpWeaponsDiscription = "Creatures with this trait have weapons that are partially insubstantial, " +
            "able to ignore such mundane things as armour or cover.Natural weapons and attacks made by a creature with this trait ignore physical armour, " +
            "unless the armour is created from psychoactive materials or is somehow warded against the Warp.Force fields still work against these attacks normally.";
        #endregion

        /// <summary>
        /// Collection of traits
        /// </summary>
        public static ObservableCollection<ITrait> Traits { get; } = new ObservableCollection<ITrait>()
        {
            new Trait(TraitName.Amorphous.ToString(),amorphousDiscription, false),
            new Trait(TraitName.Amphibious.ToString(), amphibiousDiscription, false),
            new Trait(TraitName.Auto_Stabilized.ToString(), autoStabilisedDiscription, false),
            new Trait(TraitName.Baneful_Presence.ToString(), banefulPresenceDiscription, true),
            new Trait(TraitName.Bestial.ToString(), bestialDiscription, false),
            new Trait(TraitName.Blind.ToString(), blindDiscription, false),
            new Trait(TraitName.Brutal_Charge.ToString(), brutalChargeDiscription, true),
            new Trait(TraitName.Burrower.ToString(), burrowerDiscription, true),
            new Trait(TraitName.Crawler.ToString(), crawlerDiscription, false),
            new Trait(TraitName.Daemonic.ToString(), daemonicDiscription, true),
            new Trait(TraitName.Dark_sight.ToString(), darkSightDiscription, false),
            new Trait(TraitName.Deadly_Natural_Weapon.ToString(), deadlyNaturalWeaponsDiscription, false),
            new Trait(TraitName.Fear.ToString(), fearDiscription, true),
            new Trait(TraitName.Flyer.ToString(), flyerDiscription, true),
            new Trait(TraitName.From_Beyond.ToString(), fromBeyondDiscription, false),
            new Trait(TraitName.Hoverer.ToString(), hovererDiscription, true),
            new Trait(TraitName.Incorporeal.ToString(), incorporealDiscription, false),
            new Trait(TraitName.Machine.ToString(), machineDiscription,true),
            new Trait(TraitName.Mechanicus_Implants.ToString(), mechinicusImplantsDiscription, false),
            new Trait(TraitName.Mind_Lock.ToString(),mindLockDiscription, false),
            new Trait(TraitName.Multiple_Arms.ToString(), multipleArmsDiscription, true),
            new Trait(TraitName.Natural_Armour.ToString(), naturalArmourDiscription, true),
            new Trait(TraitName.Natural_Weapons.ToString(), naturalWeaponsDiscription, false),
            new Trait(TraitName.Phase.ToString(), phaseDiscription, false),
            new Trait(TraitName.Psyker.ToString(), psykerDiscription, true),
            new Trait(TraitName.Quadraped.ToString(), quadrupedDiscription, true),
            new Trait(TraitName.Regeneration.ToString(),regenerationDiscription, true),
            new Trait(TraitName.Sanctioned.ToString(), sanctionedDiscription, false),
            new Trait(TraitName.Size.ToString(),sizeDiscription, true),
            new Trait(TraitName.Sonar_Sense.ToString(), sonarSenseDiscription, false),
            new Trait(TraitName.Soul_Bound.ToString(), soulBoundDiscription, false),
            new Trait(TraitName.Stampede.ToString(), stampedeDiscription, false),
            new Trait(TraitName.Stuff_of_Nightmares.ToString(), stuffOfNightmaresDiscription, false),
            new Trait(TraitName.Sturdy.ToString(), sturdyDiscription, false),
            new Trait(TraitName.Touched_by_the_Fates.ToString(), touchedByTheFaithDiscription, true),
            new Trait(TraitName.Toxic.ToString(), toxicDiscription, true),
            new Trait(TraitName.Undying.ToString(), undyingDiscription, false),
            new Trait(TraitName.Unnatural_Agility.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Balistic_Skill.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Fellowship.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Intelligence.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Perception.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Strength.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Toughness.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Weapon_Skill.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Willpower.ToString(), unnaturalCharacteristicDiscription, true),
            new Trait(TraitName.Unnatural_Senses.ToString(), unnaturalSensesDiscription, true),
            new Trait(TraitName.Warp_Instability.ToString(), warpInstabilityDiscription, false),
            new Trait(TraitName.Warp_Weapons.ToString(), warpWeaponsDiscription, false)
        };



    }
}
