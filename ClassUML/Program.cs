using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GameCharacters, MagicUsingCharacters, Wizards, and Warriors");
            MakeLineSpace(1);
            
            List<GameCharacter> gameCharacters = new List<GameCharacter>
            {
                new Wizard("Gondolf",2,9,190,8), new Warrior("Canon",8,3,"Greatsword"),
                new Wizard("Perry Hotter",3,8,140,6), new Wizard("Mirlen", 1,10,205,9),
                new Warrior("Bolbi",7,4,"Dagger")
            };

            foreach (GameCharacter gc in gameCharacters)
            {
                gc.Play();
                MakeLineSpace(1);
            }

            Console.WriteLine("===================================================");
            Console.WriteLine("Persons, Students and Staff");
            MakeLineSpace(1);

            List<Person> personList = new List<Person>
            {
                new Student("Alphonze Uno","111 Augustine Drive","Computer Science",2,10000.0),
                new Student("Barry Deux","2 Beryllium Road","Chemistry",3,12000.0),
                new Student("Carly Drei","3B Constiution Boulevard","History",1,9000.0),
                new Staff("Sonya English","435 Voltaire Lane","Blue Lagoon University",30.0),
                new Staff("Gorgio Metree","149 Pythagorian Road","Blue Lagoon University",30.0)
            };

            foreach (Person p in personList)
            {
                Console.WriteLine(p.ToString());
                MakeLineSpace(1);
            }
        }

        // Adds empty lines in console for formatting
        public static void MakeLineSpace(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
