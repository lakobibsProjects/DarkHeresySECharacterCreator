using DarkHeresy2CharacterCreator.Model.Talents;
using System;

namespace Tests
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DoSomething();
        }

        private static void DoSomething()
        {
            //printTalentList();
            //printTalent();
            foreach(var t in TestTalentList.Talents)
            {
                Console.WriteLine(t.Name);
            }
                
        }

        private static void printTalent()
        {
            Talent talent = new Talent("newTalent", "discription", DarkHeresy2CharacterCreator.Model.AptitudeName.Agility, DarkHeresy2CharacterCreator.Model.AptitudeName.Balistic_Skill, 2);
            Console.WriteLine(talent.Name);
        }

        private static void printTalentList()
        {
            var temp = TalentList.Talents;
            foreach (var t in temp)
                Console.WriteLine(t.Name);
        }
    }
}
