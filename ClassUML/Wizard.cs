using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Wizard : MagicUsingCharacter
    {
        // Fields/Properties
        public int SpellNumber { get; set; }

        // Constructor
        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber)
            : base(Name, Strength, Intelligence, MagicalEnergy)
        {
            this.SpellNumber = SpellNumber;
        }

        // Methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine("  Num. of Spells: {0}", SpellNumber);
            Console.WriteLine("---------------");
        }
    }
}
