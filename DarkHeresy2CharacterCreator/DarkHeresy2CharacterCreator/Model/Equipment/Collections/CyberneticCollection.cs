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
    /// Instaniate a observableCollection of cybernetics
    /// </summary>
    public static class CyberneticCollection
    {
        /// <summary>
        /// Collection of all cybernetics
        /// </summary>
        public static ObservableCollection<IItem> Cybernetics = new ObservableCollection<IItem>
        {
            new Item("Bionic Arm", Availability.Scarce, 0, bionicArmDiscription),
            new Item("Bionic Heart", Availability.Very_Rare, 0, bionicHeartDiscription),
            new Item("Augur Array", Availability.Rare, 0, augurArrayDiscription),
            new Item("Autosanguine", Availability.Very_Rare, 0, autosanguineDiscription),
            new Item("Baleful Eye", Availability.Near_Unique, 0, balefulEyeDiscription),
            new Item("Bionic Leg", Availability.Scarce, 0, bionicLegDiscription),
            new Item("Bionic Respiratory System", Availability.Rare, 0, bionicRespiratorySystemDiscription),
            new Item("Bionic Senses", Availability.Rare, 0, bionicSensesDiscription),
            new Item("Calculus Logi Upgrade", Availability.Very_Rare, 0, calculusLogiUpgradeDiscription),
            new Item("Cerebral Implants", Availability.Very_Rare, 0, cerebralImplantsDiscription),
            new Item("Cranial Armour", Availability.Scarce, 0, cranialArmourDiscription),
            new Item("Ferric Lure Implants", Availability.Very_Rare, 0, ferricLureImplantsDiscription),
            new Item("Interface Port", Availability.Rare, 0, interfacePortDiscription),
            new Item("Internal Reservoir", Availability.Rare, 0, internalReservoirDiscription),
            new Item("Locator Matrix", Availability.Rare, 0, locatorMatrixDiscription),
            new Item("Luminien Capacitor", Availability.Very_Rare, 0, luminienCapacitorDiscription),
            new Item("Maglev Coils", Availability.Very_Rare, 0, maglevCoilsDiscription),
            new Item("Ballistik Mechandendrite", Availability.Very_Rare, 0, ballisticMechandendriteDiscription),
            new Item("Manipulator Mechandendrite", Availability.Very_Rare, 0, manipulatorMechandendriteDiscription),
            new Item("Medicae Mechandendrite", Availability.Very_Rare, 0, medicaeMechandendriteDiscription),
            new Item("Optical Mechandendrite", Availability.Very_Rare, 0, opticalMechandendriteDiscription),
            new Item("Utility Mechandendrite", Availability.Very_Rare, 0,utilityMechandendriteDiscription),
            new Item("Memorance Implant", Availability.Rare, 0, memoranceImplantDiscription),
            new Item("Mind Impulse Unit (MIU)", Availability.Rare, 0, mindImpulseUnitDiscription),
            new Item("MIU Weapon Interface", Availability.Rare, 0, MIUWeaponInterfaceDiscription),
            new Item("Respiratory Filter Implant", Availability.Rare, 0, respiratoryFilterImplantDiscription),
            new Item("Scribe-Tunes", Availability.Rare, 0, scribeTinesDiscription),
            new Item("Subskin Armour", Availability.Very_Rare, 0, subskinArmourDiscription),
            new Item("Synthmuscle", Availability.Rare, 0, synthmuscleDiscription),
            new Item("Vocal Implant", Availability.Scarce, 0, vocalImplantDiscription),
            new Item("Volitor Implant", Availability.Rare, 0, volitorImpantDiscription)
        };

        #region Discriptions
        private static readonly string bionicArmDiscription = "Bionic arms are a common replacement, and Common models can mimic normal hand and arm functions, " +
            "including dexterity and even sense of touch. " +
            "\n• Poor craftsmanship versions are more cumbersome and visibly artificial; halve the owner’s Agility characteristic(rounded up) " +
            "where matters of fine dexterity are involved.In addition, Weapon Skill and Ballistic Skill tests made when using the limb suffer a –5 penalty. " +
            "\n• Good craftsmanship bionic arms improve on natural design and provide a +10 bonus on Agility tests requiring delicate manipulation. " +
            "\n• Best craftsmanship bionic arms provide a +10 bonus on Agility tests requiring delicate manipulation and add a +10 bonus to Strength tests using the arm." +
            "They can be also used to store small items(such as pistol ammo clips) inside concealed interior compartments within the arm.";
        private static readonly string bionicHeartDiscription = "The paranoid (or the prepared) are ever-willing to replace crude flesh with more durable, " +
            "armoured materials—the light armour shielding of a bionic heart provides a last line of defence.Superior models can be triggered to pump more " +
            "rapidly to increase physical capacity, though this risks bodily strain as the rest of the circulatory system is put under pressure." +
            "A character with this implant gains +1 Armour point to the Body location—this bonus stacks with any armour worn—and gains the Sprint talent.";
        private static readonly string bionicLegDiscription = "These bionics are fully integrated into the hip with a spinal link, and Common versions allow the user to walk, " +
            "run, and climb at normal human levels. " +
            "\n• Poor craftsmanship models are lumbering affairs that reduce a character’s Movement rate by 1, " +
            "and when running, the user must succeed on an Ordinary(+10) Agility test or fall Prone at the end of his movement. " +
            "\n• Good craftsmanship bionic legs grant the owner the Sprint talent, and add a +20 bonus to Agility tests that he makes when attempting to jump or leap.";
        private static readonly string bionicRespiratorySystemDiscription = "Common bionic lungs and implanted respiratory systems mimic the action of human lungs " +
            "and keep the body supplied with oxygen.Such characters gain a +20 bonus to Toughness tests made to resist airborne toxins and gas weapons. " +
            "\n• Poor bionic lungs offer the same benefits as the Common system, but are raucously loud affairs and characters suffer a –20 penalty to Stealth tests. " +
            "Their generally poor oxygen supply to the body means that the character suffers a –10 penalty on all tests involving strenuous physical activity. " +
            "\n• Good bionic lungs count as a full life support system—if for any reason the user’s own respiratory system fails, his bionic lungs keep his " +
            "blood oxygenated—and can be designed to be unnoticeable if desired.";
        private static readonly string bionicSensesDiscription = "Eyes, ears, and even noses are often lost through combat or accident, and replacement versions " +
            "use cranial interfaces to allow a very close approximation to natural senses.Bionic eyes in particular are frequently seen amongst senior " +
            "Imperial Guard officers, Rogue Traders, and other powerful individuals.Common systems, while usually clearly artificial and often oversized, " +
            "manage to more or less duplicate the approximate human range of senses adequately and have no further game effects. " +
            "\n• Poor quality cybernetic senses are problem-ridden imitations of the real thing. Hearing might be troubled by static, " +
            "for example, or vision rendered in low-resolution monochrome. A character with this system suffers a –20 penalty to tests made involving the cybernetic sense. " +
            "\n• Good cybernetic senses grant a +10 bonus to tests using that particular sense, and a +20 bonus to tests made to resist attacks on the sense itself, " +
            "such as deafening noises and blinding flashes.Advanced cybernetic eyes can also incorporate magnifying lenses, a full photo-visor," +
            " or a system granting the Dark-sight trait. Advanced cybernetic ears can also include an internal micro-bead system.Each additional upgrade " +
            "requires a separate Requisition test to be fitted into existing cybernetic senses.";
        private static readonly string augurArrayDiscription = "These implanted devices duplicate the effects of sensor systems that go beyond normal human senses." +
            "In all cases, their use requires concentration and a Half Action.Common systems function identically to a standard hand-held auspex device. " +
            "\n• Poor systems possess only a single detection ability(heat, radiation, electromagnetics, or very rarely daemonic taint)" +
            " and have the limited range of 20 metres.If the augur is set to detect daemonic taint, it has the possibility to be overwhelmed " +
            "and malfunction should a Warp-denizen get too close. " +
            "\n• Good systems function as a full auspex, but also allow the character to re-roll all Perception-based tests.";
        private static readonly string autosanguineDiscription = "This ancient and blessed microscopic technology flows as a metallic liquid within the character’s " +
            "bloodstream, repairing minor injuries and accelerating healing.It repairs minor injuries and speeds recovery.When applying healing, " +
            "the character is always considered Lightly Damaged, and heals at an increased rate, removing 2 points of damage per day instead of 1.";
        private static readonly string balefulEyeDiscription = "This legendary archaeotech bionic pattern incorporates a tiny las weapon." +
            "Each baleful eye has been passed from recipient to recipient across centuries or millennia, reclaimed by the Machine Cult whenever its owner dies." +
            "As might be imagined, it is very intimidating when used as a part of negotiations with primitive societies.A character with this implant has a weapon " +
            "in his eye that counts as a hot-shot laspistol with a range of 10m. The baleful eye can be fired even if the character’s hands are full." +
            "It has no clip size, however a jam result causes the character to lose sight in the eye for a number of rounds equal to the degrees of failure on the attack.";
        private static readonly string calculusLogiUpgradeDiscription = "These bionics are internal cogitator implants which aid in data retention and processing." +
            "The user can rapidly sift through stacked dataslates and parchments, applying intuition to vast reams of data far beyond the capabilities of a normal man." +
            "This implant grants the user a +10 bonus to Literacy, Logic, and Scholastic Lore tests.";
        private static readonly string cerebralImplantsDiscription = "Commonly used to repair a severely damaged brain or (hopefully) augment its abilities, " +
            "these often-risky implant systems represent a major step from simply replacing a limb to altering a character from human to mechanism." +
            "Common-level implants can restore paralysed and brain-damaged users to a semblance of normality, but with a permanent loss of 1d10 points " +
            "from the character’s Weapon Skill, Ballistic Skill, Agility, Intelligence, and Fellowship characteristics. " +
            "\n• Poor versions restore brain function, but destroy the subject’s personality and memories, rendering them no better than a servitor, and as such are unsuitable for PCs. " +
            "\n• Good cerebral implants are very rare even among high ranking Imperial officials, and are exceedingly difficult to acquire, " +
            "becoming Near Unique in Availability.These grant the user the Unnatural Intelligence (2) trait and a +20 bonus to Logic and Lore tests, " +
            "thanks to the superior mental capabilities he now enjoys.";
        private static readonly string cranialArmourDiscription = "This augmentation covers or replaces most of the skull with layers of plasteel and gel padding " +
            "to better prevent concussion and other brain injuries.This implant adds +1 Armour point to the Head, and stacks with any worn armour on that location.";
        private static readonly string ferricLureImplantsDiscription = "Powerful electromagnets are implanted in the Acolyte, allowing him to cast forth a net of " +
            "invisible energy as a Full Action after a successful Challenging(+0) Willpower test.He can call an unsecured metal object into his hand; " +
            "the object cannot mass more than 1 kg per point of Willpower bonus, and must be within 20 metres.He must already have Mechanicus Implants trait " +
            "for this system to function, and it can be improved through certain talents as described in Talents & Traits.";
        private static readonly string interfacePortDiscription = "The Acolyte now has a mechanical port implanted in his body, commonly in the rear of the neck, " +
            "which can be connected to machines via a data cable.This allows the user faster and smoother access to the valuable information within, " +
            "and grants a +10 bonus to Common Lore, Inquiry, or Tech-Use tests whilst connected to a relevant mechanism or data spool.";
        private static readonly string internalReservoirDiscription = "This implant acts as a powerful battery, storing energy for various implants and(especially) " +
            "for functions that require energy to be expended in rapid or violent fashions.When it is fully charged, the Acolyte no longer gains Fatigue from using " +
            "Luminen Capacitors either to recharge or attack something, but each use of those implants drains the reservoir by half.The battery fully recharges after one day of resting.";
        private static readonly string locatorMatrixDiscription = "Micro-cogitators implanted at the base of the skull allow the user to be aware of the direction " +
            "of the planetary poles, the Acolyte’s present location to within a few metres, relative velocity, altitude, time of day, and other valuable information.T" +
            "he user must still have access to maps and other planetary data in order to benefit from this information, however—knowing one is at a specific location " +
            "on a planetary surface has little meaning without knowing what is over the next rise, or what is the direction needed to reach a given destination.";
        private static readonly string luminienCapacitorDiscription = "This implanted energy source charges internal capacitors, allowing the character to recharge devices" +
            " or even unleash powerful energy blasts.With a successful Toughness test, the character recharges or powers machinery.This requires one minute " +
            "of mental focus and meditation. The difficulty of the Toughness test varies depending on the nature of the powered system. " +
            "\n• Ordinary (+10): Simple power cell, glow-globe " +
            "\n• Challenging(+0) : Lasgun charge pack, dataslate " +
            "\n• Difficult(–10) : Shuttle launch systems, servo-skull " +
            "\n• Hard(–20) : Lascannon charge pack, servitor " +
            "\n• Very Hard(–30): Cogitator core, xenos technology The device can also be used offensively, but requires talents to use properly " +
            "as described in Talents & Traits.Only an Acolyte with the Mechanicus Implants trait may use this device. " +
            "\nPoor craftsmanship variants impose a –10 penalty to all Toughness tests made to use them." +
            "\nGood craftsmanship variants grant a +10 bonus to all Toughness tests made to use them.";
        private static readonly string maglevCoilsDiscription = "Archaeotech systems of powerful gravimetric coils are implanted in the body, allowing the user to " +
            "become unshackled from gravity’s grasp for short periods.Using a Half Action, the user may hover 20-30 centimetres off the ground for a number " +
            "of minutes equal to 1d10 plus the character’s Toughness bonus.The character must employ a Half Action each round to concentrate on operating " +
            "this implant and may use the other action to move normally. The character can slow his rate of descent when falling so long as this implant " +
            "is active when the character reaches the ground, reducing all falling damage to a maximum of 1d10+3 Impact damage. Each time the character " +
            "activates the coils, it drains the stored power and cannot be used again until recharged (which takes 24 hours).";
        private static readonly string ballisticMechandendriteDiscription = "Designed for ranged combat, this mechadendrite is fitted with a weapon " +
            "that functions as a laspistol that does not require recharging. The user does not need weapon training in this weapon class to fire the mechadendrite’s weapon " +
            "without the normal untrained penalty, and can attack with this weapon as his Reaction.";
        private static readonly string manipulatorMechandendriteDiscription = "A heavy and powerful attachment, this mechadendrite is designed for heavy lifting and handling " +
            "of industrial gear.It grants the user +20 to Strength-based tests; the vicious gripping and crushing pincers can also tether the user to gantries or suitably " +
            "heavy objects as a Free Action.Once per round, the character can utilise this mechadendrite as a weapon by spending a Half Action or a Reaction " +
            "to make a Standard Attack action with it.It counts as a melee weapon that inflicts 1d10+2 Impact damage, Pen 0. While powerful, " +
            "the manipulator is not subtle, and attempts to use it for such tasks as dataslate typing, inscribing sacrificial etchings, handling delicate objects, " +
            "or the like only ends with equipment being dropped, smashed, or otherwise ruined.";
        private static readonly string medicaeMechandendriteDiscription = "This model hosts a variety of medical and surgical tools ideal for combat first aid, " +
            "and grants a +10 bonus to Medicae and Interrogation tests.The mechadendrite houses six injector pistons, each of which may be filled with one dose of a drug. " +
            "In addition to providing first aid, the mechadendrite’s flesh staplers may be used to staunch Blood Loss as a Half Action.A small chainscalpel attachment " +
            "reduces the difficulty of limb amputation to Challenging (+0). Once per round, the character can utilise this mechadendrite as a weapon by spending a " +
            "Half Action or a Reaction to make a Standard Attack action.It counts as a melee weapon with the Balanced quality that inflicts 1d5 Rending damage, Pen 0.";
        private static readonly string opticalMechandendriteDiscription = "Often consisting of highly flexible, snake-like tubing, this contains pict-capture and " +
            "other sensory devices for inspection and detection. It is long for a mechadendrite, extending to 3 metres, and grants a +10 bonus to all " +
            "vision-based Perception tests.The mounted pictdevices allow it to examine surfaces at a microscopic level or to be used as telescopic sight." +
            "It contains an infrared torch and sensors with a range of 40m, and so within this area the user ignores combat or other penalties due to darkness." +
            "The mechadendrite is also fitted with a stablight that can be tinted a variety of different colours depending on the controller’s whim.";
        private static readonly string utilityMechandendriteDiscription = "The most common type of mechadendrite, these are tipped with a variety of mechanisms for the repair" +
            " and succour of blessed technologies.It counts as a combi-tool, granting a +10 bonus to all Tech-Use tests.The limb also houses six injector pistons, " +
            "each of which may be filled with one dose of a sacred unguent.In addition to this, the limb contains an electrically-powered censer, " +
            "which can gust incense fumes over troublesome faults. Unless the censer is deactivated, all Perception tests made to detect the Tech-Priest" +
            " that rely on a sense of smell gain a +10 bonus.As a Half Action, the censer can create one “blast” of smoke every fifteen minutes, " +
            "which imposes a –5 penalty to Weapon Skill tests made by all living creatures within a two-metre radius for one round. Once per round, " +
            "the character can also utilise this mechadendrite as a weapon by spending a Half Action or a Reaction to make a Standard Attack action. " +
            "It counts as a melee weapon with the Defensive quality that inflicts 1d5 Rending damage, Pen 2.";
        private static readonly string memoranceImplantDiscription = "This implant is a neurally-linked datavault and pict-capture array, often incorporating " +
            "augmetic replacement of one or both eyes, that records information on people or scenes viewed.It can then later replay that information, " +
            "or overlay the present view with additional data on people and objects viewed.It is a tool of chroniclers, loremancers, and masters of ceremonies, " +
            "as well as factors or nobles who like to see the secrets of their rivals overlaid upon their view of the negotiating table. " +
            "It provides a +10 bonus  to Trade (Loremancer) tests or other tests in social situations where the recorded information provides leverage or value.";
        private static readonly string mindImpulseUnitDiscription = "These devices, also known as sense-links, allow the owner to interface directly with " +
            "a machine or technological device.MIUs see widespread use among the Adeptus Mechanicus, who regard them as objects of divine communion. " +
            "A basic model involves a single spinal or cortex connector, while advanced variants include wrist connector probes—and possibly mechadendrite " +
            "connectors—in addition to the spinal plug.Common models impose no modifiers to machine spirit communication, and add a +10 bonus to Tech-Use " +
            "or Operate tests used in conjunction with devices capable of MIU linking. " +
            "\n• Poor MIU systems require a Challenging (+0) Willpower test to use and impose a –10 penalty when attempting to interface with a device. " +
            "\n• Good models grant a +10 bonus to commune with machine spirits and for Tech-Use, Operate, Logic, Inquiry, and Ballistic Skill tests made " +
            "as part of interfacing with the MIU systems.";
        private static readonly string MIUWeaponInterfaceDiscription = "Unlike the more advanced MIU version normally only granted to priests of the Adeptus Mechanicus, " +
            "this model is more simplified, allowing the user to remotely operate a single weapon which is attached user’s body.While not as elaborate, " +
            "it is easier to use and a favourite of many militant professions. This system allows the user to fire the linked ranged weapon as a " +
            "Free Action during his turn. Note that he can still only take a single Action with the Attack subtype during his turn." +
            "This additional weapon must be connected to the user via the MIU weapon interface, and is usually equipped as a shoulder mount.";
        private static readonly string respiratoryFilterImplantDiscription = "These are implanted inside the lungs or involve masses of tubes, wires, vox-grills, " +
            "or other augmetic parts replacing the neck and upper chest.The implant sifts out most toxic gases; inhaled particulate matter is also filtered, " +
            "making breathing easier in heavily polluted atmospheres.This implant grants the user a +20 bonus to resist inhaled poisons, gas weapons, or atmospheric toxins.";
        private static readonly string scribeTinesDiscription = "The hand and lower forearm are replaced with specialised and sensitive tools ideal for manipulating parchment, " +
            "autoscribing,  dataslate tuning, and other efforts to record and preserve information.While somewhat disquieting in appearance, " +
            "they are viewed with favour by hive-world scholars and lexmechanics. This implant gives the user a +10 bonus to all Lore skill tests.";
        private static readonly string subskinArmourDiscription = "Thin carapace plating is inserted under the skin in various locations, " +
            "giving the user added protection against damage.While not as impressive as most augmentations and sometimes uncomfortable, subskin armour is very reliable." +
            "This implant adds +2 Armour points to the Arms, Body, and Legs locations, which stacks with any other Armour points for these locations.";
        private static readonly string synthmuscleDiscription = "Ropey strands of vat-grown muscle tissue, thick with slurried nutrients and laced with flakweave, " +
            "are woven into existing muscle groups, granting increased strength of varying levels.This implant grants the Unnatural Strength(1) trait; " +
            "Best craftsmanship grafts instead grant the Unnatural Strength(4) trait but also impose a –10 penalty on Agility tests due to the newly misshapen and unnatural body form.";
        private static readonly string vocalImplantDiscription = "This implant is usually found with those who use their voice to project commands or proclamations, " +
            "such as Ecclesiarchy Preachers or Adeptus Arbites Crowd Dispersal Officers.This implant works to amplify the vocal cords to an inhuman range in order " +
            "to shout commands over the noise of a raging battle, and counts as using a laud hailer.";
        private static readonly string volitorImpantDiscription = "The subject has cranial surgery to implant neural receptors and artificial nerve routing, " +
            "and can be compelled not to reveal a certain item of information, remain within a set area, or perform a specific task.If the subject attempts—or " +
            "is forced—to counter this compulsion, his brain shuts down into unconsciousness, or even death for some severe volitor patterns.";
        #endregion

    }
}
