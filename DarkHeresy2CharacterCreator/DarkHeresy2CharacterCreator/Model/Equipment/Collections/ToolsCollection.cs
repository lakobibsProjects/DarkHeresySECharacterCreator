using DarkHeresy2CharacterCreator.Model.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Equipment.Collections
{
    public static class ToolsCollection
    {
        public static ObservableCollection<IItem> Tools = new ObservableCollection<IItem>
        {
            new Item("Auspex/Scanner", Availability.Scarce, 0.5, auspexScannecDiscription),
            new Item("Auto Quill", Availability.Scarce, 0, autoQuillDiscription),
            new Item("Clip/Drop Harness", Availability.Common, 2, clipDropHarnessDiscription),
            new Item("Combi-Tool", Availability.Rare, 1, combiToolDiscription),
            new Item("Comm Leech", Availability.Very_Rare, 1, commLeechDiscription),
            new Item("Dataslate", Availability.Common, 0.5, dataslateDiscription),
            new Item("Demolition Kit", Availability.Very_Rare, 4, demolitionKitDiscription),
            new Item("Diagnostor", Availability.Rare, 4, diagnostorDiscription),
            new Item("Disguise Kit", Availability.Very_Rare, 2, disguiseKitDiscription),
            new Item("Excruciator Kit", Availability.Very_Rare, 2, excruciatorKitDiscription),
            new Item("Field Suture", Availability.Average, 0.5, fieldSutureDiscription),
            new Item("Glow Globe/Stablight", Availability.Abundant, 0.5, glowGlobeStablightDiscription),
            new Item("Gapnel and Line", Availability.Common, 2, grapnelAndLineDiscription),
            new Item("Grv Chute", Availability.Rare, 15, gravChuteDiscription),
            new Item("Hand-Held Targeter", Availability.Scarce, 0.5, handHeldTargeterDiscription),
            new Item("Inhaler/Injector", Availability.Common, 0.5, inhalerInjectorDiscription),
            new Item("Lascutter", Availability.Average, 4, lascutterDiscription),
            new Item("Laud Hailer", Availability.Scarce, 4, laudHailerDiscription),
            new Item("Magboots", Availability.Rare, 2, magbootsDiscription),
            new Item("Magnoculars", Availability.Average, 0.5, magnocularsDiscription),
            new Item("Manacles", Availability.Plentiful, 1, ManaclesDiscription),
            new Item("Medi Kit", Availability.Common, 2, mediKitDiscription),
            new Item("Micro-bead", Availability.Average, 0, microBeadDiscription),
            new Item("Monotask Servo-Skull", Availability.Rare, 2, monotaskServoSkullDiscription),
            new Item("Multicompass", Availability.Near_Unique, 4, multicompassDiscription),
            new Item("Miltikey", Availability.Scarce, 0, multikeyDiscription),
            new Item("Null Rod", Availability.Near_Unique, 1, nullRodDiscription),
            new Item("Pict Recorder", Availability.Average, 1, pictRecorderDiscription),
            new Item("Psy Focus", Availability.Average, 0, psyFocusDiscription),
            new Item("Regicide Set", Availability.Plentiful, 1, regicideSetDiscription),
            new Item("Screamer", Availability.Scarce, 2, screamerDiscription),
            new Item("Signal Jammer", Availability.Rare, 2, signalJammerDiscription),
            new Item("Static Generator", Availability.Very_Rare, 3, staticGeneratorDiscription),
            new Item("Stummer", Availability.Average, 2, stummerDiscription),
            new Item("Vox-Caster", Availability.Scarce, 4, voxCasterDiscription),
            new Item("Writing Kit", Availability.Plentiful, 2, writingKitDiscription)
        };

        #region Discription
        private static readonly string auspexScannecDiscription = "These standard Imperial detection devices are used to reveal energy emissions, motion, " +
            "life-signs, and other information.A character using an auspex gains a +20 bonus to Awareness tests.Once per round, as a Free Action, " +
            "a character with one may make a Tech-Use test to spot things not normally visible to human senses, such as invisible gases, nearby signs of life, " +
            "non-visible radiation, or other things as appropriate.The standard range is 50m, though walls more than 50cm thick and certain shielding materials can block a scanner. " +
            "Good craftsmanship models increase thebonus to +30, but Poor models an only penetrate 20cm of material.";
        private static readonly string autoQuillDiscription = "Often elaborate devices of ink-stained brass and vat-grown or artificial quills, these devices allow " +
            "a user to copy text or transcribe speech with impressive speed and accuracy.Many scribes carry portable units, suitable for recording interrogation " +
            "sessions or xenos translations.A character with a relevant Trade skill can use it to gain a +10 to his tests involving this skill when recording data.";
        private static readonly string clipDropHarnessDiscription = "A simple (but robust) spooled safety line with a magnetic or hooked clasp at the end, " +
            "these tools attach to the user’s belt or shoulder straps.When deployed, they allow for relative safety in rappelling down vertical surfaces or " +
            "preventing falls from unsteady rooftops.A character using a clip harness to descend a vertical surface gains a +30 bonus on tests to Climb and cannot fall if he fails." +
            "Common quality harnesses can hold 150kg, while Good quality harnesses can support 200 kg.";
        private static readonly string combiToolDiscription = "Most combi-tools are small, compact devices filled with foldout and extending probes, blades, hooks, " +
            "and socket-plugs.They are ideal for coaxing operation from recalcitrant machinery, repairing damaged devices, and in general bending errant machine spirits" +
            " to the will of the user.A character using a combi-tool gains a +10 bonus to Tech-Use tests.";
        private static readonly string commLeechDiscription = "A somewhat heretical item in the eyes of the Mechanicum, these tap into vox signals or data transmissions." +
            "After making a successful Tech-Use test (with the GM setting the difficulty based on the situation and signal), the user can use it to receive a signal or " +
            "transmission within 1km for a number of minutes equal to his degrees of success.If the character fails by a number of degrees of failure greater than his I" +
            "ntelligence bonus, the sender and receiver of the signal become aware that someone is attempting to tap in.";
        private static readonly string dataslateDiscription = "These devices are common across the Imperium, and are the primary means of storing and " +
            "reading printed text and other forms of data such as pict or audio recordings.Wellcrafted dataslates can also rerecord new information, " +
            "or transmit and receive data from other devices.";
        private static readonly string demolitionKitDiscription = "Some investigations end with explosive results, and these kits are essential for such a conclusion." +
            "They contain the tools for a character to more easily set up sophisticated detonation devices and explosives.Each kit includes the following: " +
            "\n• Five demolition charges: These detonate with the same profile as krak grenades. " +
            "\n• 100 metres of det-cord: This thin rope can be lit with any fire source or detonator, and burns at a rate of 10 seconds per metre, " +
            "useful for setting a delay on an explosive or activating it at a distance. " +
            "\n• Five pressure-release detonators: These can be used to light a det-cord line or trigger explosives directly. " +
            "\nAll of the materials in this kit can be refilled to these quantities without the use of a Requisition test as long as the character is in a location they would be available.";
        private static readonly string diagnostorDiscription = "The diagnostor is a sophisticated medical device used across the galaxy.It can detect and diagnose almost every ailment" +
            " known to the Imperium, and can be incorporated into medical kits, servoskulls, and other dedicated servitors.Any individual trained in medical knowledge " +
            "in the Imperial Guard understands its use. A diagnostor provides +20 to Medicae or Perception tests to determine an ailment; success indicates the proper treatment to be used.";
        private static readonly string disguiseKitDiscription = "Acolytes often conceal their true identity as part of their investigation, either to create new personas" +
            " or impersonate others. These kits contain the following: " +
            "\n• Basic makeup: Grants a +10 bonus to Deceive tests made to visually disguise the character. " +
            "\n• Prosthetic appliances: Allow the character to impersonate individuals with different facial structures. " +
            "\n• Skin dyes: Allow the character to impersonate individuals with different skin colours. " +
            "\n• Vocal augmenter: Grants a +10 bonus to Deceive tests made to impersonate another voice. " +
            "\n• Retina lenses: Allow the character to impersonate individuals with different eye colours. " +
            "\nAll of the materials in this kit can be refilled to these quantities without the use of a Requisition test as long as the character is in a location they would be available.";
        private static readonly string excruciatorKitDiscription = "While all such kits are used in the gathering of information from the unwilling and unrepentant, " +
            "each is as unique as its user.Most contain a wide range of blades, needles, chemicals, drugs, barbed hooks, neural probes, thermal prods, " +
            "and other essential tools needed to extract the truth. Employing an excruciator kit grants the user a +20 bonus to Interrogation tests.";
        private static readonly string fieldSutureDiscription = "Common implements found on battlefields across the Imperium, field sutures are used to " +
            "quickly sew shut wounds to prevent blood loss.They can vary in form, from a simple needle and thread to archaic devices which staple shut the injury." +
            "Field sutures provide a +30 bonus for Medicae tests used to staunch Blood Loss.";
        private static readonly string glowGlobeStablightDiscription = "Just as the Inquisition acts as a light against soul-devouring darkness, so these small portable lamps " +
            "act against the physical darkness of night.Glow-globes are roughly the size of a clenched fist, and can illuminate an area a dozen or so metres in radius, " +
            "while cylindrical stablights can project a narrower, conical beam but at twice that distance.Both last roughly five hours before their  power packs need recharging or replacing.";
        private static readonly string grapnelAndLineDiscription = "A combination of clip-harness and gas-powered pistol, this can fire a hook or magnetic clasp attached to a thin, " +
            "strong wire at an overhead target up to 100m away.Once the grapnel attaches to the desired spot such as a rooftop, a user can manually climb the line or activate " +
            "a powered winch that can lift the user roughly 5m per round.Common sets can hold 150kg, while Good or Best can support 200 kg.";
        private static readonly string gravChuteDiscription = "Used by the Imperial Guard to drop onto the battlefield from the air, grav chutes use anti-grav fields to slow " +
            "a rapid fall into a controlled(and safe) descent, with small attitude jets allowing for extra braking and directional finesse.Unlike jump packs, " +
            "grav chutes are only useful for safe landings and cannot be used for bounding or aerial leaps. If the character passes a Challenging (+0) Agility test or " +
            "Routine(+20) Operate(Aeronautica) test, the grav chute allows for a safe, guided fall from any height; otherwise the character counts as having fallen " +
            "two metres for each degree of failure";
        private static readonly string handHeldTargeterDiscription = "A hand-held targeter is a small device used in most forces of the Imperium." +
            "It is capable of detecting ranges to targets using optical sights for zooming, prediction systems for firing, and so on." +
            "It is commonly used by spotters assisting with artillery fire. An Acolyte with a hand-held targeter may spend a Half Action to grant another character " +
            "+20 bonus to his next Ballistic Skill test when firing a weapon with the Indirect quality.";
        private static readonly string inhalerInjectorDiscription = "Many drugs require a device to administer a dose such as a syringe, spray-injector, or gas flask." +
            "Each can hold one dose of any drug, which a character may administer as a Half Action.";
        private static readonly string lascutterDiscription = "Ideal for slicing open doors and bulkheads, lascutters were originally designed for mining, " +
            "where their short-range, intense cutting beam could chop apart even the toughest rock.Most can cut or weld around 10cm of metal depending on the thickness involved. " +
            "They are large and cumbersome, and so can only be used as a Heavy weapon (acting as a Meltagun without any special weapon qualities) on stationary targets within 2 metres.";
        private static readonly string laudHailerDiscription = "Whether belting orders over the ferocious roar of combat or addressing a crowd of thousands of the faithful, " +
            "Imperial officials often require great volume, and a laud hailer is the perfect tool. Each can amplify normal speech levels such that an entire crowd " +
            "can hear the speaker’s words clearly.";
        private static readonly string magbootsDiscription = "Heavy and bulky, these oversized boots contain electromagnets. They allow the wearer to adhere to " +
            "metallic surfaces such as exterior hull plating, and are often found in voidship emergency lockers.Magboots reduce the character’s Agility bonus by 2, " +
            "but allows him to move normally when in low- or zero-gravity areas, provided there is a suitable metallic surface to walk upon.";
        private static readonly string magnocularsDiscription = "These powerful vision aids can magnify distant items into clear focus, helping ensure no heresy goes unspotted." +
            "More advanced, high-quality magnoculars can also do such things as give range read-outs, detect heat sources, calculate target location positioning, " +
            "and take pict-captures of a view for later analysis.";
        private static readonly string ManaclesDiscription = "No bounty hunter or Enforcer would be without several sets of these solid restraints, " +
            "though they are often used to ensure sacrificial offerings do not stray from a cult’s altar or for other, darker purposes.";
        private static readonly string mediKitDiscription = "Medi-kits contain synth-skin patches, antiseptics, self-sealing bandages, pressure tourniquets, " +
            "and other medical aids.A standard kit grants a +10 bonus to Medicae tests so long as the user possesses the Medicae skill." +
            "Advanced versions also contain tox wands, synth-skin spray, diagnostic cogitators, and additional high-quality supplies. " +
            "These grant a +20 bonus to Medicae tests (whether or not the user possesses the Medicae skill) but weight an extra 3kg and are of Rare Availability instead of Common.";
        private static readonly string microBeadDiscription = "Also known as a bead-comm, these small devices are worn in the ear and allow for short-range " +
            "communications out to roughly 1 kilometre(depending on weather conditions and intervening terrain). Each fits discreetly in the ear, " +
            "with higher Craftsmanship models nearly undetectable in casual inspection.";
        private static readonly string monotaskServoSkullDiscription = "Servo-skulls represent the honoured remains of valued Imperial servants and " +
            "Tech-Priests who continue their service even after death.The skull is carefully cleansed and engraved, then fitted with a machine spirit to guide its actions," +
            " and tiny grav platings to sustain it in flight.Monotask models are dedicated to a single, basic function and are a common sight on many worlds.Each responds " +
            "to basic verbal commands, and unless otherwise commanded, always hovers near its master." +
            "The types below represent only a fraction of the countless patterns found across the sector. " +
            "\n• Augur: The skull carries a scanner and vox-data systems to relay its findings. The character gains the benefits of an auspex as long" +
            " as the servo-skull is within 10 metres and active. • Illumination: The skull is fitted with a glow-globe or burning brazier to light an area 20 metres in radius. " +
            "\n• Laud Hailer: The servo-skull incorporates a laud-hailer, which can play recorded speech or amplify its master’s speech as directed. " +
            "\n• Medicae: The skull is fitted with a medicae scanner and tools. The character gains the benefits of a standard medi-kit as long " +
            "as the servo-skull is within 2 metres and active. " +
            "\n• Utility: The skull is equipped with probes, plugs, and tools to aid in technical tasks. The character gains the benefits of a combi-tool " +
            "as long as the servo-skull is nearby and active.";
        private static readonly string multicompassDiscription = "When exploring new worlds, a device of this ancient techpattern is indispensable—but few have the means " +
            "or influence to acquire one.After a few seconds of analysing planetary data, a multicompass can display directions, show topographical maps, " +
            "point out compass bearings, indicate altitude, and much more. Possessing a multicompass grants a +20 bonus to all Survival and Navigation (Surface) tests.";
        private static readonly string multikeyDiscription = "In the right hands, a multikey can open most standard Imperial locks and is thus is highly suspect for" +
            " honest citizens to possess. This also makes it very desirable for criminals or those operating outside normal channels.A character with a multikey gains a " +
            "+30 bonus to any Security test when trying to open locks.";
        private static readonly string nullRodDiscription = "Few things invoke terror as much as a psyker calling on the unholy powers of the Warp to twist reality and rend souls." +
            "While faith in the Emperor is always essential, a null rod can also be effective in negating such threats.Most null rods appear as short obsidian cylinders, " +
            "often crawling with arcane icons and glyphs.Each can dampen the powers of any psykers within 2d10 metres, causing them to take all tests to use any of their " +
            "psychic powers with a –30 penalty. They also offer an Acolyte personal protection from psychic attacks by granting a +30 bonus to resist any psychic power that " +
            "directly affects him. A null rod acts as a truncheon with the Power Field quality when used in close combat.";
        private static readonly string pictRecorderDiscription = "A relatively simple recording device, pict recorders—or picters— can capture audiovisual media." +
            "Most models can also display recorded data on integrated screens, with advanced models using holographic imagery.Specialised pict-servitors are " +
            "essentially ambulatory recorders, brought on hazardous events or missions to autonomously capture occurrences for later codifying.";
        private static readonly string psyFocusDiscription = "Many psykers use these small, personalised items to steady themselves before accessing the terrible powers of the Warp. " +
            "Each is different; some might be no more than a carved finger bone or pressed flower, while others could be a softly glowing crystal or void-iron glyph." +
            "All, however, are specially attuned to their bearers through long meditation or ritual, allowing them greater control over their abilities." +
            "When a psyker with a psy focus makes a Focus Power test, he gains a +10 bonus.";
        private static readonly string regicideSetDiscription = "A two-player game played across all classes from lowly refresherscrubbers to spire nobility, " +
            "regicide is simple to learn but difficult to master.Many Imperial Guard officers hone their tactical senses in games with small sets that " +
            "can fold into their combat kit.A  typical regicide game takes 1d5 hours, and while it usually has no in-game effects, " +
            "the GM can offer benefits to well-roleplayed games such as a +10 bonus to Fellowship-based tests with the opponent for the following day.";
        private static readonly string screamerDiscription = "These proximity alarms set off a piercing wail when they detect intruders." +
            "Screamers can detect sound, movement, and even odours.To activate, the player must succeed on a Challenging (+0) Tech-Use test, " +
            "but the GM rolls this test in secret; players will not know how well the device is working until later on. " +
            "Once set, a screamer has a Perception of 75 for the purposes of detecting sounds or motions.If it detects an intruder, it sounds its alarm, " +
            "which can be heard anywhere out to one kilometre.Doors, walls, and other barriers reduce the alarm’s range. Poor craftsmanship models " +
            "only detect loud noises or fast movements nearby.Good versions can detect specific sounds, movement, or even odour ranges, and can also have m" +
            "ore subtle warning methods (such as screaming only into vox channels).";
        private static readonly string signalJammerDiscription = "As the name suggests, this device acts to overpower local vox, data, or other transmissions within " +
            "a range of roughly 1km. Basic models are overt and obvious, such that the transmitting agencies know they are being jammed.Sophisticated versions " +
            "emit precisely-tuned frequencies that dampen out transmissions without anyone detecting the action.";
        private static readonly string staticGeneratorDiscription = "Simple but obvious, this emits a powerful sphere of white noise across commonly used " +
            "transmission frequencies within 30 metres. Comm devices do not function, but it is also clear to all users that they are being disrupted, " +
            "and the device can be easily located.Still, when set on a timer and placed next to a transmission tower, they are effective for short-duration sabotage.";
        private static readonly string stummerDiscription = "The reverse of a screamer, a stummer blankets sound within 5m through sonic detection and dampening projectors." +
            "A character carrying an active stummer gains a +30 bonus to Stealth tests. A stummer typically has enough power for 20 minutes of continuous use " +
            "before needing to be recharged, a process that takes about one hour.";
        private static readonly string voxCasterDiscription = "A standard Imperial long-distance communications device, voxcasters can transmit and " +
            "receive to other units within 100km, and can reach most orbiting vessels overhead.Higher craftsmanship models have increased ranges, " +
            "and can include encryption and other security settings.";
        private static readonly string writingKitDiscription = "Simple and basic, standard writing kits contain parchment, inks, " +
            "and quills for Acolytes to transcribe confessions, diagram important finds, and leave messages for fellow Acolytes.";
        #endregion
    }
}
