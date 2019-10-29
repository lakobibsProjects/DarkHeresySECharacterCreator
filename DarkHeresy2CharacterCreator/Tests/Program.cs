using DarkHeresy2CharacterCreator.Model;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using DarkHeresy2CharacterCreator.Model.GeneralSuppliment.Collections;
using DarkHeresy2CharacterCreator.Model.Talents;
using System;
using System.Collections.ObjectModel;
using System.Reflection.PortableExecutable;

namespace Tests
{
    class Program
    {
        private static string ambidextrousDiscription = "Ambidextrous";

        static void Main(string[] args)
        {
            DoSomething();
        }

        private static void DoSomething()
        {
            //printTalentList();
            //printTalent();
            /*foreach(var t in TestTalentList.Talents)
            {
                Console.WriteLine(t.Name);
            }*/
            ObservableCollection<Talent> observableCollection = TalentList.Talents;
            //TalentList.InitializePrepeqiosites();
            foreach (var item in observableCollection)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine();

            }
            Talent Ambidextrous = new Talent(TalentName.Ambidextrous.ToString(), ambidextrousDiscription, AptitudeName.Weapon_Skill, AptitudeName.Balistic_Skill, 1)
            {
                //Prerequisites = { }
                //Prerequisites = { (Characteristics.CharacteristicList.Characteristics.FirstOrDefault(p => p.Name == Characteristics.CharacteristicName.Agility) as IPrerequisitable, 30) }
            };


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
