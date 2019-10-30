using DarkHeresy2CharacterCreator.Model.Equipment.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment
{
    /// <summary>
    /// Instaniate a observableCollection of special qualities of weapons
    /// </summary>
    public static class WeaponSpecialQuilitieCollection
    {
        #region Discriptions
        private static readonly string accurateDiscription = "The weapon is crafted for precision attacks, with perfectly crafted las-lenses or finely honed barrels." +
            "This grants an additional bonus of +10 to the firer’s Ballistic Skill when used with an Aim action, in addition to the normal bonus granted from Aiming." +
            "When a character fires a single shot from a single Basic weapon with the Accurate quality while benefitting from the Aim action, the attack inflicts an " +
            "additional 1d10 damage for every two degrees of success beyond the first (to a maximum of an extra 2d10). These extra d10s cannot generate Righteous Fury.";
        private static readonly string balancedDiscription = "Carefully weighted, the weapon moves naturally with the user, making his parries more successful." +
            "Balanced weapons grant a +10 bonus to Weapon Skill tests made to Parry.Even if the wielder is using multiple Balanced weapons, he only gains the bonus once.";
        private static readonly string blastDiscription = "Attacks from this weapon explode on impact, hurling debris and shrapnel in all directions.When working out a hit " +
            "from a Blast weapon, anyone within the weapon’s blast radius in metres, indicated by the number in parentheses, is also suffers a single hit from the weapon. " +
            "Roll damage once and apply it to each character affected by the blast.A Blast weapon also scatters when the user fails his Ballistic Skill test when firing it.";
        private static readonly string concussiveDiscription = "Concussive weapons strike with a powerful impact strong enough to temporarily knock a foe senseless." +
            "When a target is struck by a Concussive weapon, he must take a Toughness test with a penalty equal to 10 times the number in parentheses (X). " +
            "For example, a weapon with Concussive (2) would impose a –20 on this Toughness test and Concussive (0) would cause a test with no penalty. " +
            "If he fails, the target is Stunned for 1 round per degree of failure. If the attack also inflicted an amount of damage greater than the target’s Strength bonus," +
            " the target is knocked Prone.";
        private static readonly string corrosiveDiscription = "These weapons utilise highly caustic acids which cause damage to both the target and his equipment." +
            "If a target is struck by an attack from a Corrosive weapon, the Armour points of any armour worn by the target in that location are reduced by 1d10 points." +
            "If the Armour points of the armour are reduced below 0 or the target is not wearing any armour in that location, the excess amount of Armour point damage " +
            "(or the whole amount if the target is wearing no armour in that location) is dealt to the target.This excess damage is not reduced by Toughness. " +
            "A target’s armour can be reduced multiple times by the effects of a Corrosive weapon, and the Armour point damage is cumulative.A suit of armour can be " +
            "repaired with a successful Challenging (+0) Tech-Use test, and an Acolyte who possesses the Armour Monger talent can repair the armour while making use of that talent.";
        private static readonly string cripplingDiscription = "Designed for cruelty and viciousness, crippling devices are favourites amongst those who prize pain and suffering." +
            "When a target suffers at least one wound from this weapon, he is considered Crippled for the remainder of the encounter or until healed of all damage." +
            "If a Crippled character takes more than a Half Action on his turn, he suffers Rending damage equal to the number in parentheses (X) to the Hit Location that " +
            "suffered the original damage. This damage is not reduced by Armour or Toughness.";
        private static readonly string defensiveDiscription = "A Defensive weapon, such as a shield, is intended to be used to block attacks and is awkward when used to attack." +
            "A weapon with this quality grants a +15 bonus to tests made when used to Parry, but imposes a –10 penalty on tests to make attacks with it.";
        private static readonly string fellingDiscription = "Felling weapons make a mockery of even the most resilient enemies, cutting dense tissue and bone with ease." +
            "When calculating damage from Felling weapons, reduce the target’s Unnatural Toughness bonus by the number in parentheses(X). " +
            "Felling only reduces Unnatural Toughness, not the target’s base Toughness bonus, and does not persist once the damage has been calculated.";
        private static readonly string flameDiscription = "Using materials such as promethium and incendiary powders, this weapon ignites with primordial fire." +
            "Whenever a target is struck by an attack with this quality (even if he suffers no damage), he must make an Agility test or be set on fire. " +
            "If the target of the Flame attack is a vehicle, the pilot must make the appropriate Operate skill test with a bonus equal to the vehicle’s " +
            "Armour value on the facing hit by the Flame attack.If the pilot fails, the vehicle immediately catches fire.";
        private static readonly string flexibleDiscription = "These are often made of linked metal, rope, or other non-rigid materials that deny defensive counters." +
            "They cannot be Parried, though they themselves can be used to Parry an opponent’s weapon.";
        private static readonly string forceDiscription = "A force weapon relies on the user’s mind to unlock its true potential, suddenly turning a sword or staff into " +
            "a device burning with eldritch energies able to reave tanks. Force weapons count as Best craftsmanship Mono variants of the equivalent Low-Tech weapon." +
            "In the hands of a psyker, the weapon also deals bonus damage and gains bonus penetration equal to the psyker’s base psy rating " +
            "(so a psy rating 3 would grant +3 damage and +3 penetration), and the damage type changes to Energy.In addition, whenever a psyker damages an opponent, " +
            "he may take a Focus Power action(Opposed with Willpower) as a Half Action.If he wins the test, then for every degree of success, the Force weapon’s wielder " +
            "deals an additional 1d10 Energy damage, ignoring Armour and Toughness bonus.Psykers always use their base psy rating when determining psychic strength for this test, " +
            "and cannot generate Psychic Phenomena on this test. Force weapons cannot be destroyed by weapons with the Power Field quality.";
        private static readonly string gravitonDiscription = "Graviton weapons alter the target’s local gravity field, transforming protective armour into crushing force." +
            "When a weapon with the Graviton quality hits a target, it inflicts additional damage equal to the target’s Armour points on the struck location." +
            "If the target is a vehicle or cover, it instead inflicts additional damage equal to the Armour points of the facing that the attack struck." +
            "Vehicles that suffer Critical damage from Graviton weapons always roll on the Motive Systems Critical Effects table, no matter what location was actually hit.";
        private static readonly string hallucinogenicDiscription = "Where most weapons seek to harm the body, those with this quality seek to damage the mind with " +
            "exotic chemicals and neurotoxic drugs.When a creature is struck by a weapon with the Hallucinogenic quality, it must make a Toughness test with a penalty " +
            "equal to 10 times the number in parentheses (X) or suffer a temporary delusion and roll 1d10 on Table Hallucinogenic Effects. Respirators and sealed armour " +
            "provide a +20 bonus to this test.The effects last for 1 round, plus 1 additional round for every degree of failure." +
            "\n1 Bugsbugsbugsbugs! The character drops to the floor, flailing and screaming as he tries to claw off imaginary insects devouring his skin and flesh." +
            "The character gains the Prone and Stunned conditions. " +
            "\n2 My hands...! The character believes his hands have turned into slimy tentacles, or perhaps the flesh has begun to strip off the bone in bloody lumps. " +
            "Regardless of the particulars, the character drops everything he is carrying and spends the duration staring at his hands and screaming.The character is Stunned. " +
            "\n3 They're coming through the walls! The character sees gruesome aliens bursting through the walls/ceiling/floor/bushes and opens fire. " +
            "The character must spend each turn firing at a random piece of terrain within his line of sight. Any creatures caught in the line of fire are subject to attacks as normal." +
            "Each round, choose a new target at random(use the Scatter Diagram) to determine which direction that is, with a \"7\" meaning he shoots the ground, and a \"10\" meaning" +
            " he fires wildly into the air. " +
            "\n4 Nobody can see me! The character believes he is invisible and wanders aimlessly, making faces at those around him." +
            "He waddles about in random directions each round(use the Scatter Diagram on page 230), using a Full Action to move.The character retains his Reactions. " +
            "\n5 I can fly! The sky looks so big and inviting, the character flaps his arms trying to imitate a pterasquirrel.He might do nothing but jump up and down on the spot." +
            "If he is standing above ground level, he may throw himself off in a random direction, with the usual consequences for falling—appalling injury or death being the likely outcomes." +
            "\n6 They've got it in for me...! The character is overcome with paranoia, believing even his own comrades are out to get him. On the character's turn, " +
            "he must move to a position of cover, getting out of line of sight from any other characters. He remains hidden until the effect ends, moving to new cover as needed " +
            "to stay as hidden as possible. " +
            "\n7 They got me! The character believes that the gas is toxic and collapses to the floor as if dead; he counts as being Helpless. " +
            "Other characters who sees him \"die\" must pass a Challenging (+0) Intelligence test; should they fail then they also think the character is dead. " +
            "\n8 I'll take you all on! The character is filled with a burning rage and a desire for violence. The character becomes Frenzied for the duration of the effects, " +
            "and must attack the closest opponent. " +
            "\n9 I'm only little! The character believes he has shrunk to half his normal size and everything else is big and frightening now." +
            " All other characters count as having the Fear (3) trait to the character." +
            "\n10 The worms! The character desperately tries to remove a massive fanged worm he thinks is slowly winding its way up his leg." +
            "If holding a gun, he shoots himself with it or, if not, he hits himself in the leg with whatever melee weapon he is holding." +
            "If the character is currently holding no weapon, he draws a random weapon from those he carries and attacks himself with it. " +
            "Randomly determine which leg the character believes to be trapped by the worm.The attack automatically inflicts a single hit with 1d5 degrees of success that deals damage normally.";
        private static readonly string haywireDiscription = "A foul affront to the Omnissiah in the eyes of many Tech-Priests, devices with this quality seek to cripple " +
            "machine spirits and make metal as weak as flesh.Everything within the field’s radius, indicated by the number in parentheses, is affected; Haywire(3), for example, w" +
            "ould affect an area with a three metre radius.Roll 1d10 on Table Haywire Field Effects(adding any modifiers from the weapon) to determine the strength of the effect." +
            "As the field slowly dissipates, the strength lessens one step in severity each round until it becomes Insignificant" +
            "(i.e., a result of Major Disruption would become Minor Disruption the following round and then cease to have an effect the round after that). " +
            "Additional Haywire attacks in the same area do not stack but instead create a new effect that is either ignored if lower than the current effect or replaces the old one if higher." +
            "\n1–2 Insignificant:Though some machine spirits are unsettled, there is no noticeable effect on nearby technology. " +
            "\n3–4 Minor Disruption: All actions utilising powered technology, including firing ranged weapons without the Primitive quality, " +
            "Tech-Use tests, and any physical actions attempted while wearing power armour or employing cybernetics, suffer a –10 penalty." +
            "The base movement of anyone in power armour is reduced by 1. " +
            "\n5–6 Major Disruption: All actions utilising technology, including firing ranged weapons without the Primitive quality, " +
            "Tech-Use tests, and any physical actions attempted while wearing power armour or employing cybernetics, suffer a –20 penalty." +
            "The base movement of anyone in power armour is reduced by 3. Melee weapons with technological components function as a Primitive weapon of the analogous type. " +
            "\n7–8 Dead Zone: Technology within the affected  area completely ceases to function.Power armour becomes unpowered, reducing the wearer’s move to 1. " +
            "Characters with cybernetic replacements to any internal organ(s) suffer one level of Fatigue each round they remain in the Dead Zone." +
            "Melee weapons with technological components(i.e.power swords) function as a Low-Tech weapon of their type. " +
            "\n9–10 Prolonged Dead Zone: As Dead Zone, but lasting  for 1d5 rounds before lessening to a Major Disruption(and then dissipating as normal).";
        private static readonly string inaccurateDiscription = "Poorly manufactured with often shoddy construction, inaccurate weapons are common in underhive " +
            "gangs and heretical cults.A character gains no benefit from the Aim action when attacking with a weapon with this quality.";
        private static readonly string inderectDiscription = "Many weapons are designed to be fired in high arcs at unseen foes or thrown from protective cover at charging enemies." +
            "Indirect weapons do not require line of sight to their target, but the attacker must still be aware of his intended target’s location, either through last known position, " +
            "use of a spotter, or other means. When making any ranged attack action(Standard Attack, Semi-Auto Burst, or Full Auto Burst) with an Indirect weapon, " +
            "the attack does not have to target a location in line of sight of the active player, but is made at a –10 penalty and requires a Full Action " +
            "instead of the normal Half Action.The GM makes the final determination on whether the character is aware of his target’s location, and can add penalties " +
            "to this ranged attack based on how aware the character is of his target. For each hit the ranged attack inflicts, roll once on the Scatter Diagram. " +
            "The hit instead strikes the ground at a location a number of metres away from the intended target, in the direction rolled on the Scatter Diagram, equal " +
            "to 1d10 minus the firer’s Ballistic Skill bonus(to a minimum of zero). If the ranged attack fails, or if the Semi-Auto Burst or Full Auto Burst actions fail " +
            "to achieve the maximum potential hits, the remaining missed hits—up to the maximum potential hits for the rate of fire used in the attack—are still fired, " +
            "but miss their target. For each missed hit, roll once on the Scatter Diagram. The hit instead strikes the ground at a location Xd10 metres away from the " +
            "intended target in the direction rolled on the Scatter Diagram, where X is equal to the number in parentheses (X).";
        private static readonly string lanceDiscription = "Lance weapons focus devastating energy, piercing armour with ease.Weapons with this quality have a variable" +
            " penetration value that is dependent on the accuracy of each shot.When a target is hit by a weapon with the Lance quality, increase the weapon’s penetration " +
            "value by its base value once for each degree of success the attacker achieves.For example, if a Lance weapon had a base penetration value of 5 and hit with " +
            "three degrees of success(adding 3x5= 15), the total penetration for the attack would be 20.";
        private static readonly string maximalDiscription = "Many energy weapons have multiple settings, allowing the user greater tactical flexibility in combat." +
            "As a Free Action, this weapon can be switched between two modes: Standard(which uses the normal weapon profile) and Maximal.When the weapon is fired on Maximal, " +
            "it adds 10 metres to its range, 1d10 to its damage, and +2 to its penetration.If it has the Blast quality, then the value of this quality is increased by 2 " +
            "(i.e., Blast[3] becomes Blast [5]). The weapon also uses three times the normal amount of ammunition per shot and gains the Recharge quality.";
        private static readonly string meltaDiscription = "These weapons rely on intense heat to negate protective armour, turning even the thickest to steaming liquid." +
            "This weapon doubles its penetration when firing at Short range or closer.";
        private static readonly string overheatsDiscription = "Through inefficient shielding, defective venting, or simply inherent design, the weapon often becomes " +
            "overcome with the heat of its ammunition or firing methods.On an attack roll of 91 or higher, this weapon overheats. " +
            "The wielder suffers Energy damage equal to the weapon’s damage with a penetration of 0 to an arm location (the arm holding the weapon if the weapon " +
            "was fired one-handed, or a random arm if the weapon was fired with two hands). The wielder may choose to avoid taking the damage by dropping the weapon as a " +
            "Free Action.A weapon that overheats must spend the round afterwards cooling down, and cannot be fired again until the second round after overheating." +
            "A weapon with this quality does not jam, and any effect that would cause the weapon to jam instead causes the weapon to overheat.";
        private static readonly string powerFieldDiscription = "Power fields form a cloud of disruptive energy, allowing a weapon to strike with terrible force." +
            "When the character successfully uses this weapon to Parry an attack made with a weapon that lacks this quality, roll 1d100; on a result of 26 or higher," +
            " he destroys the attacker’s weapon. Weapons with the Warp Weapon or Force quality, and Natural Weapons, are immune to this effect.";
        private static readonly string primitiveDiscription = "Crude and basic in design, these kinds of weapons, while still deadly, are less effective against modern armour." +
            "When rolling for damage with these weapons, any die result greater than the number in parentheses (X) counts as that number instead.For example, a weapon with Primitive (7)" +
            " would count all damage rolls of 8, 9 or 10 as 7. These weapons can still generate Righteous Fury as normal, on a damage roll of 10.";
        private static readonly string provenDiscription = "These weapons always inflict massive trauma. When rolling for damage with these weapons, " +
            "any die result lower than the number in parentheses(X) counts as that number instead.Thus, a Proven (3) weapon would treat any die result of 1 or 2 as a 3 " +
            "for the purposes of calculating damage.";
        private static readonly string razorSharpDiscription = "Certain weapons or ammunition types have the ability to slice right through armour if they hit just right." +
            "If the wielder scores three or more degrees of success when attacking with this weapon, the weapon’s penetration value is doubled when resolving any hits from that attack.";
        private static readonly string rechargeDiscription = "Some weapons lack continuous power or ammunition supplies, and each strike drains capacitors or empties fuel reservoirs." +
            "When a weapon with this quality is used to make an attack, that weapon cannot be used to attack again until the end of the next round" +
            "(in effect, it can only be used once every other round).";
        private static readonly string reliableDiscription = "Using ancient and well-consecrated designs, reliable weapons bring glory to the Omnissiah with each attack." +
            "Reliable weapons only jam on an unmodified result of 100. Reliable weapons with the Spray quality, or which do not make hit rolls, never jam.";
        private static readonly string sanctifiedDiscription = "These weapons are blessed against the forces of Chaos. Any damage inflicted by a Sanctified weapon " +
            "counts as Holy damage, which can have unique effects against some terrible Daemons and other denizens of the Warp.";
        private static readonly string scatterDiscription = "The standard ammunition of these weapons spreads out when fired, ripping apart targets at close range " +
            "but inflicting considerably less harm from afar.When fired at Point Blank range, this weapon gains +10 to hit and deals +3 damage." +
            "When fired at Short range, it gains +10 to hit.At any longer ranges, it suffers –3 damage.";
        private static readonly string shokingDiscription = "Shocking weapons can incapacitate their opponents with a powerful surge of energy or other non-lethal means." +
            "A target that takes at least 1 point of damage from a Shocking weapon (after Armour and Toughness bonus) must make a Challenging(+0) Toughness test." +
            "If he fails, he suffers 1 level of Fatigue and is Stunned for a number of rounds equal to half of his degrees of failure (rounding up).";
        private static readonly string smokeDiscription = "Rather than inflicting damage, these weapons throw up dense clouds to create cover." +
            "When a hit is scored from a weapon with this quality, it creates a smokescreen at the point of impact with a radius in metres equal to the number in parentheses (X). " +
            "This screen lasts for 1d10+10 rounds, or a shorter time in adverse weather conditions.";
        private static readonly string snareDiscription = "These ensnaring devices use masses of fibrous webbing, adhesive fluids, and other entangling materials to bring an enemy down." +
            " When a target is struck by a weapon with this quality, it must make an Agility test with a penalty equal ten times the number in parentheses (X) or be Immobilised. " +
            "For example, a weapon with Snare (1) would impose a –10 penalty on this test. An Immobilised target can attempt no actions other than trying to escape the bonds. " +
            "As a Full Action, he can make a Challenging (+0) Strength or Agility test, with a penalty equal to ten times the number in parentheses(X). " +
            "If he succeeds, he bursts free or wriggles out. The target is considered Helpless until he escapes.";
        private static readonly string sprayDiscription = "Spray weapons use large area-effect shots to strike more foes, sacrificing range for wider coverage." +
            "Unlike other weapons, they have just one range and, when fired, hit all those in their area of effect. The wielder does not need to test Ballistic Skill; " +
            "all creatures in the weapon’s path(a cone-shaped area extending in a 30° arc from the firer out to the weapon’s range) must make a Challenging(+0) Agility test " +
            "or suffer one hit from the weapon.If the wielder does not possess the appropriate Weapon Training talent, targets gain a +20 bonus on the test; " +
            "this rises to +30 if the weapon is Heavy and the wielder is not braced.Cover does not protect from Spray attacks unless it completely conceals a target. " +
            "Because there is no attack roll, they are always considered to strike the Body location.They jam if the firer rolls a 9 on any damage dice (before any modifiers are applied)." +
            " Due to the inaccurate nature of their design, they cannot be used to make Called Shot actions.";
        private static readonly string stormDiscription = "Firing with a hail of shots, these weapons strike so  rapidly that enemies are filled with metal in an instant." +
            " This quality doubles the number of hits the weapon inflicts on the target and the amount of ammunition expended. For example, when firing a weapon with " +
            "the Storm quality in fully automatic mode, each degree of success yields two additional hits (up to the weapon’s firing rate, as normal).";
        private static readonly string tearingDiscription = "These weapons call on spinning chainblades, serrated claws, burrowing projectiles, and other vicious means to rip apart targets." +
            " These weapons roll one extra die for damage, and the lowest result is discarded.";
        private static readonly string toxicDiscription = "Filled with malignant chemicals and fast acting poisons, toxic weapons bring down enemies through virulence and sickness." +
            " At the end of his turn, if a character has suffered damage (after Armour and Toughness bonus) in the last round from a weapon with this quality, " +
            "he must make a Toughness test with a penalty equal to 10 times the number in parentheses (X) or suffer 1d10 additional damage" +
            " (of the same type as the first weapon with this quality to damage him that round). For example, a weapon with Toxic (4) imposes a –40 on the tests to resist its effects." +
            "Some weapons or creatures carry additional effects with their toxins or inflict more damage, as indicated in their individual descriptions.";
        private static readonly string twinLinkedDiscription = "A Twin-Linked weapon represents two identical weapons connected together and set to fire at the same time," +
            " increasing the chances of scoring a hit by blasting more shots at the target.A weapon with this quality gains a +20 to hit when fired and uses twice as much ammunition. " +
            "In addition, the weapon scores one additional hit if the attack roll succeeds by two or more degrees of success.When emptied, the weapon’s reload time is doubled.";
        private static readonly string unbalancedDiscription = "Cumbersome, awkward to use, and often heavy, these are usually powerful offensively, " +
            "but suffer in defence actions such as parrying. These weapons cannot be used to make Lighting Attack actions, and impose a –10 penalty when used to Parry.";
        private static readonly string unreliableDiscription = "A clear affront to the Omnissiah, Unreliable devices represent poorly designed, badly manufactured, " +
            "or improperly consecrated weapons that are perhaps better than no weapon at all, but not by a great measure.An Unreliable weapon suffers a jam on a roll of 91 or higher, " +
            "even if fired on Semi- or Full Auto.";
        private static readonly string unwieldlyDiscription = "Huge and often top-heavy, Unwieldy weapons are too awkward to be used with finesse." +
            "They cannot be used to Parry or make Lightning Attack actions.";
        private static readonly string vengefulDiscription = "These weapons seemingly embody the Emperor’s wrath, and eagerly strike down any who would stand against His servants." +
            "When attacking with this weapon, the attacker triggers Righteous Fury on any damage die result with a value of X or higher (before any modifiers are applied).";
        private static readonly string twoHandedDiscription = "Weapon require two hand to use";
        #endregion

        /// <summary>
        /// Collection of special qualities of weapons
        /// </summary>
        public static ObservableCollection<WeaponSpecialQualitie> WeaponSpecialQualities = new ObservableCollection<WeaponSpecialQualitie>
        {
            new WeaponSpecialQualitie(WeaponQualitieName.Accurate.ToString(), accurateDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Balanced.ToString(), balancedDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Blast.ToString(), blastDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Concussive.ToString(), concussiveDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Corrosive.ToString(), corrosiveDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Crippling.ToString(), cripplingDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Defensive.ToString(), defensiveDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Felling.ToString(), fellingDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Flame.ToString(), flameDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Flexible.ToString(), flexibleDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Force.ToString(), forceDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Graviton.ToString(), gravitonDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Hallucinogenic.ToString(), hallucinogenicDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Haywire.ToString(), haywireDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Inaccurate.ToString(), inaccurateDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Indirect.ToString(), inderectDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Lance.ToString(), lanceDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Maximal.ToString(), maximalDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Melta.ToString(), meltaDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Overheats.ToString(), overheatsDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Power_Field.ToString(), powerFieldDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Primitive.ToString(), primitiveDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Proven.ToString(), provenDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Razor_Sharp.ToString(), razorSharpDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Recharge.ToString(), rechargeDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Reliable.ToString(), reliableDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Sanctified.ToString(), sanctifiedDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Scatter.ToString(), scatterDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Shoking.ToString(), shokingDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Smoke.ToString(), smokeDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Snare.ToString(), snareDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Spray.ToString(), sprayDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Storm.ToString(), stormDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Tearing.ToString(), tearingDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Toxic.ToString(), toxicDiscription, true),
            new WeaponSpecialQualitie(WeaponQualitieName.Twin_Linked.ToString(), twinLinkedDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Two_Handed.ToString(), twoHandedDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Unbalanced.ToString(), unbalancedDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Unreliable.ToString(), unreliableDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Unwieldly.ToString(), unwieldlyDiscription),
            new WeaponSpecialQualitie(WeaponQualitieName.Vengeful.ToString(), vengefulDiscription, true)
        };

        
    }
}
