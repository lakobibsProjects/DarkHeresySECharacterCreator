using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    /// <summary>
    /// Instaniate a observableCollection of skills
    /// </summary>
    public static class SkillList
    {

        #region Discriptions
        #region Common Skills
        private readonly static string acrobaticsDiscription = "Skill Use: Full Action unless otherwise noted. /n Acrobatics covers feats of agile movement, graceful motion, and mastery of balance and form. With this skill, " +
                "characters can leap nimbly across gaping chasms, maintain their balance on a pitching ship deck, or fall gracefully to the " +
                "ground without snapping their limbs. In combat, an accomplished acrobat can somersault, flip, or cartwheel away from foes, " +
                "twisting his body out of reach of his enemy or slipping past foes in a blur of motion. Often, characters develop a knack " +
                "for Acrobatics as part of their training in another field. A courier or thief might learn these knacks as part of travel" +
                " through densely populated areas. Gladiators, survivalists, and dancers need to be able to perform acrobatic motions as " +
                "part of their daily routines. Even a Tech-Adept accustomed to working in particularly confined quarters devotes his daily" +
                " flesh-exhortations to improving flexibility, so that he might more effectively work within narrow ductwork. " +
                "/n The GM can call on a player to use the Acrobatics skill when: " +
                "/n • He must keep his balance or avoid falling in unstable ground. " +
                "/n • He wishes to jump down from a height and land well. " +
                "/n • He wants to move over or around a foe or obstacle in his path without breaking his stride." +
                "/n Special Uses:" +
                "/n Contortionist:  A character can use his Acrobatics skill to escape from bonds or the grip of a " +
                "foe by twisting and turning his body. As a Full Action, a character may make an Acrobatics skill " +
                "test to  This test can only be attempted once to escape restraints; if the character fails to " +
                "free himself the first time, then he is simply too tightly bound and unable to contort his way" +
                " free. The GM can modify this test depending on the quality of the bonds in this situation. " +
                "Characters may also use Acrobatics to escape from a grapple by using their Acrobatics skill " +
                "instead of their Agility or Strength when grappling." +
                "/n Manoeuvring:  In combat, a character capable of acrobatics can more easily avoid foes or " +
                "retreat from combat without harm. The character may make a Disengage action as a Half Action " +
                "(rather than a Full Action) if he passes a Challenging (+0) Acrobatics skill test." +
                "/n JumPing: A well-trained acrobat excels at jumping, leaping, and lessening the effect of falls " +
                "by folding his body as he hits the ground. When jumping or leaping, a character may use the " +
                "Acrobatics skill in the place of Agility and Strength tests. When determining Falling damage, a " +
                "character can make an Acrobatics skill test to reduce the effective distance fallen by a " +
                "number of metres equal to his Agility bonus.";

        private readonly static string athleticsDiscription = "Skill Use: Full Action unless otherwise noted. /n Acolytes are often dependent upon their physical abilities, " +
                "particularly when situations become violent. Athletics measures a character’s" +
                " ability to run long distances without tiring, climb sheer surfaces, and lift " +
                "heavy loads. It also allows a character to push himself to greater levels of " +
                "endurance and shrug off the effects of fatigue when running, swimming, or climbing." +
                " A character’s background might dispose him more towards certain types of athletics." +
                " A GM can keep this in mind when determining the difficulty of a test. For example, " +
                "a character from a desert world or could be required to make more difficult Athletics " +
                "tests to swim across a river than an Acolyte who grew up on an aquatic agri-world would." +
                "/n The GM can call on a player to use the Athletics skill when: " +
                "/n• He must swim across a body of water or try to stay afloat. " +
                "/n• He wishes to push himself beyond his limits and keep going even when exhausted. " +
                "/n• He wants to climb a cliff or cross extremely rough ground." +
                "/n Special Uses:" +
                "/n EnduranCe:  Trained athletes are extremely fit and can push themselves far beyond " +
                "the ability of normal people. As a Free Action, a character with the Athletics skill " +
                "can make a Difficult (–10) Athletics skill test whenever he suffers a level of Fatigue " +
                "as a result of running, swimming, or climbing to ignore its effects. The character can " +
                "continue to take tests and ignore Fatigue gained in this way indefinitely; however,as " +
                "soon as he fails a test, he must rest for at least 4 hours and cannot use his Athletics " +
                "skill again during that time." +
                "/n Heft:  Athletes are also known for their strength and can lift great weights for short " +
                "periods of time. As a Free Action, a character can make a Challenging (+0) Athletics skill " +
                "test to increase his carrying capability for a single encounter. For every degree of success " +
                "the character achieves, his Strength is  increased by 10 for the purposes of how much weight" +
                " he can carry, lift, or drag, to a maximum modified Strength of 100. Hefting can only be attempted " +
                "once, and if the character fails the test, he cannot try again until the next encounter.";
        private readonly static string awarnessDiscription = "Skill Use: Free Action made in reaction to something. /n Awareness represents the character’s general awareness of his surroundings and " +
                "the ability to notice inconsistencies that others might dismiss. It encompasses a basic alertness " +
                "to any changes that might be detected by the senses, including visual cues, sounds, odours," +
                " and even air pressure. A highly-trained observer is just as capable of noticing and identifying " +
                "the presence of a new factor as they are the absence of a common one. Threats to the Mankind can lurk" +
                " in the shadows of any location, and often the subtlest of cues can reveal far deeper meanings. " +
                "In general, Awareness is used when trying to spot items or individuals that are either hidden" +
                " or not easy to notice. Scrutiny is used to interpret hidden emotions, motivations, " +
                "or other undercurrents. So while spotting someone hidden would be Awareness, determining whether " +
                "someone is lying or being deceitful would be Scrutiny. When Awareness is used against an opponent " +
                "(such as to spot an ambush) it is an Opposed test. Awareness opposes and is opposed by Stealth. " +
                "/n The GM can call on a player to use the Awareness skill when: " +
                "/n • He is walking into an ambush or being spied upon by a hidden foe. " +
                "/n • He wants to search an area for clues or find a hidden item. " +
                "/n • He is trying to eavesdrop on a conversation or there is a chance of overhearing some pertinent information." +
                "/n Special Uses:" +
                "Lip reading: Lip reading allows an Acolyte to effectively understand a conversation even though he cannot hear it. " +
                "The character must have a clear view of the speaker’s mouth and understand the language used by the target. " +
                "The difficulty of this test is modified –10 for every 10 metres of distance between the character and the speaker. " +
                "The GM can assign other penalties for darkness, fog, or other factors affecting vision; magnoculars or other " +
                "vision enhancing devices can help offset this penalty or provide a bonus. A successful Awareness skill test " +
                "reveals the general gist of the conversation, such as talking about a drop point or the location of a cult gathering. " +
                "Additional degrees of success reveal correspondingly more information. The character need not make a skill test every round," +
                " as one degree of success is enough to follow the conversation for the span of roughly one topic. The GM determines when a new test is necessary.";
        private readonly static string charmDiscription = "Skill Use: 1 minute. /n  Charm is a measure of a character’s knack for impressing people and swaying their reactions. " +
                "The acting character’s attitude is key in distinguishing between this and other types of Interaction skills. " +
                "Charm requires the Acolyte to assume a non-hostile attitude and not make any explicit or implicit threats.Instead," +
                " the character’s persuasive efforts are dependent upon perceived generosity and good intentions. " +
                "Such an approach may be completely foreign to someAcolytes, who find persuasion more appealing when matched with force or logic." +
                "Others, particularly those who come from luxury or who are masters of manipulation, might use this as their favoured approach to all problems." +
                " Often, bonuses or penalties can resultfrom a character’s appearance and style of dress. When Charm is used against an opponent " +
                "(such as to changehis mood) it is an Opposed test. Charm is opposed by Willpower. " +
                "/n The GM can call on a player to use the Charm skill when: " +
                "/n • He wants to make someone like him for whatever reason. " +
                "/n • He wishes to distract someone by drawing his focus away from others. " +
                "/n • He is gathering information from locals or strangers.";
        private readonly static string commandDiscription = "Skill Use: Half Action for simple commands, Full Action for more involved direction. " +
                "/n Often, a single character is unable to adequately resolve a crisis. At times, even a warband of " +
                "Acolytes are inadequate to the challenge. Under these circumstances, characters may need to rally " +
                "a much larger group to assist. Coordinating their allies so that everyone can work together effectively" +
                " relies upon the Command skill. It represents the ability to effectively motivate and organise others. " +
                "Characters with a noble background might have some training in this skill. Those with military service " +
                "are of course practiced with it; even those who have only been given commands are very familiar with the " +
                "practice and can issue them as well. Other characters might have learned it as a bureaucratic manager or a " +
                "tribal leader. In contrast, characters accustomed to working independently could have little aptitude for commanding (or being commanded by) others." +
                "/n The GM can call on a player to use the Command skill when: " +
                "/n • He wishes to send an NPC ally into an extremely dangerous situation or into open combat. " +
                "/n• He needs to rally his allied fighting forces or organise them in the face of a surprise attack." +
                 "/n Special Uses:" +
                "Inspire: In some situations, it is not merely enough for an Acolyte to have allies working towards his cause. " +
                "Instead, his allies must be convinced to give their all in order for success to be achieved. " +
                "As a Full Action, the character can make a Challenging (+0) Command test to inspire one or more of his followers." +
                " Inspired followers receive a +10 on their next skill or characteristic test." +
                "/n Terrify: An Acolyte can use the Command skill to terrify his followers into fearing him more than Daemons or " +
                "other abominations As a Reaction, a character can try to counter the effects of Fear in his allies should they" +
                " fail their Willpower test against a Fear-causing foe. The character makes a Command skill test opposed by the" +
                " Willpower of the Fearcausing creature. Both the character and the creature add +10 to their rolls for each level " +
                "of Fear they possess. If the character is successful, his allies ignore the effects of Fear from this creature for the remainder of the encounter.";
        private readonly static string commerceDiscription = "Skill Use: 1 minute, or more for complex deals. The worlds of the Imperium are highly specialised and " +
            "woven together in a huge, interconnected web to transport goods and services to ensure mutual survival.Few, if any, planets could hope to survive on " +
            "their own for more than a few months without external support. Forge worlds need food and raw materials from other systems, agri-worlds can seldom " +
            "produce the machinery required for their harvests, and hive worlds are often so densely occupied that their only local product is the world’s population. " +
            "The Commerce skill represents the understanding of trade, value, and exchange, which allows these worlds to continue to exist at a planetary level, " +
            "and also more locally at a habway marketplace. Many within the Imperium’s vast bureaucracy, and even its military, learn this skill." +
            "All humans must practise it to a certain degree, as they acquire the basic necessities for life.Ultimately, thieves and merchants are the most adept," +
            " as they must know the value of any goods they plan to steal or sell. When Commerce is used against an opponent (such as to gain a bonus on a Requisition test)" +
            " it is always an Opposed test. Commerce opposes, and is opposed by, either Commerce or Willpower. " +
            "/n The GM can call on a player to use the Commerce skill when: " +
            "/n • He wants to gain a bonus when attempting a Requisition test." +
            "/n • He wishes to track down a rare item in a hive market." +
            "/n • He wants to know how much an item is worth." +
            "/nSpecial Use: Evaluate -  A character can use the Commerce skill to determine the worth of an item or commodity.The GM should make this roll in secret, " +
            "modifying the result depending on who the Acolyte is dealing with and the setting (see below for example modifiers). A success tells the character the" +
            " Availability of the item he is evaluating, while a failure tells him nothing.If he fails by more than 3 degrees of failure, the GM should give him a false Availability.";
        private readonly static string deceiveDiscription = "Skill Use: 1 minute, or more for complex deceptions. Acolytes often need to mislead those around them, as the " +
            "Inquisition’s cause involves secrets that could shatter the minds of unprepared innocents.Perpetrators are seldom cooperative, unless they believe that there might be" +
            " some reward for their service. No matter the motive or the target, all of these untruths are spoken in the service of the Emperor. Deceive measures a character’s " +
            "aptitude for fooling others into believing something that is not true. All who serve an Inquisitor must have some ability in this field, but some become far more " +
            "specialised in their deceptions. Of course, a Deceive test is only required if the acting character believes he is lying.Relating inaccurate information that the " +
            "Acolyte believes is true uses the appropriate skill for the situation. When Deceive is used against an opponent (such as to convince someone of a lie or fool them with " +
            "a disguise) it is always an Opposed test. Deceive opposes, and is opposed by, Scrutiny. " +
            "/n The GM can call on a player to use the Deceive skill when: " +
            "/n • He wants to tell a convincing lie." +
            "/n  • He wishes to distract someone with rambling nonsense." +
            "/n • He is trying to disguise himself." +
            "/n Special Use: disguise - An Acolyte with the Deceive skill can create a disguise for himself, given time and raw materials." +
            "The time taken depends greatly on the complexity of the disguise; simply putting on an enemy’s uniform or covering the one’s face with filth may take minutes, " +
            "while trying to disguise gender or mimic a specific individual may take hours, days, or longer.The GM decides how long formulating a disguise takes and if the " +
            "character has the materials at hand.Once the disguise is donned, the GM then secretly tests for the player(using his Deceive skill and any appropriate modifiers) " +
            "whenever the disguise comes under scrutiny(an Opposed test against the Scrutiny of whoever is trying to see through the disguise). If a disguise passes this first test," +
            " then the player need not test again unless something changes (suspicion is cast on the character, or a more observant NPC arrives).";
        private readonly static string dodgeDiscription = "Skill Use: Reaction. Dodge is the ability to avoid blows in melee, elude incoming fire, or leap out of the way of " +
            "falling debris.It combines nimbleness of movement with trained reflexes and an awareness of all kinds of danger. A character can use his Dodge skill to evade " +
            "either melee attacks or ranged attacks.Dodging an attack is made as a Reaction to a foe’s successful attack.A success indicates that the attack has been avoided " +
            "and it does not hit the character. In the case of attacks which cause multiple hits (such as automatic fire) each degree of success a character achieves on his " +
            "Dodge test cancels one hit from the attack.Any excess hits not cancelled by Dodging are then applied to the character as normal." +
            "/n The GM can call on a player to use the Dodge skill when: " +
            "/n • He is attacked in melee." +
            "/n • He is attacked with a ranged weapon." +
            "/n • He needs to avoid hazards such as falling wreckage or leap from a collapsing bridge." +
            "/n Special Use: dive for Cover -  If there is cover with a number of metres equal to the character’s Agility bonus and he is not prone, he can alternatively Dive for Cover" +
            " as a Reaction against a ranged attack instead of trying to Evade the attack.He makes an Ordinary(+10) Dodge test; if he succeeds, he leaps behind that cover and gains" +
            " the Prone condition.He is still hit by the attack, but benefits from the additional AP granted by the cover for that attack.";
        private readonly static string inquiryDiscription = "Skill Use: One hour or more, depending on the nature of the inquiries, the size of the group targeted, and information sought." +
            " Inquiry is used to gain information by asking questions, stimulating conversation, or simply eavesdropping—all essential for unravelling heresies and identifying those who " +
            "would act against Mankind. Unlike Charm or Intimidate, which focus on changing a character’s disposition or influencing specific individuals, Inquiry can focus on gaining " +
            "information from both individuals and large groups, and may involve a great deal of time and effort. One or two degrees of success reveals basic information about an area, " +
            "population group, or specific individuals, while additional degrees of success on a successful test allows the GM to impart more valuable or secretive information to his players. " +
            "/n The GM can call on a player to make an Inquiry test when:" +
            "/n • He is trying to track down a local crime lord in a hive." +
            "/n • He attempts to learn the attitudes of the local populace towards their leaders./n" +
            " • He seeks a specific type of location such as a shop or tavern.";
        private readonly static string interrogationDiscription = "Skill Use: One hour or more, depending on the invasiveness of the interrogation and the subject. " +
            "Interrogation allows a character to extract information from an unwilling subject. The application differs from brutal torture, which involves more physical damage." +
            "Rather, it represents skilled application of psychology, various devices, serums, and other, usually less physically-damaging, techniques.The GM may modify the difficulty" +
            " of the test according to the availability of tools, facilities and other conditions. This is always an Opposed test, pitting the character’s Interrogation skill against" +
            " an opponent’s Willpower. If the character wins the Opposed test, he gets one answer for each degree of success. If his opponent wins the Opposed test, the interrogator " +
            "gets nothing of worth. A roll with two or more degrees of failure inflicts 1d10 plus the interrogator’s Willpower bonus in damage to the subject, and prevents any further " +
            "interrogation for 1d5 days.If the interrogator suffers four or more degrees of failure, he deals the same damage and the subject gains a +30 bonus to Willpower tests made" +
            " to resist Interrogation at the hands of the character or his allies.Each Interrogation test inflicts one level of Fatigue on the target, regardless of success. " +
            "/n The GM can have a player make an Interrogation test when:" +
            "/n • He attempts to force an Imperial Adept to reveal hidden information about his superiors." +
            "/n • He is attempting to learn about battle plans from an Imperial Guard commander." +
            "/n • He seeks to have a cultist reveal a hidden meeting place.";
        private readonly static string intimidateDiscription = "Skill Use: Full Action. The Imperium of Man is constantly at war." +
            "Seditious fools across its reach and xenos races from outside its boundaries all work to bring about the downfall of humanity." +
            "It is not enough to stop those who have already taken action; it is also vital to prevent others from following these fools or" +
            " dabbling in matters far beyond their understanding.Fear often serves as the preferred tool for preventing insurrection and heresy. " +
            "The Intimidate skill is a measure of a character’s knack for instilling fear. He may use this ability to make someone perform an action against his will, " +
            "or extract information from an unwilling subject.It is distinguished from the Command skill largely by the authority that the acting character presents." +
            " When Intimidate is used against an opponent (such as to frighten him into doing the character’s bidding), it is an Opposed test. " +
            "Intimidate is opposed by Willpower." +
            "/n The GM can call on a player to use the Intimidate skill when:" +
            "/n • He wants someone to get out of his way." +
            "/n • He wants to coerce someone into acting a certain way." +
            "/n • He is trying to make an opponent back down from a fight.";
        private readonly static string logicDiscription = "Skill Use: 1 minute, or longer for particularly complex problems. " +
            "The Logic skill represents the ability to think rationally, solve puzzles, and dissect information clearly and quickly." +
            "It can be applied to analyse complex statistics, architectural anomalies, or even achieve some degree of understanding with regards to complex technologies. " +
            "This skill encompasses the character’s basic functional understanding of mathematics, physics, and engineering. Note that this does not include an understanding " +
            "of complex theories or the terminology involved with them—that would fall more commonly under Scholastic Lore. All characters have some inherent ability to exercise " +
            "Logic, observing cause and effect and making inferences regarding likely outcomes. In many instances, a character’s ability to comprehend logical phenomena might" +
            " be impeded by his belief systems, including his faith in the Imperial Creed or the Omnissiah. Characters who frequently need to identify or resolve complex " +
            "situations can hone this skill through frequent use. The variables involved in any problem determine the inherent difficulty of a Logic test. " +
            "If a character is provided with all of the necessary background information, a reasonably adept character should be able to successfully solve the problem. " +
            "If there are too many unknown factors, the problem might only be solved after uncovering additional clues, or through prodigious luck." +
            "/n The GM can call on a player to use the Logic skill when:" +
            "/n • He must solve a riddle or puzzle." +
            "/n • He is looking for clues in a vast amount of seemingly unrelated information." +
            "/n • He is trying to win at a game of chance." +
            "/n Special Use: Gambling - A character can use Logic when participating in games of chance rather than simply relying on blind luck." +
            "In a typical game, each participant wagers an amount, though these are typically the same, and makes an Opposed test with the Logic skill." +
            "The character with the most degrees of success or fewest degrees of failure wins the pot. However, this only covers gambling if the " +
            "character is attempting to win by playing the game at its basic level— analysing the odds and playing intelligently. " +
            "Gamblers often use bluffing, deception, and outright cheating in order to win.In this case, Deceive might be used to bluff or trick an opponent, " +
            "while Sleight of Hand could be used to palm cards or alter results. These would be opposed by Scrutiny and Awareness, respectively. " +
            "/n CiPhers and deCoding - A character can use the Logic skill to unravel ciphers and codes.This usually takes a great deal of time " +
            "(days or weeks of prolonged work) and the difficulty depends greatly on whether the character has a key or the number of examples of the cipher available." +
            "In general, these tests should be Difficult(–10) at the easiest, unless the cipher is already partially decoded or the character has a key available to aid his efforts.";
        private readonly static string medicaeDiscription = "Skill Use: Full Action. Medicae represents the ability to set broken bones, heal wounds, or even perform complicated" +
            " surgeries such as attaching cybernetics.The techniques involved in treatment may vary substantially based upon the character’s background." +
            " A character that learned basic survival skills on a death world might know substantially different treatment methods than one who dwelt within a forge world." +
            "Varied backgrounds often lead to changes in the expected outcomes for medical conditions and treatments. A terrible disease that is considered untreatable on a" +
            " hive world might have a routinely available herbal remedy on a feral world, for example. All characters who face frequent physical trauma achieve some degree of " +
            "competence in Medicae.This may simply be enough to bind their own wounds in order to avoid an easily-followed trail of blood. Those who specialise in this field" +
            " may be viewed as saviours by their patients. Alternatively, some may see the healers as blasphemers who have dabbled in treatments that might only be the province " +
            "of the Emperor or the Omnissiah. The Medicae skill often relies on certain tools for more complex procedures; even a simple medi-kit can make a significant difference" +
            " to the effects of this skill." +
            "/n The GM can call on a player to use the Medicae skill when:" +
            "/n • He wants to apply first aid to a wounded ally." +
            "/n • He wishes to diagnose an affliction and work out a suitable treatment to treat a fellow member of his warband." +
            "/n • He is trying to perform a surgical procedure such as the careful removal of a limb or organ, or replace the same with cybernetic devices." +
            "Special use: First Aid - A character trained in Medicae can use this skill to perform first aid, treating minor injuries suffered in the field of " +
            "operations by suturing lacerations, bandaging abrasions, and staunching punctured flesh. To perform first aid, a character must make a Challenging (+0)" +
            " Medicae test, with a –10 penalty if his patient is Heavily Damaged or a –10 penalty for every point of Critical damage if his patient is Critically Damaged. " +
            "If he succeeds, he removes an amount of damage from his patient equal to his Intelligence bonus, plus one additional point of damage per degree of success " +
            "he scores on the test (removing Critical damage before normal damage). A given individual can only be treated with first aid once every 24 hours, and only" +
            " so long as he is not also undergoing extended care." +
            "/n Extended Care - The Medicae skill can be used to perform extended care, treating a number of patients equal to an Acolyte’s Intelligence bonus, plus one " +
            "patient per assistant(trained or untrained) the Acolyte has on hand.For each patient beyond this number, he suffers a –10 penalty on his Medicae tests for" +
            " extended care. For each assistant trained in the Medicae skill assisting in the process, he gains a +10 bonus on these tests." +
            " At the end of each 24-hour period of extended care, the primary healer must perform an Ordinary (+10) Medicae test. If he succeeds, " +
            "his patients remove twice the normal amount of damage normally recovered by their natural rates of healing (removing Critical damage first). " +
            "On top of this, each patient removes one point of damage per degree of success the healer scores on his test, and one additional point of damage " +
            "per consecutive day of extended care they have received beyond the first 24-hour period. If he fails, none of his patients improve beyond their natural" +
            " rate of healing.Further, he must choose a number of patients under his care equal to his degrees of failure, starting with the most gravely injured " +
            "(first from among those who are Critically Damaged, then those who are Heavily Damaged, and then finally those who are only Lightly Damaged). " +
            "Each of these patients must make a Challenging (+0) Toughness test or suffer one point of damage per degree of failure, not reduced by Armour or Toughness." +
            "If this results in any Critical damage, the patient dies. " +
            "/n Diagnose - An Acolyte can also use the Medicae skill to diagnose disease and other ailments, both on " +
            "his fellow characters and also on large groups. On individuals, a successful skill test yields the name of the ailment and basic treatments.When used on groups," +
            " a successful skill test can prevent the spread of disease or mitigate the effects of malnutrition as determined by the Game Master and dependent on the nature" +
            " (and virulence) of the disease." +
            "/n Chem-use - The Medicae skill can be used to cover a character’s understanding of drugs, poisons, chemicals, and toxins.A skilled chymist can create and identify" +
            " such compounds, as well as know how best to use them either for medicinal effects or in combat against their enemies." +
            "Chem-Use is also useful in diagnosing those suffering from toxins and poisons, or finding antidotes to treat them. " +
            "/nApplying Poisons and Chemicals: Particularly virulent or dangerous chemicals might require a Medicae test to administer them to a patient or apply them to a weapon. " +
            "This test is usually Challenging (+0); failure by four or more degrees may indicate that something has gone seriously wrong with the dosage or application," +
            " and the applicant suffers the adverse effects of the chemical or poison. " +
            "/n Crafting: Medicae can be used to make all manner of drugs and poisons, from animal venom and healing unguents to complex drugs such as stimm or spook." +
            "The time, difficulty, and materials it takes to create these items are greatly dependent on their complexity, the kind of facility and equipment available, " +
            "and access to formulae or assistance. See the Crafting sidebar on page 97 for the kinds of items that can be created using Medicae. " +
            "/n Antidotes: A chymist may manufacture an antidote if he can identify the poison or toxin and has the right materials on hand.To create an antidote, " +
            "the character must have a sample of the poison in question or a sample of blood from the person he is trying to treat. The character must also have at " +
            "least a basic medi-kit.He then makes an Extended test requiring a number of degrees of success set by the GM, depending on the strength of the poison; " +
            "as a guideline this can be 4 for weak poisons, 7 for average poisons, and 10 for strong poisons. Creating an antidote takes 1d10 hours, and success nets" +
            " 2d10 doses for that specific poison.The Game Master can modify these tests depending on the materials available (granting bonuses for facilities, equipment, and assistants).";
        private readonly static string parryDiscription = "Skill Use: Reaction. When engaged in combat, avoiding an opponent’s assault is often every bit as crucial" +
            " as striking the critical blow.Parry is the ability to block attacks in close combat, deflecting them using one’s hands or weapons.An Acolyte targeted by melee attacks" +
            " can turn aside these attacks using the Parry skill.This is a Reaction (and as such can usually only be attempted once each turn) and can only be used against " +
            "close combat attacks from foes engaged with the character in melee.A success indicates that the attack has been parried and does not hit the character." +
            "In the case of attacks which cause multiple hits(such as those from a foe with the Lightning Attack talent) each degree of success a character achieves on his " +
            "Parry test discounts one hit from the attack.Any excess hits not discounted by Parrying are then applied to the character as normal." +
            "/n The GM can call on a player to use the Parry skill when:" +
            "/n • He is attacked in melee and wishes to deflect the blow.";
        private readonly static string psyniscienceDiscription = "Skill Use: Half Action. Those with the Psyniscience skill sense the currents and eddies of the Warp and Immaterium." +
            "Characters can use the skill to detect the presence or absence of Daemons and the use of psychic powers.Psyniscience also allows detection of psychic phenomena, disturbances, " +
            "voids, or other areas where the flow of the Immaterium has been unsettled or disrupted. The difficulty for a Psyniscience test is based upon the potency " +
            "of any nearby Warp activity.In general, the more powerful the activity, the easier it may be to sense.At the same time, by attempting to identify such a presence," +
            " a character must temporarily open his mind to its influence. Particularly potent threats may be able to seize this opportunity, and react aggressively to the probe. " +
            "While subtler activity is far less dangerous to the acting character, it is also far more difficult to sense. To purchase this skill, the character must have a special ability" +
            " stating he has access to it (such as the Psyker trait), reflecting his attunement to the Warp.Unless otherwise noted, he can use the Psyniscience skill to detect entities, " +
            "locales, and events up to a number of kilometres away equal to his Perception bonus. The GM can, though, alter this range depending on the situation." +
            "A character who is not a psyker can also use this skill, representing his ability to recognise the subtle phenomena, such as strange patterns of dust motes or odd sensory distortions," +
            " which often accompany psychic disturbances.The general results of Psyniscience tests are summarized on Table 3–4: Psyniscience Results." +
            "/n The GM can call on a player to use the Psyniscience skill when:" +
            "/n • He is hunting for the location of a Daemon." +
            "/n • He wishes to determine whether a psyker has used his powers recently in the area." +
            "/n • He is trying to find a weak point between realspace and the Immaterium." +
            "Psyniscience Results: 1 DoS - Awareness of Immaterium disruption or number of entities present; 2 DoS - Approximate direction of the Warp phenomena or creatures;" +
            " 3 DoS - Rough location of the Warp creatures or beings affecting the Immaterium; 4 DoS - Exact position of the unnatural creatures or psykers present.";
        private readonly static string scrutinyDiscription = "Skill Use: Half Action. The Scrutiny skill helps assess the people or objects an Acolyte encounters." +
            "A character can use this skill to determine an individual’s truthfulness, his motives, and appraise his personality and temperament." +
            " It can also be used to analyse an object or display in detail, determining information that may be hidden or simply not readily apparent. " +
            "This test may also be used when methodically searching an area or object for clues or other inconsistencies. It is characteristic of a mental analysis of the person" +
            " or object in question, to identify any inconsistencies between its appearance, signs of wear, and overall style.Any disparity can be a sign of other dangers;" +
            " one sewer section lacking the foetid odour of the rest may be just as troubling as a suspicious bulge beneath a suspect’s clothing." +
            " In general, Scrutiny is used to interpret hidden emotions, motivations, or details unnoticeable unless subjected to a careful analysis." +
            "Awareness is used when trying to spot items or individuals. Thus, while spotting someone hidden would be Awareness, and telling when someone is lying would be Scrutiny." +
            " Scrutiny is opposed by the Deceive skill." +
            "/n The GM can call on a player to use the Scrutiny skill when:" +
            "/n • He wants to tell if someone is lying." +
            "/n • He wants to collate information and conclusions from a complex report." +
            "/n • He is interpreting augur or auspex readings and determining what these results mean.";
        private readonly static string securityDiscription = "Skill Use: 1 minute, reduced by 10 seconds for each degree of success. " +
            "The Security skill deals with mastery of locks and safeguards, including breaking into secure places or protecting them from intrusion." +
            "A character with the Security skill is trained to bypass locks or defeat codes, whether using cogitators and tech against machine spirits " +
            "or simple mechanical devices against physical latches.Acolytes with Security are also able to safeguard systems and locales by making passive " +
            "defences more secure, and even setting traps for unwary intruders and thieves." +
            "/n The GM can call on a player to use the Security skill when:" +
            "/n • He wants to open a locked door." +
            "/n • He wishes to break into a cogitator and discover its secrets." +
            "/n • He is trying to lay traps for an ambush or to protect a camp." +
            "/n Special Use: traps - A character with the Security skill can fashion and set traps, given enough time and raw resources." +
            "Traps can range from hiding a live grenade under a corpse (set to explode when rolled over) to elaborate spiked pits, dead falls, " +
            "or rigged shotguns.The time, resources, and damage caused by these kinds of traps depend on the GM’s discretion and the materials involved" +
            "The chance that a trap will go off as planned or avoid the detection by its victims depends on the character’s Security skill." +
            "This is either a skill test(modified depending on circumstance or the complexity of the trap) made secretly by the Game Master to see" +
            " if it works, or an Opposed test against the victim’s Awareness to spot the trap before it goes off.";
        private readonly static string sleightOfHandDiscription = "Skill Use: Half Action, or can be performed as a Free Action with an additional –10 penalty." +
            " Acolytes use the Sleight of Hand skill for any task requiring a combination of deception and dexterity.A charlatan or confidence man utilises" +
            " very comparable skills to those of a pickpocket when committing his crimes.The test can substitute papers, remove jewellery, or obtain a target’s" +
            " oath-cog or ident-seal.Sleight of Hand also allows a character to conceal his actions when in plain sight, such as hiding weapons from someone searching his person." +
            " The difficulty of the test depends on the size of the object and the intensity of observation. This is always an Opposed test against the opponent’s Awareness or Scrutiny. " +
            "/n The GM can call on a player to use Sleight of Hand when:" +
            "/n • He attempts to steal something from the target’s pocket." +
            "/n • He seeks to palm evidence at a crime scene." +
            "/n • He tries to plant illegal narcotics into a suspect’s robes.";
        private readonly static string stealthDiscription = "Skill Use: Free Action as part of Movement. Stealth is a measure of a character’s ability to remain unnoticed" +
            " while moving through the dense crowds of a hive, the open croplands of an agri-world, or the blast craters of a scarred battlefield.In some environments," +
            " this requires the character to remain unseen, but in others it is far more important for the character to be inconspicuous.A character that can blend" +
            " in amongst the massed labourers of a manufactorum might be just as adept at infiltrating a complex as one who might scale the walls in the dead of night." +
            " An Acolyte with this skill can move silently or conceal himself from others, either to escape from his foes or take them by surprise." +
            " The difficulty for a Stealth test is generally based upon the environment where it is attempted, as well as the character’s outerwear," +
            " clothing, and armour. Some gear may assist a character in remaining unseen, though if this equipment is identified, it can often reveal the infiltrator’s true nature." +
            "In some instances, defenders might use abilities and equipment that have the potential to offset the character’s own equipment." +
            "In these cases, strategy and timing can be crucial to remaining undetected." +
            "When Stealth is used against an opponent (such as to hide from a foe or shadow a target) it is an Opposed test. Stealth opposes and is opposed by Awareness." +
            "/n The GM can call on a player to use the Stealth skill when:" +
            "/n • He wants to scout an enemy force without being detected." +
            "/n • He wants to sneak up on a foe and kill him quietly." +
            "/n • He wishes to follow someone without arousing suspicion." +
            "Special Use: shadowing -  Stealth can be used to shadow others and follow them unseen, either on foot, in vehicles, or even in shuttles and starships" +
            ".On foot it might involve using physical cover or the press of bodies coming off mid-shift labour; in a vehicle, techniques might include false turns" +
            " or using cargo-haulers as cover; aboard ships, it can entail the use of asteroids or other stellar objects, or even busy void routes around major planets." +
            "Stealth skill tests for shadowing are always Opposed tests against the opponent’s Awareness.A single Stealth skill test is sufficient to follow the opponent" +
            " unseen for 5 minutes per degree of success";
        private readonly static string survivalDiscription = "Skill Use: Full Action. The Survival skill is a measure of a character’s ability to subsist without" +
            " the support of civilisation.It is absolutely vital for those who dwell in the untamed wilds, far from the protection of fortified encampments or cities." +
            "Those who live within the urban jungles of underhives or city ruins must also achieve some mastery of this field, as they cannot depend upon reliable sources" +
            " of food and water.The knacks associated with this field often have applications even within structured society, especially for those with a more independent nature." +
            " A character with the Survival skill can live off the land, ride beasts, and predict weather with only a minimum of equipment and without the need for resupply or support." +
            "It can be used to create primitive items such as bows or blades, as well as basic clothing. Survival is also used to track prey (human or otherwise)" +
            " across all kinds of terrain by following the tell-tale signs they leave on the environment around them. The difficulty for a Survival test is associated with" +
            " the environmental constraints where it is made.If a planet’s atmosphere, fauna, and water are laced with deadly toxins," +
            " then finding the materials necessary for life could be nearly impossible.Use of the skill does not only indicate a knack" +
            " for finding life’s essentials; it can also indicate an aptitude for avoiding the deadliest of threats." +
            "/n The GM can call on a player to use the Survival skill when:" +
            "/n • He wants to find food or water in a hostile environment." +
            "/n • He wishes to start a fire with only handmade tools." +
            "/n • He is trying to track a foe across the depths of an underhive." +
            "Special Use: Crafting - Survival can be used to make all kinds of primitive devices, from cloaks and stone buildings to spears and armour." +
            "The time, difficulty, and materials it takes to create these items are greatly dependent on their complexity, the kind of workshop the character has, " +
            "and their access to designs or assistance.See the Crafting sidebar on page 97 for the kinds of items that an Acolyte can create using the Survival skill;" +
            " Tracking - A character can use the Survival skill to follow the signs left by his quarry, allowing him to hunt his targets down." +
            "Following obvious tracks does not require a skill test, and is considered part of a character’s movement. In instances where the time or elements have eroded" +
            " the signs or where the very environment makes seeing them difficult, such as darkness or fog, Survival skill tests are required.The modifiers for this test" +
            " depend on the condition of the traces and the tracker’s surroundings. A cunning or devious quarry might attempt to conceal or erase any tracks, for example," +
            " and in cases where an opponent has attempted to do this he should make an Opposed test against the prey’s Stealth;" +
            " Wrangling - Characters can tame, train, and potentially ride animals they encounter in their travels, from wild grox to noble warhorse breeds.Both taming" +
            " and training beasts are Extended tests, the duration of which is determined by the nature and temperament of the creature involved." +
            " Once an animal has been broken to its master’s will—or at least formed a partnership, for particularly strong-willed beasts—directing it or issuing commands is a Half Action." +
            "Wild animals, or those trained for hostility and aggression, can have their Disposition improved by 10 for every two degrees of success (up to a maximum of three levels)" +
            " by a Full Action use of this skill.GMs should impose modifiers for animals that have been particularly well-trained or those with strong Willpower and Intelligence. " +
            "Wrangling is of no use against cyber or psy-bonded animals, nor against any creatures with true sentience.See page 250 for additional rules concerning riding living beasts.";
        private readonly static string techUseDiscription = "Skill Use: 1 minute, or more for more complex systems. Tech-Use is a measure of an Acolyte’s ability to use" +
            " and interact with all manner of technological devices, from proper implementation of the Rites of Striking to the temperatures of holy lubricants a machine spirit" +
            " finds most soothing.It can also be used to build basic or complex technical devices with the right amount of time and materials.Tech-Use is more an understanding" +
            " of the Blessings of the Omnissiah and the rites of the Machine Cult than it is an actual knowledge of the science behind technology—in the 41st Millennium, however," +
            " this amounts to the same thing. The difficulty for this skill use is related to the complexity of the device and its design nature.A simple tool of Eldar origin," +
            " for example, might be every bit as dangerous as a venting plasma gun to the uninitiated.Conversely, no amount of familiarity with the blessed design principles" +
            " of a Warp engine can make it an easily understood device." +
            "/n The GM can call on a player to use the Tech-Use skill when:" +
            "/n • He wants to repair a broken weapon or vehicle." +
            "/n • He wishes to push a piece of technology beyond its normal capabilities or operating parameters." +
            "/n • He is trying to determine how a piece of unknown or unfamiliar technology works." +
            "Special Use: Crafting - Tech-Use can be used to make all kinds of technical devices, from simple clockwork and steam engines to advanced weaponry and armour." +
            "The time, difficulty, and materials it takes to create these items are greatly dependent on their complexity, the kind of workshop the character has," +
            " and his access to properly sanctified designs or Adeptus Mechanicus data-vaults.See the Crafting sidebar on page 97 for the kinds of things that can be created using Tech-Use;" +
            " Demolitions - Tech-Use can be used to determine the effectiveness of explosive devices, which is greatly dependent upon the skill with which they are placed." +
            "Success on a Tech-Use skill test indicates a character has successfully planted an explosive charge, and set it with the trigger of his choice." +
            "Possible triggers are only limited by a character’s imagination, and can include trip wires, timers, proximity sensors, or remote activators." +
            " Failure indicates that the explosives fail to go off when triggered, though the character does not know this until the time of activation." +
            "In some situations, the GM might desire withhold this information or even give false results based on the degrees of failure." +
            "Four or more degrees of failure indicate the character has set the device off prematurely and it explodes while being set!" +
            " Some tasks, such as rigging a building for demolition or bringing down a massive suspension bridge, require an Extended test." +
            " The GM should set the difficulty and duration depending on the extent of the undertaking.When placing explosives," +
            " make sure to note the total degrees of success and the die roll, as it might be used in an Opposed test if someone attempts to defuse a character’s hard work. " +
            "Defusing charges also falls under the Tech-Use skill, with an Opposed test against the Tech-Use skill test of the individual who set the explosives." +
            " Winning the test indicates that the bomb has been defused. Simple failure means that while the charge has not been disarmed, neither has it gone off." +
            "Four or more degrees of failure indicate the character has set off the device, suffering the consequences of the explosion." +
            " Defusing multiple charges or complex trigger mechanisms might require an Extended test, as determined by the GM.";
        #endregion Common Skills

        #region Specialized Skills
        #region CommonLore
        private readonly static string commonLoreDiscription = "Skill Use: Free Action. All Common Lore skills represent the common knowledge an " +
                "individual might know about the general information, procedures, divisions, traditions, famed individuals, and superstitions of a " +
                "particular world, group, organisation, or race.Such information is deeper than mere knowledge of the subject’s existence, and more " +
                "reflects a degree of familiarity that indicates a measure of dedicated interest in the area.This skill differs from Scholastic Lore, " +
                "which represents scholarly learning one might gain through study and research, and Forbidden Lore, which involves hidden or proscribed knowledge." +
                " Common Lore deals with basic information gained from prolonged exposure to a culture or area. Unlike some other skills, " +
                "Common Lore has multiple Specialisations." +
                "/n The GM can call on a player to use a Common Lore skill when: " +
                "/n • The GM feels the Player Character might know something about a current situation, location, or individual." +
                "/n • The Player Character wants to know a specific detail about a common subject.";
        private readonly static string adeptaSororitasLoreDiscription = "Adepta Sororitas: Knowledge of the women of the Adepta Sororitas and their spiritual " +
            "culture, as well as their highly specialised equipment.";
        private readonly static string adeptusArbitesLoreDiscription = "Adeptus Arbites: Knowledge of its various arms and sub-sects, including details of rank " +
            "structure, common procedures, and the basic tenets of Imperial Justice.";
        private readonly static string adeptusAstartesLoreDiscription = "Adeptus Astartes: Information concerning the physiologically and psychologically modified Space Marines, " +
            "the Imperium’s most potent defenders.Few outside their ranks gain such knowledge, which can include the culture of a Chapter and its history, wargear, " +
            "unusual physiology, and battle cants.";
        private readonly static string adeptusAstraTelepaticsLoreDiscription = "Adeptus Astra Telepathica: Knowledge of how psykers are gathered and sanctioned, including how Astropaths are used " +
            "throughout the Imperium, and the basics of astro-telepathy.";
        private readonly static string adeptusMechanicusLoreDiscription = "Adeptus Mechanicus: A general understanding of the symbols and practices that the Cult of the Machine God commonly uses.";
        private readonly static string administratumLoreDiscription = "Administratum: Broad knowledge of the labyrinthine workings, rules, traditions, and dictates of the Adeptus Administratum.";
        private readonly static string askelonSectorLoreDiscription = "Askellon Sector: Information concerning the basic layout and history of the sector, including Juno and the Grand Worlds, plus many of" +
            " the Tributary Worlds.";
        private readonly static string chartistCaptainsLoreDiscription = "Chartist Captains: Knowledge of the merchant vessels across Askellon, which complete centuries-long circuits through series of" +
            " neighbouring worlds as the primary means of Imperial commerce.";
        private readonly static string collegiaTitanicusLoreDiscription = "Collegia Titanicus: Familiarity with those who control the Battle Titans of the Adeptus Mechanicus, some of the most potent planet-bound " +
            "weapons known to the Imperium.";
        private readonly static string ecclesiarchyLoreDiscription = "Ecclesiarchy: Understanding of the structure of the Adeptus Ministorum and its role in the worship of the Emperor.";
        private readonly static string imperialCreedLoreDiscription = "Imperial Creed: Knowledge of the rites, practices, and personages of the Imperial Cult, the most common observances and festivals " +
            "in honour of the Emperor.";
        private readonly static string imperialGuardLoreDiscription = "Imperial Guard: Basic information about the ranking system, logistics, structure, and basic tactical and strategic practices of the " +
            "Imperial Guard, as well as particularly famed regiments.";
        private readonly static string imperialNavyLoreDiscription = "Imperial Navy: Basic information about the ranks, customs, uniforms, and particular traditions of the Imperial Navy, as well as " +
            "famous admirals and ships.";
        private readonly static string imperiumLoreDiscription = "Imperium: Knowledge of the segmenta, sectors, and best-known worlds of the Imperium.";
        private readonly static string navigatorsLoreDiscription = "Navigators: Information regarding these valued mutants who are essential for Warp travel and the Imperium’s survival, including the various" +
            " Navis Nobilite Houses operating within Askellon, their lineages, and methodologies.";
        private readonly static string planetaryDefenceForcesLoreDiscription = "Planetary Defence Forces: Information concerning a planet’s standing force dedicated to defending itself as well as assisting any nearby" +
            " Imperial systems.This includes composition, tactics, and equipment, which might vary substantially based on the culture and technological make-up of the world.";
        private readonly static string rogueTradersLoreDiscription = "Rogue Traders: Information concerning the many Rogue Trader dynasties operating within the sector and " +
            "beyond in search of profit and power.";
        private readonly static string scholaProgeniumLoreDiscription = "Schola Progenium: A strong familiarity with the Schola Progenium, which trains and indoctrinates the many Imperial orphans" +
            " and prepares them for lives of faithful service as elite troopers in the Militarum Tempestus, Commissars in the Officio Prefectus, or adepts in one of the Imperium’s" +
            " many other divisions.";
        private readonly static string techLoreDiscription = "Tech: An understanding of simple litanies and rituals to soothe and appease machine spirits.";
        private readonly static string underworldLoreDiscription = "Underworld: The Acolyte is familiar with basic criminal elements and groups, such as pickpockets, debt-carnivores, and the like.";
        private readonly static string warLoreDiscription = "War: Knowledge of great battles, notable commanders, heroes, and famous stratagems employed by those who fight in the endless battles for " +
            "and against the Imperium.";
        #endregion CommonLore
        #region ForbiddenLore
        private readonly static string forbiddenLoreDiscription = "Skill Use: Free Action. All Forbidden Lore skills represent information proscribed or hidden from the average Imperial citizen. " +
            "In many cases, it is a heinous crime to even possess such data and can quickly draw Inquisitorial attention (even if the possessor himself is working for an Inquisitor). " +
            "Forbidden Lore has several different Specialisations.These include all Common Lore and Scholastic Lore Specialisations, as each area also has blasphemous and dangerous" +
            " knowledge beyond what is generally known, or secrets the group obsessively keeps to itself." +
            " A successful Forbidden Lore test imparts information from the GM to the player.The GM may impart more information if the test scores additional degrees of success." +
            "/n The GM can have a player make a Forbidden Lore test when: " +
            "/n • He seeks information about potential cult activity." +
            "/n • He seeks to learn about the operations of the dreaded Eldar." +
            "/n • He seeks the proper procedure to summon a Daemon.";
        private readonly static string archeotechLoreDiscription = "Archaeotech: Knowledge of the great, lost tech devices of times past, and clues to their mysterious functions and purposes.";
        private readonly static string chaosSpaceMarinesLoreDiscription = "Chaos Space Marines: Information concerning those Adeptus Astartes who turned traitor, as well as the paths they embrace" +
            " and the equipment they use.";
        private readonly static string criminalCartelsAndSmugglersLoreDiscription = "Criminal Cartels and Smugglers: Information regarding organised groups that flout the Emperor’s" +
            " Law in Askellon, such as those engaging in the Faceless Trade of proscribed artefacts.";
        private readonly static string daemonologyLoreDiscription = "Daemonology: Terrible knowledge about some of the most infamous Warp entities and their twisted physical manifestations.";
        private readonly static string heresyLoreDiscription = "Heresy: Wisdom concerning acts and practices deemed anathema by the Imperium, plus the most contemptible heretics of history " +
            "and their infamous and deplorable acts.";
        private readonly static string theHorusHeresyAndTheLongWarLoreDiscription = "The Horus Heresy and the Long War: The origins and history of the 10,000 year long struggle between the forces" +
            " of the Ruinous Powers and the Imperium of Man.";
        private readonly static string inquisitionLoreDiscription = "Inquisition: Though Acolytes exist to serve an Inquisitor, knowing too much about their masters can be dangerous." +
            "Those who chose to study the history and nature of the Inquisition’s authority often are exposed to information that can forever ruin their minds.";
        private readonly static string mutantsLoreDiscription = "Mutants: The study of stable and unstable mutations within humanity, their cancerous influence and mutagenic " +
            "development over time, and some of the studies and tomes on the topic.";
        private readonly static string officioAssassinorumLoreDiscription = "Officio Assassinorum: This highly secretive agency exists to eliminate powerful, often singular threats to the Imperium," +
            " such as renegade planetary governors or apostate preachers.Acolytes who dare study the organisation may become familiar with their techniques and wargear.";
        private readonly static string piratesLoreDiscription = "Pirates: Knowledge of the scourges of the Warp lanes throughout Askellon, their tactics, infamous vessels, and notorious captains.";
        private readonly static string psykersLoreDiscription = "Psykers: Skill in identifying psykers, the effects of their unnatural powers, their dangers, and the general extent of their capabilities.";
        private readonly static string theWarpLoreDiscription = "The Warp: An understanding of the energy of the Immaterium, its interaction and interrelation with realspace, and how its tides " +
            "and eddies affect travel between the stars.";
        private readonly static string xenosLoreDiscription = "Xenos: Knowledge of the minor and major alien species known to the Imperium, the threat they pose to Mankind, and their general appearance.The character should specify which xenos race in which he is specialising (for example, Xenos–Craftworld Eldar or Xenos–Orks) as each is a different Specialisation.";
        #endregion ForbiddenLore
        #region Linguistics
        private readonly static string linguisticsDiscription = "Skill Use: Free Action. Linguistics represents the ability to speak, read, and write specific languages, codes, and " +
            "ciphers.Talents determine the languages a specific character knows, such as the Low Gothic of the masses, a feral world’s regional dialect, or even a xenos " +
            "tongue.When attempting to use a language the character knows, a Linguistics test is only required for a particularly difficult task, such as translating an" +
            " ancient version of the language or attempting to understand a garbled vox-intercept.Unknown languages, however, always require a Linguistics test to " +
            "understand on even a basic level. A character might need to speak with a human from a rediscovered world that was forgotten for millennia, or a researcher " +
            "may need to comprehend a xenos prophecy that predates the Great Crusade. Communicating with those whose language is foreign depends upon a character’s knowledge" +
            " and aptitude in the Linguistics skill. Two key factors play into determining the difficulty for a Linguistics test.The first is the complexity of the message; " +
            "simple greetings or warnings are far easier to interpret than more complex philosophical or religious concepts.Such communications might not necessitate a test, " +
            "even if the message is delivered in an entirely foreign tongue. The second difficulty factor is a measure of how foreign the language is to any the character knows." +
            "If the communication arrives in a pidgin or archaic dialect of the character’s native tongue, then translation could be challenging, but feasible." +
            " Conversely, if the message is in a language that a xenos race developed in an entirely different part of the galaxy, deciphering it without additional context might be impossible." +
            " Any character who has this a skill knows how to read and write in his primary language.For most of the Imperium, this is Low Gothic. " +
            "Note that all Acolytes are capable of basic communication in Low Gothic that would not require a skill test, such as normal conversation or reading standard Munitorum manuals." +
            " Linguistics is a Specialist skill and requires a player to choose a speciality when first taken.The Linguistics skill may be taken more than once, each time with a new speciality. " +
            "/nThe GM can call on a player to use the Linguistics skill when:" +
            "/n • He must decipher an archaic version of his language." +
            "/n • He wishes to compose a moving piece of prose." +
            "/n • He is trying to convey a message using subtle subtext or a limited vocabulary.";
        private readonly static string lowGothicLanguageDiscription = "Low Gothic: The common tongue of the Imperium, used by the countless billions of ordinary citizens.";
        private readonly static string highGothicLanguageDiscription = "High Gothic: The official language of the Imperium, used by Imperial officials, nobility, members of the Ecclesiarchy" +
            ", and those involved in high-level negotiations.";
        private readonly static string chapterRunesLanguageDiscription = "Chapter Runes: Each Chapter of the Adeptus Astartes has its own form of ciphers used to communicate between its warriors." +
            "These are closely-guarded secrets that are almost never taught to those outside the Chapter or Legion, and as such form a reliable way for those within the" +
            " Chapter or Legion to quickly identify each other.";
        private readonly static string chaosMarksLanguageDiscription = "Chaos Marks: There are countless symbols and signs that followers of the various Ruinous Powers use to share their dark secrets," +
            " each with its own subtle meaning or specific purpose.";
        private readonly static string eldarLanguageDiscription = "Eldar: Though no human can hope to capture the subtle nuances and sub-tones of this extremely complex and ancient language," +
            " it is enough to make one’s meaning clear.";
        private readonly static string imperialCodesLanguageDiscription = "Imperial Codes: Both the Imperial Navy and the Imperial Guard employ a battle language which comprises mostly numbers and acronyms." +
            "Incomprehensible to those who do not know its meaning, it allows them to quickly signal for reinforcements, identify enemies, and call down fire support or artillery barrages.";
        private readonly static string mercenaryCantLanguageDiscription = "Mercenary Cant: Many mercenary companies operate across Askellon, and each has an abbreviated, clipped battle language for orders" +
            " and commands.Though there are some commonalities, each is essentially unique.";
        private readonly static string necrontyrLanguageDiscription = "Necrontyr: The ancient and mechanical tones that the arisen Necron lords use to communicate with each other and their underlings as" +
            " part of their reconquest of the galaxy.";
        private readonly static string orkLanguageDiscription = "Ork: More grunts and physical violence than an actual language, it is possible for humans to speak and understand this brutal tongue, " +
            "though it is doubtful they would be able to survive a conversation.";
        private readonly static string technaLinguaLanguageDiscription = "Techna-Lingua: The language of the Adeptus Mechanicus, this binary cant has been optimised for rapid and efficient communication of technical data and servitor commands.";
        private readonly static string tauLanguageDiscription = "Tau: The language of the Tau Empire, spoken by the Tau themselves and understood by their multitude of alien subjects.";
        private readonly static string underworldLanguageDiscription = "Underworld: Crime lords have used ciphers for countless millennia, and their sophistication has only increased over time." +
            "Each organization, such as the Trade Sable, uses its own unique codes and glyphs to deter competition.";
        private readonly static string xenosMarkingLanguageDiscription = "Xenos Markings: Many aliens make extensive use of symbolism and icons.Understanding these markings allows a broad " +
            "understanding of their meaning such as where a race has marked its boundaries or areas marked as “dangerous.”";
        #endregion Linguistics
        #region Navigate
        private readonly static string navigateDiscription = "Skill Use: 1 minute for simple location; 1d5 hours for plotting courses or routes. " +
            "Acolytes charged with investigating threats against humanity must often travel to foreign locations in order to perform their holy duties." +
            "Heresy can lurk anywhere, hidden within a planet’s depths or even in the dank corridors of a voidcraft. At times, characters might even need " +
            "to travel among inhuman passages designed by xenos sensibilities.Navigate represents the ability to plot and follow a course from one point " +
            "to another, either on the surface of a planet or across the stars.In order to use this skill, the character must have access to a map of" +
            " the relevant region. Alternatively, Navigate can also be used to generate a map or to provide directions to someone unfamiliar with a route." +
            "In these cases, the character often starts with only a rough map or a blank parchment and must first construct the guide.The usability of" +
            " the product created is directly proportionate to the success on the test made to create it. All characters have some basic aptitude with maps, " +
            "though the subject matter and complexity is relative to their background. A feudal world character might recognise and understand the basics of " +
            "topographic maps that are completely foreign to a character that came to maturity on a void station. Similarly, a character that is familiar only " +
            "with travel inside an Imperial hive may be confounded when travelling without man-made landmarks, such as across a barren desert or a trackless sea.";
        private readonly static string surfaceNavigateDiscription = "Navigate (Surface) covers the ability to navigate across terrestrial environments from frozen" +
            " tundra to sweltering jungles, as well as navigating man-made environments such as hive cities or subterranean complexes. " +
            "/n The Game Master can call on a player to use the Navigate (Surface) skill when:" +
            "/n • He wants to make a journey across unfamiliar terrain." +
            "/n • He is lost and needs to get his bearings in a strange place." +
            "/n • He wishes to create a map showing the quickest route from one point to another.";
        private readonly static string stellarNavigateDiscription = "Navigate (Stellar) is the ability to plot a course across real space using stars, planets," +
            " and other celestial phenomena.This ability is primarily used aboard voidships moving through star systems." +
            "/n The Game Master can call on a player to use the Navigate (Stellar) skill when:" +
            "/n • He wants to make a journey within a star system." +
            "/n • He finds his ship stranded in an unknown region of space." +
            "/n • He wishes to find the quickest route from one location within a system (such as a planet) to another location in the system.";
        private readonly static string warpNavigateDiscription = "Navigate (Warp) is the rare ability to navigate not reality, but the shifting" +
            " and ever-changing vista of the Warp.This is most commonly used by those who must guide voidships with a Warp engine through" +
            " the Immaterium.This can range from Navigators using their mutant powers to plot courses using the Astronomican to normal humans" +
            " navigating shorter passages with Warp charts on familiar, stable routes." +
            "/n The Game Master can call on a player to use the Navigate (Warp) skill when:" +
            "/n • He must guide a starship through the Warp." +
            "/n • He needs to convert a journey into a Warp route chart.";
        #endregion Navigate
        #region Operate
        private readonly static string operateDiscription = "Skill Use: Half Action. The Operate skill represents a character’s aptitude to control and direct" +
            " all manner of vehicles and heavy equipment.Through the remarkable consistency of Standard Template Construction, the control systems used to operate" +
            " dramatically different vehicles are extremely similar.In many instances, this may be due to an interaction between the vehicle’s machine spirit and" +
            " the controlled systems used to direct the craft.In other cases, this is due to a simplification or approximation of controls, intended to reduce the" +
            " effort required to learn to operate the vehicle. All characters who come from worlds with any degree of technology learn the basics of operation." +
            "Essentially, the need to control a craft of some sort is largely unavoidable. However, familiarity with a basic civilian autocarriage is scarcely" +
            " adequate preparation for the nuanced art of flying an Imperial Valkyrie or firing a heavy macrobattery at an enemy voidship." +
            " A character with the Operate skill is adept at piloting, driving, or operating a particular type of vehicle or machine.No test is normally" +
            " required to pilot or drive a vehicle unless it is in a combat situation or other unusual circumstances such as extremely rough terrain or high speeds.";
        private readonly static string surfaceOperateDiscription = "Operate (Surface) covers the ability to pilot any vehicle that primarily operates on the surface of a planet." +
            "Groundcars, walkers, treaded vehicles, boats, and skimmers (hovering or flying vehicles that must remain very low to the ground) can all be piloted using Operate (Surface).  " +
            "/n The Game Master can call on a player to use the Operate (Surface) skill when:" +
            "/n • He is driving a vehicle in a combat situation." +
            "/n • He wishes to push his vehicle beyond its normal limits." +
            "/n • He is attempting to manoeuvre his bike through a crowded habway filled with civilians";
        private readonly static string aeronauticaOperateDiscription = "Operate(Aeronautica) covers the ability to pilot any vehicle that operates in three dimensions." +
            "This primarily covers atmospheric fliers such as the Imperial Navy Thunderbolt or Chaos Hellblade, but also includes small, manoeuvrable voidcraft such as landers," +
            " shuttles, starfighters, and bombers. Piloting jump packs that provide limited air mobility  is also covered by this ability." +
            "/n The GM can call on a player to use the Operate (Aeronautica) skill when:" +
            "/n • He is piloting a vehicle in a combat situation." +
            "/n • He wishes to fly his vehicle beyond its normal safe altitude." +
            "/n • He is trying to land an damaged Arvus Lighter in the midst of a meteor shower.";
        private readonly static string voidshipOperateDiscription = "Operate(Voidship) covers the ability to pilot large void-faring vessels that are often kilometres long and" +
            " millennia old.Any spacegoing vessel that requires a captain and large crew, and cannot be conceivably piloted by a single individual, is operated with this skill." +
            "/n The Game Master can call on a player to use the Operate (Voidship) skill when:" +
            "/n • He is manoeuvring a voidship." +
            "/n • He is overseeing the use of a macrobattery, orbital laser, or some other massive ship’s weapon.";
        #endregion Operate
        #region ScholasticLore
        private readonly static string scholasticLoreDiscription = "Skill Use: Free Action. All Scholastic Lore skills represent information that an Acolyte would need to learn in a formal" +
            " setting or institution of learning, whether from a knowledgeable mentor, an organisation, or even the careful study of rare tomes.Unlike Common Lore, this" +
            " information is not readily available to the average inhabitant of a planet, but differs from Forbidden Lore in that it is not proscribed from study." +
            "/n The Game Master can call on a player to use a Scholastic Lore skill when:" +
            "/n • He wishes to recount legends from humanity’s past." +
            "/n • He wishes to understand an obscure ruling made by a Judge of the Adeptus Arbites." +
            "/n • He seeks to identify a rare beast.";
        private readonly static string astromancyLoreDiscription = "Astromancy: A knowledge of stars, singularities, and the worlds around them, as well as theoretical understanding" +
            " of how to use magnascopes, astrolithic charts, and the like.";
        private readonly static string beastsLoreDiscription = "Beasts: An understanding of the genus and families of animals and familiarity with the characteristics and appearances" +
            " of the many semi-sentient creatures to be found across the sector.";
        private readonly static string bureaucracyLoreDiscription = "Bureaucracy: A familiarity with the rules and regulations involved with Askellian governments, particularly" +
            " the Adeptus Administratum, and their many and varied departments, bureaus, and polices.";
        private readonly static string chymistryLoreDiscription = "Chymistry: A knowledge of chemicals, their alchemical applications  in a number of uses, and their prevalence or scarcity" +
            " throughout the Imperium.";
        private readonly static string cryptologyLoreDiscription = "Cryptology: An understanding of codes, ciphers, cryptographs, secret languages, and numerical keys." +
            "This may be used to either create or decipher encryptions.";
        private readonly static string heraldyLoreDiscription = "Heraldry: A grasp of the principles and devices of heraldry, as well as a knowledge of the most common seals and heraldic" +
            " devices used by the Askellon’s noble houses and families.";
        private readonly static string imperialWarrantsLoreDiscription = "Imperial Warrants: Information concerning the establishment, legal scope, and use of the warrants granted to Rogue Traders," +
            " as well as the best-known and dynastic warrants of the Imperium.";
        private readonly static string judgementLoreDiscription = "Judgement: Knowledge of the proper sentences for the multitude of crimes and heresies punishable by Imperial law.";
        private readonly static string legendLoreDiscription = "Legend: Going beyond archaic knowledge, this encompasses momentous portions of mythic history, such as the Dark Age of Technology," +
            " the Age of Strife, the Great Crusade, and the Horus Heresy, retold in the form of epic, apocryphal fables.";
        private readonly static string numerologyLoreDiscription = "Numerology: An understanding of the mysterious link between numbers and the physical universe, " +
            "from low kharmic theory to the infamous Kappellax Correlation.";
        private readonly static string occultLoreDiscription = "Occult: An understanding of obscure and hermetic (though not clearly heretical) rituals, theories, " +
            "and superstitions, as well as the better-known mystical uses of occult items.";
        private readonly static string philisophyLoreDiscription = "Philosophy: Knowledge concerning the theories of thought, belief, existence, and other intangibles." +
            "As it also includes logic and debate, it may be used for crafting arguments or creating philosophical tracts.";
        private readonly static string tacticaImperialisLoreDiscription = "Tactica Imperialis: The codified military doctrines of the Imperial Guard and Imperial Navy," +
            " as well as other systems of troop deployment and battle techniques used by the Imperium.This knowledge may be used to devise a battle plan" +
            " or deduce the likely flow of war fought by Imperial forces.";
        #endregion ScholasticLore
        #region Trade
        private readonly static string tradeDiscription = "Skill Use: Variable depending on task and complexity. Trade skills allow Acolytes to practice a craft," +
            " from cooking a fine dinner to preserving a corpse.They can identify the work of particularly famous or infamous artisans, or recall information concerning" +
            " items of their trade. See the Crafting sidebar on page 97 for the kinds of things that can be created using Trade. Trade tests can represent the work of hours," +
            " weeks, or months depending on the complexity of the task at hand.However, tests that involve the examination of an item to recall information require a Full Action." +
            "/n The GM can call on a player to use the Trade skill when:" +
            "/n • He wants to prepare a sumptuous meal for a high-ranking planetary official." +
            "/n • He wishes to carve his sigil on a favoured chainsword." +
            "/n • He seeks to uncover the remains of a lost colony.";
        private readonly static string agriTradeDiscription = "Agri: Used to grow, care for, and harvest crops and animals.";
        private readonly static string archeologistTradeDiscription = "Archaeologist: Used to locate, examine, and analyse ancient ruins and artefacts.";
        private readonly static string armourerTradeDiscription = "Armourer: Used to design, upgrade, and forge weaponry, from personal arms to starship batteries.";
        private readonly static string astrographerTradeDiscription = "Astrographer: Used to create two- and three-dimensional representations of stellar locations and Warp routes.";
        private readonly static string chymistTradeDiscription = "Chymist: Used to create poisons, drugs, and a wide variety of other compounds.";
        private readonly static string cryptographerTradeDiscription = "Cryptographer: Used to create or decode complicated ciphers, codes, and other puzzles.";
        private readonly static string cookTradeDiscription = "Cook: Used to cook meals and determine if scavenged food is edible.";
        private readonly static string exploratorTradeDiscription = "Explorator: Used in the exploration of unknown stellar regions.";
        private readonly static string linguistTradeDiscription = "Linguist: Used to learn or decipher new languages, both spoken and written, and even create new ones in some cases.";
        private readonly static string loremancerTradeDiscription = "Loremancer: Used to recount events in a variety of ways, from dry recitations or texts to epic operas or statuary.";
        private readonly static string morticatorTradeDiscription = "Morticator: Used to prepare, preserve, and often render down corpse remains into ingredients for a variety of preparations.";
        private readonly static string performancerTradeDiscription = "Performancer: Used to perform for audiences in a variety of entertaining art forms, often using dance, song, and poetry.";
        private readonly static string prospectorTradeDiscription = "Prospector: Used to find and identify valuable minerals.";
        private readonly static string scrimshawerTradeDiscription = "Scrimshawer: Used to inscribe patterns, text, and art onto a variety of materials.";
        private readonly static string sculptorTradeDiscription = "Sculptor: Used to create inspiring works of art in stone, metal, and other materials, often as part of Imperial edifices.";
        private readonly static string shipwrightTradeDiscription = "Shipwright: Used to design, upgrade, and manufacture void-capable vessels.";
        private readonly static string soothsayerTradeDiscription = "Soothsayer: Used to “foretell” the future by a number of interpretative arts, though its effectiveness is suspect.";
        private readonly static string technomantTradeDiscription = "Technomat: Used to maintain and repair technological devices, but through rote memorization rather than true understanding or comprehension.";
        private readonly static string voidfarerTradeDiscription = "Voidfarer: Used in the day-to-day operation, logistics, and defence of starships.";
        #endregion Trade
        #endregion Specialized Skills
        #endregion Discriptions

        /// <summary>
        /// Collection of skills
        /// </summary>
        internal static ObservableCollection<AbstractSkill> CommonSkills { get; } = new ObservableCollection<AbstractSkill>
        {
            new CommonSkill(SkillName.Acrobatics, AptitudeName.Agility, AptitudeName.General){ Discription = acrobaticsDiscription },
            new CommonSkill(SkillName.Athletics, AptitudeName.Strength, AptitudeName.General){ Discription = athleticsDiscription },
            new CommonSkill(SkillName.Awarness, AptitudeName.Perception, AptitudeName.Fieldcraft){ Discription = awarnessDiscription },
            new CommonSkill(SkillName.Charm, AptitudeName.Fellowship, AptitudeName.Social){ Discription = charmDiscription },
            new CommonSkill(SkillName.Command, AptitudeName.Fellowship, AptitudeName.Leadship){ Discription = commandDiscription },
            new CommonSkill(SkillName.Commerce, AptitudeName.Intelligence, AptitudeName.Knowledge){ Discription = commerceDiscription },
            new CommonSkill(SkillName.Deceive, AptitudeName.Fellowship, AptitudeName.Social){ Discription = deceiveDiscription },
            new CommonSkill(SkillName.Dodge, AptitudeName.Agility, AptitudeName.Defence){ Discription = dodgeDiscription },
            new CommonSkill(SkillName.Inquiry, AptitudeName.Fellowship, AptitudeName.Social){ Discription = inquiryDiscription },
            new CommonSkill(SkillName.Interrogation, AptitudeName.Willpower, AptitudeName.Social) {Discription = interrogationDiscription },
            new CommonSkill(SkillName.Intimidate, AptitudeName.Strength, AptitudeName.Social){ Discription = intimidateDiscription },
            new CommonSkill(SkillName.Logic, AptitudeName.Intelligence, AptitudeName.Knowledge){ Discription = logicDiscription },
            new CommonSkill(SkillName.Medicae, AptitudeName.Intelligence, AptitudeName.Fieldcraft){ Discription = medicaeDiscription },
            new CommonSkill(SkillName.Parry, AptitudeName.Weapon_Skill, AptitudeName.Defence){ Discription = parryDiscription },
            new CommonSkill(SkillName.Psyniscience, AptitudeName.Perception, AptitudeName.Psyker){ Discription = psyniscienceDiscription },
            new CommonSkill(SkillName.Scrutiny, AptitudeName.Perception, AptitudeName.General) { Discription = scrutinyDiscription },
            new CommonSkill(SkillName.Security, AptitudeName.Intelligence, AptitudeName.Tech){ Discription = securityDiscription },
            new CommonSkill(SkillName.Sleght_of_Hand, AptitudeName.Agility, AptitudeName.Knowledge){ Discription = sleightOfHandDiscription },
            new CommonSkill(SkillName.Stealth, AptitudeName.Agility, AptitudeName.Fieldcraft){ Discription = stealthDiscription },
            new CommonSkill(SkillName.Survival, AptitudeName.Perception, AptitudeName.Fieldcraft){ Discription = survivalDiscription },
            new CommonSkill(SkillName.Tech_Use, AptitudeName.Intelligence, AptitudeName.Tech){ Discription = techUseDiscription },
        };

        internal static ObservableCollection<AbstractSkill> SpecializedSkills { get; } = new ObservableCollection<AbstractSkill>
        {
            #region CommonLore
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adepta_Sororitas.ToString(), adeptaSororitasLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = adeptaSororitasLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Arbites.ToString(), adeptusArbitesLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = adeptusArbitesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astra_Telepatica.ToString(), adeptusAstraTelepaticsLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = adeptusAstraTelepaticsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Mechanicus.ToString(), adeptusMechanicusLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = adeptusMechanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Administratum.ToString(), administratumLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = administratumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Askelon_Sector.ToString(), askelonSectorLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = askelonSectorLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Chartist_Captains.ToString(), chartistCaptainsLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = chartistCaptainsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Collegia_Titanicus.ToString(), collegiaTitanicusLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = collegiaTitanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Ecclesiarchy.ToString(), ecclesiarchyLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = ecclesiarchyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astartes.ToString(), adeptusAstartesLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = adeptusAstartesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Creed.ToString(), imperialCreedLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = imperialCreedLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.imperial_Guard.ToString(), imperialGuardLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = imperialGuardLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Navy.ToString(), imperialNavyLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = imperialNavyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperium.ToString(), imperiumLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = imperiumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Navigators.ToString(), navigatorsLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = navigatorsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Planetary_Defence_Forces.ToString(), planetaryDefenceForcesLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = planetaryDefenceForcesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Rogue_Traders.ToString(), rogueTradersLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = rogueTradersLoreDiscription
            },
             new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Schola_Progenium.ToString(), scholaProgeniumLoreDiscription)
             {
                 Discription = commonLoreDiscription,
                SpecializationDiscription = scholaProgeniumLoreDiscription
             },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Tech.ToString(), techLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = techLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Underworld.ToString(), underworldLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = underworldLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Common_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.War.ToString(), warLoreDiscription)
            {
                Discription = commonLoreDiscription,
                SpecializationDiscription = warLoreDiscription
            },
            #endregion CommonLore
            #region ScholasticLore
            #region CommonSpicializations
             new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adepta_Sororitas.ToString(), adeptaSororitasLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = adeptaSororitasLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Arbites.ToString(), adeptusArbitesLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = adeptusArbitesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astra_Telepatica.ToString(), adeptusAstraTelepaticsLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = adeptusAstraTelepaticsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Mechanicus.ToString(), adeptusMechanicusLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = adeptusMechanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Administratum.ToString(), administratumLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = administratumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Askelon_Sector.ToString(), askelonSectorLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = askelonSectorLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Chartist_Captains.ToString(), chartistCaptainsLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = chartistCaptainsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Collegia_Titanicus.ToString(), collegiaTitanicusLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = collegiaTitanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Ecclesiarchy.ToString(), ecclesiarchyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = ecclesiarchyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astartes.ToString(), adeptusAstartesLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = adeptusAstartesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Creed.ToString(), imperialCreedLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = imperialCreedLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.imperial_Guard.ToString(), imperialGuardLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = imperialGuardLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Navy.ToString(), imperialNavyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = imperialNavyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperium.ToString(), imperiumLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = imperiumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Navigators.ToString(), navigatorsLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = navigatorsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Planetary_Defence_Forces.ToString(), planetaryDefenceForcesLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = planetaryDefenceForcesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Rogue_Traders.ToString(), rogueTradersLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = rogueTradersLoreDiscription
            },
             new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Schola_Progenium.ToString(), scholaProgeniumLoreDiscription)
             {
                 Discription = scholasticLoreDiscription,
                SpecializationDiscription = scholaProgeniumLoreDiscription
             },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Tech.ToString(), techLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = techLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Underworld.ToString(), underworldLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = underworldLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.War.ToString(), warLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = warLoreDiscription
            },
            #endregion CommonSpicializations
            #region ScholasticSpecializations
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Astromancy.ToString(), astromancyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = astromancyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Beasts.ToString(), beastsLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = beastsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Bureaucracy.ToString(), bureaucracyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = bureaucracyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Chymistry.ToString(), chymistryLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = chymistryLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Cryptology.ToString(), cryptologyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = cryptologyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Heraldy.ToString(), heraldyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = heraldyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Imperial_Warrants.ToString(), imperialWarrantsLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = imperialWarrantsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Judgement.ToString(), judgementLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = judgementLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Legend.ToString(), legendLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = legendLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Numerology.ToString(), numerologyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = numerologyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Occult.ToString(), occultLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = occultLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Philisophy.ToString(), philisophyLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = philisophyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Scholastic_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Tactica_Imperialis.ToString(), tacticaImperialisLoreDiscription)
            {
                Discription = scholasticLoreDiscription,
                SpecializationDiscription = tacticaImperialisLoreDiscription
            },
            #endregion ScholasticSpecializations
            #endregion ScholasticLore
            #region ForbiddenLore
            #region CommonSpicializations
             new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adepta_Sororitas.ToString(), adeptaSororitasLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = adeptaSororitasLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Arbites.ToString(), adeptusArbitesLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = adeptusArbitesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astra_Telepatica.ToString(), adeptusAstraTelepaticsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = adeptusAstraTelepaticsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Mechanicus.ToString(), adeptusMechanicusLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = adeptusMechanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Administratum.ToString(), administratumLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = administratumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Askelon_Sector.ToString(), askelonSectorLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = askelonSectorLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Chartist_Captains.ToString(), chartistCaptainsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = chartistCaptainsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Collegia_Titanicus.ToString(), collegiaTitanicusLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = collegiaTitanicusLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Ecclesiarchy.ToString(), ecclesiarchyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = ecclesiarchyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Adeptus_Astartes.ToString(), adeptusAstartesLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = adeptusAstartesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Creed.ToString(), imperialCreedLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = imperialCreedLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.imperial_Guard.ToString(), imperialGuardLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = imperialGuardLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperial_Navy.ToString(), imperialNavyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = imperialNavyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Imperium.ToString(), imperiumLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = imperiumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Navigators.ToString(), navigatorsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = navigatorsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Planetary_Defence_Forces.ToString(), planetaryDefenceForcesLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = planetaryDefenceForcesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Rogue_Traders.ToString(), rogueTradersLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = rogueTradersLoreDiscription
            },
             new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Schola_Progenium.ToString(), scholaProgeniumLoreDiscription)
             {
                 Discription = forbiddenLoreDiscription,
                SpecializationDiscription = scholaProgeniumLoreDiscription
             },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Tech.ToString(), techLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = techLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.Underworld.ToString(), underworldLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = underworldLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                CommonLoreSpecializations.War.ToString(), warLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = warLoreDiscription
            },
            #endregion CommonSpicializations
            #region ScholasticSpecializations
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Astromancy.ToString(), astromancyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = astromancyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Beasts.ToString(), beastsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = beastsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Bureaucracy.ToString(), bureaucracyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = bureaucracyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Chymistry.ToString(), chymistryLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = chymistryLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Cryptology.ToString(), cryptologyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = cryptologyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Heraldy.ToString(), heraldyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = heraldyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Imperial_Warrants.ToString(), imperialWarrantsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = imperialWarrantsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Judgement.ToString(), judgementLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = judgementLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Legend.ToString(), legendLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = legendLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Numerology.ToString(), numerologyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = numerologyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Occult.ToString(), occultLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = occultLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Philisophy.ToString(), philisophyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = philisophyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ScholasticLoreSpecializations.Tactica_Imperialis.ToString(), tacticaImperialisLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = tacticaImperialisLoreDiscription
            },
            #endregion ScholasticSpecializations
            #region ForbiddenSpecializations
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Archeotech.ToString(), archeotechLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = archeotechLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Criminal_Cartels_and_Smugglers.ToString(), criminalCartelsAndSmugglersLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = criminalCartelsAndSmugglersLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Daemonolige.ToString(), daemonologyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = daemonologyLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Heresy.ToString(), heresyLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = heresyLoreDiscription },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Inquisitions.ToString(), inquisitionLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = inquisitionLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Mutants.ToString(), mutantsLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = mutantsLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Officio_Assassinorum.ToString(), officioAssassinorumLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = officioAssassinorumLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Pirates.ToString(), piratesLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = piratesLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Psykers.ToString(), psykersLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = psykersLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.The_Horus_Heresy_and_the_Lond_War.ToString(), theHorusHeresyAndTheLongWarLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = theHorusHeresyAndTheLongWarLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.The_Warp.ToString(), theWarpLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = theWarpLoreDiscription
            },
            new SpecializedSkill(skillName:SkillName.Forbidden_Lore,AptitudeName.Intelligence, AptitudeName.Knowledge,
                ForbiddenLoreSpecializations.Xenos.ToString(), xenosLoreDiscription)
            {
                Discription = forbiddenLoreDiscription,
                SpecializationDiscription = xenosLoreDiscription
            },
            #endregion ForbiddenSpecializations
            #endregion ForbiddenLore
            #region Operate
            new SpecializedSkill(skillName:SkillName.Operate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                OperateSpecializations.Aeronautica.ToString(), aeronauticaOperateDiscription)
            {
                Discription = operateDiscription,
                SpecializationDiscription = aeronauticaOperateDiscription
            },
            new SpecializedSkill(skillName:SkillName.Operate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                OperateSpecializations.Surface.ToString(), surfaceOperateDiscription)
            {
                Discription = operateDiscription,
                SpecializationDiscription = surfaceOperateDiscription
            },
            new SpecializedSkill(skillName:SkillName.Operate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                OperateSpecializations.Voidship.ToString(), voidshipOperateDiscription)
            {
                Discription = operateDiscription,
                SpecializationDiscription = voidshipOperateDiscription
            },
            #endregion Operate
            #region Navigate
            new SpecializedSkill(skillName:SkillName.Navigate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                NavigateSpecializations.Stellar.ToString(), stellarNavigateDiscription)
            {
                Discription = navigateDiscription,
                SpecializationDiscription = stellarNavigateDiscription
            },
            new SpecializedSkill(skillName:SkillName.Navigate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                NavigateSpecializations.Surface.ToString(), surfaceNavigateDiscription)
            {
                Discription = navigateDiscription,
                SpecializationDiscription = surfaceNavigateDiscription
            },
            new SpecializedSkill(skillName:SkillName.Operate,AptitudeName.Agility, AptitudeName.Fieldcraft,
                NavigateSpecializations.Warp.ToString(), warpNavigateDiscription)
            {
                Discription = navigateDiscription,
                SpecializationDiscription = warpNavigateDiscription
            },
            #endregion Navigate
            #region Linguistics
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Chaos_Marks.ToString(), chaosMarksLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Chapter_Runes.ToString(), chapterRunesLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Eldar.ToString(), eldarLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.High_Gothic.ToString(), highGothicLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Imperial_Codes.ToString(), imperialCodesLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Low_Gothic.ToString(), lowGothicLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Mercenary_Cant.ToString(), mercenaryCantLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Necrontyr.ToString(), necrontyrLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Ork.ToString(), orkLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Tau.ToString(), tauLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Techna_Lingua.ToString(), technaLinguaLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Underworld.ToString(), underworldLanguageDiscription){ Discription = linguisticsDiscription },
            new SpecializedSkill(skillName:SkillName.Linguistics,AptitudeName.Intelligence, AptitudeName.General,
                LinguisticSpecializations.Xenos_Markings.ToString(), xenosMarkingLanguageDiscription){ Discription = linguisticsDiscription },
            #endregion Linguistics
            #region Trades
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Agri.ToString(), agriTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Archeologist.ToString(), archeologistTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Armourer.ToString(), armourerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Astrographer.ToString(), astrographerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Chymist.ToString(), chymistTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Cook.ToString(), cookTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Cryptographer.ToString(), cryptographerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Explorator.ToString(), exploratorTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Linguist.ToString(), linguistTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Loremancer.ToString(), loremancerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Morticator.ToString(), morticatorTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Performancer.ToString(), performancerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Prospector.ToString(), prospectorTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.ScrimShawer.ToString(), scrimshawerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Sculptor.ToString(), sculptorTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Shipwright.ToString(), shipwrightTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Soothsayer.ToString(), soothsayerTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Technomant.ToString(), technomantTradeDiscription){ Discription = tradeDiscription },
            new SpecializedSkill(skillName:SkillName.Trade,AptitudeName.Intelligence, AptitudeName.General,
                TradeSpecializations.Voidfarer.ToString(), voidfarerTradeDiscription){ Discription = tradeDiscription },
            #endregion Trades
        };


    }
}
