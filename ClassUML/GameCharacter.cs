using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class GameCharacter
    {
        // Fields/Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        // Constructor
        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
        }

        // Methods
        public virtual void Play()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("---------------");
            Console.WriteLine("  STR: {0}", Strength);
            Console.WriteLine("  INT: {0}", Intelligence);
            Console.WriteLine("---------------");
        }
    }
}
