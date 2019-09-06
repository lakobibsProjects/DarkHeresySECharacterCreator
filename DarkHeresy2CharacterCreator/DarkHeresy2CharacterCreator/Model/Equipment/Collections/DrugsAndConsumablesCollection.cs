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
    /// Instaniate a observableCollection of drugs and consumables
    /// </summary>
    public static class DrugsAndConsumablesCollection
    {
        /// <summary>
        /// Collection of drugs and consumables
        /// </summary>
        public static ObservableCollection<IItem> DrugsAndConsumables = new ObservableCollection<IItem>
        {
            new Item("Amasec", Availability.Average, 1, amasecDiscription),
            new Item("Desoleum Fungus", Availability.Scarce, 0, desoleumFungusDiscription),
            new Item("De-Tox", Availability.Rare, 0, deToxDiscription),
            new Item("Frenzon", Availability.Very_Rare, 0, frenzonDiscription),
            new Item("Lho-Sticks", Availability.Common, 0, lhoSticksDiscription),
            new Item("Obscura", Availability.Rare, 0, obscuraDiscription),
            new Item("Ration Pack", Availability.Plentiful, 2, rationPackDiscription),
            new Item("Recaf", Availability.Abundant, 0, recafDiscription),
            new Item("Sacred Ungents", Availability.Very_Rare, 0, sacredUngentsDiscription),
            new Item("Slaught", Availability.Scarce, 0, slaughtDiscription),
            new Item("Spook", Availability.Rare, 0, spookDiscription),
            new Item("Stimm", Availability.Average, 0, stimmDiscription),
            new Item("Tranq", Availability.Abundant, 1, tranqDiscription)
        };

        #region Discriptions
        private static readonly string amasecDiscription = "This refreshment is made from distilled wine or other fermented beverages, " +
            "and is popular in many regions of the Imperium.It is usually a fine-quality product, with some well-aged vintages renowned across the sector for bouquet and flavour.";
        private static readonly string desoleumFungusDiscription = "A hallucinogen made from unusual narcotic mushrooms that grow in ancient aquifers deep in Hive Desoleum’s " +
            "lower reaches, this drug has a disorienting, intoxicating effect that causes users to stumble about despite retaining the full spectrum of their senses. " +
            "Depraved gangers particularly enjoy dosing themselves and then instigating extended gunfights, whirling about drunkenly and watching the havoc of their wayward shots. " +
            "A dose of lasts 1d10 rounds, and the user immediately suffers 1 Fatigue as his body spins wildly.A character under the effects of the drug can take advantage " +
            "of the skewed perspective this gives him: once during this time, he may invert the result of any 1d100 roll, exchanging the tens digit for the ones digit " +
            "(turning a 73 into a 37 or a 91 into a 19, etc.).";
        private static readonly string deToxDiscription = "De-tox can negate most of the dangerous effects of other drugs or toxins.A dose immediately ends the effects, " +
            "both positive and negative, for any chemicals the subject has inhaled, ingested, or injected, unless the item specifically states de-tox cannot work against " +
            "it.Its use is extremely unpleasant, however, with common side-effects so extreme (excessive vomiting and diarrhoea being the mildest) that many would rather " +
            "abide their current woes. Using de-tox, however, is both painful and debilitating, and can cause several unpleasant side effects such as vomiting, nose bleeds, " +
            "and a great voiding of the bowels.Upon taking this drug, a character is Stunned for a number of rounds equal to 1d10 minus his Toughness bonus. " +
            "A result of 0 or less means that the character suffers no ill effects.";
        private static readonly string frenzonDiscription = "Frenzon is a term for a number of combat drugs used in conscript and assault forces, especially in penal legions." +
            "A dose creates a fanatical and fearless state, leaving the user ready to fight any foe, no matter how suicidal it may seem. " +
            "A character using frenzon gains the Frenzy talent and immediately becomes Frenzied.These effects last for the duration of the drug; " +
            "a single dose of which lasts for 1d10 minutes.Frenzon is Addictive.";
        private static readonly string lhoSticksDiscription = "A mild narcotic, each stick contains dried and cured plant leaves that release a scented, " +
            "stimulating smoke when ignited and inhaled through a cheap tube that burns away with the drug.As the leaves vary with the planet, " +
            "lho-sticks can vary from world to world as well, often making them useful trade items.";
        private static readonly string obscuraDiscription = "Though often illegal, obscura is popular in many fighting units where combatants are eager " +
            "for respite from constant battle, as well as among civilians seeking relief from the drudgeries of harsh life.Obscura-users enter a dream-like state " +
            "for 1d5 hours (if required to engage in combat, consider them under the effects of a hallucinogen grenade). For 1d10 hours after the effects wear off, " +
            "they enter a deep depression, unless another dose of obscura is taken.Obscura is Addictive.";
        private static readonly string rationPackDiscription = "These small pouches contain concentrated or dehydrated foodstuffs suitable for one complete meal, " +
            "and also include vitamin supplements, water puri-tabs, a protein bar, and heating pellets. Well-made packs are actually quite palatable, but even a " +
            "master Ratling chef would have difficulty with the poor ingredients used in cheaper packs. Besides the benefits of holding off starvation, " +
            "ration packs can help to keep an Acolyte effective in the field. Eating one or more ration packs (or other, comparable meals) during a period " +
            "of rest of at least two hours removes one additional level of Fatigue.";
        private static readonly string recafDiscription = "These common beverages offer a mild stimulant effect as well as pleasing taste.Hot recaf starts many days across the sector, " +
            "from Imperial Guardsmen fighting on combat lines against the xenos threat to Acolytes striving to stay alert on an all-night vigil near a suspected cult hideout. " +
            "Consuming recaf helps to hone senses dulled by exhaustion, and a dose removes one level of Fatigue from the character. The cumulative penalty to Toughness tests " +
            "taken for consuming additional doses of recaf is –20 instead of the normal –10.";
        private static readonly string sacredUngentsDiscription = "Holy lubricating oils that have received the blessings of the Omnissiah, these liquids are highly " +
            "sought after for their calming effect on recalcitrant machine spirits.If applied to a weapon— which requires a Full Action—the weapon becomes immune " +
            "to jamming for a number of shots equal to its clip size.If the unguent is applied to an already jammed weapon, the jam immediately clears, but there is no further effect.";
        private static readonly string slaughtDiscription = "This combat drug (also known as onslaught) is frequently taken to heighten awareness and improve reaction time." +
            "It literally speeds up the user, but causes neural and physiological damage with prolonged application. Taking a dose increases the user’s Agility bonus and " +
            "Perception bonus by 3 for 2d10 minutes.Note this does not increase the actual characteristic values.When the drug runs its course, the user must pass a " +
            "Challenging (+0) Toughness test or suffer a –20 penalty to Agility tests and Perception tests for 1d5 hours.Slaught is Addictive.";
        private static readonly string spookDiscription = "A highly-proscribed drug, spook creates and augments that most hazardous of effects: psychic abilities." +
            "Even the briefest of connections to the Warp and the Ruinous Powers that dwell within can allow daemonic incursions or worse, but in desperate instances, " +
            "even these horrific effects are brushed aside. If a character without any psy rating takes a dose of this drug, he must successfully make a Challenging (+0) " +
            "Willpower test or gain 1d5 Insanity points due to his mind being filled with terrifying visions of the Warp.If he succeeds, the user gains a psychic " +
            "power from Spook Effects. The power lasts for 1d5 hours, and the user makes all Focus Power tests during this time as if he had a psy rating of 1. " +
            "If a character with a psy rating of 1 or more uses spook, he must make a Challenging (+0) Willpower test. If he fails, he gain 1 Insanity Point and the" +
            " drug has no further effects. If he passes, he adds 1 to his psy rating for the next hour. However, add +25 to rolls he makes on  Psychic Phenomena." +
            " Spook is Addictive, and depending on the setting, its mere possession can incur intense and even lethal punishment from local authorities." +
            "\n01-04 Assail " +
            "\n05-08 Crush " +
            "\n09-12 Dominate " +
            "\n13-16 Endurance " +
            "\n17-20 Enfeeble " +
            "\n21-24 Fire Shield " +
            "\n25-28 Flame Breath " +
            "\n29-32 Foreboding " +
            "\n33-36 Hallucination " +
            "\n37-40 Invigourate " +
            "\n41-44 Misfortune " +
            "\n45-48 Objuration Mechanicum " +
            "\n49-52 Perfect Timing " +
            "\n53-56 Prescience " +
            "\n57-60 Psychic Shriek  " +
            "\n61-64 Scrier's Gaze " +
            "\n65-68 Shockwave " +
            "\n69-72 Smite " +
            "\n73-76 Spontaneous Combustion " +
            "\n77-80 Telekine Dome " +
            "\n81-84 Vortex of Doom " +
            "\n85-88 Roll twice, gaining both powers. " +
            "\n89-92 Pick any one power. " +
            "\n93-96 Gain 1 Insanity point and roll again. " +
            "\n97-100 Gain 3 Insanity points.";
        private static readonly string stimmDiscription = "A dose of stimm is enough to energise the weary and mask pain with short-term vitality, " +
            "often enough to finally bring a protracted combat to a successful conclusion.Each dose lasts for 3d10 rounds. During this time, " +
            "a character ignores any negative effects to his characteristics from damage, Critical damage, and Fatigue, and cannot be Stunned. " +
            "When the stimm wears off, the character suffers a –20 penalty to Strength, Toughness, and Agility tests for one hour and gains one level of Fatigue. Stimm is Addictive.";
        private static readonly string tranqDiscription = "The drug tranq covers an array of artificial, alcoholic chemdistillates brewed by underhive scum, criminals, " +
            "and even Guardsmen desperate for respite from their wretched lots.It numbs the body and mind, which provides a very different feeling than being drunk on amasec, " +
            "rotgut, or other spirits.Though similar in the end result, the effects of tranq are unpleasant, depressive, and require an acquired taste.";
        #endregion
    }
}
