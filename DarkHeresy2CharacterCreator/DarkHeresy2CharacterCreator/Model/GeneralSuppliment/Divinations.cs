using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.GeneralSuppliment
{
    /// <summary>
    /// Instantiate logic of divination
    /// </summary>
    public class Divinations
    {
        private string prophecy;
        private string effect;

        public string Effect
        {
            get { return effect; }
            set { effect = value; }
        }

        public string Prophecy
        {
            get { return prophecy; }
            set { prophecy = value; }
        }

        /// <summary>
        /// Return divination
        /// </summary>
        /// <param name="roll">result of roll of d100</param>

        public Divinations(int roll)
        {
            if (roll < 1 || roll > 100)
                throw new ArgumentException("Divination cannot exceed 100 or been lower than 1");
            if (roll == 1)
            {
                Prophecy = "Mutation without, corruption within.";
                Effect = "Roll once on Table 8–15: Malignancies and apply the result.";
                return;
            }
            if (roll < 6)
            {
                Prophecy = "Trust in your fear.";
                Effect = "Increase this character’s Perception by 5, He also gains the Phobia Mental Disorder.";
                return;
            }
            if (roll < 10)
            {
                Prophecy = "Humans must die so that humanity can endure.";
                Effect = "This character gains the Jaded talent. If he already possesses this talent, increase his Willpower characteristic by 2 instead.";
                return;
            }
            if (roll < 14)
            {
                Prophecy = "The pain of the bullet is ecstasy compared to damnation.";
                Effect = "Reduce this character's Agility characteristic by 3. The first time this character suffers Critical damage each session, roll 1d10." +
                    "On a result of 10, he does not suffer any Critical Effects, though the damage still counts as Critical damage.";
                return;
            }
            if (roll < 18)
            {
                Prophecy = "Be a boon to your allies and the bane of your enemies.";
                Effect = "This character gains the Hatred (choose any one) talent. If he already possessed this talent, increase his Strength characteristic by 2 instead.";
                return;
            }
            if (roll < 22)
            {
                Prophecy = "The wise learn from the deaths of others.";
                Effect = "Increase this character's Agility or Intelligence Characteristic by 3. Reduce his Weapon Skill or Ballistic Skill characteristic by 3.";
                return;
            }
            if (roll < 26)
            {
                Prophecy = "Kill the alien before it can speak its lies.";
                Effect = "This character gains the Quick Draw talent. If he already possesses this talent, increase his Agility characteristic by 2 instead.";
                return;
            }
            if (roll < 30)
            {
                Prophecy = "Truth is subjective.";
                Effect = "Increase this character's Perception characteristic by 3." +
                    " The first time he would gain 1 or more Corruption points each session, he gains that amount plus 1 instead.";
                return;
            }
            if (roll < 34)
            {
                Prophecy = "Thought begets Heresy.";
                Effect = "Reduce this character's Intelligence characteristic by 3. The first time he would gain 1 or more Corruption points each session," +
                    " he reduces that amount by 1(to a minimum of 0) instead.";
                return;
            }
            if (roll < 39)
            {
                Prophecy = "Heresy begets Retribution.";
                Effect = "Increase this character's Fellowship or Strength characteristic by 3. Reduce his Toughness or Willpower characteristic by 3.";
                return;
            }
            if (roll < 44)
            {
                Prophecy = "A mind without purpose wanders in dark places.";
                Effect = "When gaining Mental Disorders, the character may choose to gain a new Disorder instead of increasing the severity of an existing Disorder.";
                return;
            }
            if (roll < 50)
            {
                Prophecy = "If a job is worth doing, it is worth dying for.";
                Effect = "Increase this character's Toughness or Willpower characteristic by 3. Reduce his Fellowship or Strength characteristic by 3.";
                return;
            }
            if (roll < 55)
            {
                Prophecy = "Dark dreams lie upon the heart.";
                Effect = "Whenever this character would roll on Table 8–15: Malignancies, he may instead select any one result and gain that Malignancy.";
                return;
            }
            if (roll < 60)
            {
                Prophecy = "Violence solves everything.";
                Effect = "Increase this character's Weapon Skill or Ballistic Skill characteristic by 3. Reduce his Agility or Intelligence characteristic by 3.";
                return;
            }
            if (roll < 64)
            {
                Prophecy = "Ignorance is a wisdom of its own.";
                Effect = "Reduce this character's Perception characteristic by 3. The first time he would gain 1 or more Insanity points each session," +
                    " he reduces that amount by 1(to a minimum of 0) instead.";
                return;
            }
            if (roll < 68)
            {
                Prophecy = "Only the insane have strength enough to prosper.";
                Effect = "Increase this character's Willpower characteristic by 3. The first time he would gain 1 or more Insanity points each session, he gains that amount plus 1 instead.";
                return;
            }
            if (roll < 72)
            {
                Prophecy = "A suspicious mind is a healthy mind.";
                Effect = "Increase this character’s Perception characteristic by 2. Additionally, he may re-roll Awareness tests to avoid being Surprised.";
                return;
            }
            if (roll < 76)
            {
                Prophecy = "Suffering is an unrelenting instructor.";
                Effect = "Reduce this character's Toughness characteristic by 3. The first time that this character suffers any damage each session," +
                    " he gains a +20 bonus to the next test he makes before the end of his next turn.";
                return;
            }
            if (roll < 80)
            {
                Prophecy = "The only true fear is dying without your duty done.";
                Effect = "This character gains the Resistance (Cold, Heat, or Fear) talent. If he already possesses this talent, increase his Toughness characteristic by 2 instead.";
                return;
            }
            if (roll < 84)
            {
                Prophecy = "Only in death does duty end.";
                Effect = "The first time this character would suffer Fatigue each session, he suffers that amount of Fatigue minus 1(to a minimum of 0) instead.";
                return;
            }
            if (roll < 88)
            {
                Prophecy = "Innocence is an illusion.";
                Effect = "This character gains the Keen Intuition talent. If he already possesses this talent, increase his Intelligence characteristic by 2 instead.";
                return;
            }
            if (roll < 92)
            {
                Prophecy = "To war is human.";
                Effect = "This character gains the Dodge skill as a Known skill (rank 1). If he already possesses this skill, increase his Agility characteristic by 2 instead.";
                return;
            }
            if (roll < 96)
            {
                Prophecy = "There is no substitute for zeal.";
                Effect = "This character gains the Clues from the Crowds talent. If he already possesses this talent, increase his Fellowship characteristic by 2 instead.";
                return;
            }
            if (roll < 100)
            {
                Prophecy = "Even one who has nothing can still offer his life.";
                Effect = "When this character burns Fate threshold to survive a lethal injury, roll 1d10. On a result of 10," +
                    " he survives whatever grievous wound would have killed him but does not reduce his Fate threshold.";
                return;
            }
            if (roll == 100)
            {
                Prophecy = "Do not ask why you serve. Only ask how.";
                Effect = "Increase this character's Fate threshold by 1.";
                return;
            }
        }
    }
}
