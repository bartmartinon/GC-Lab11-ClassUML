using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class MagicUsingCharacter : GameCharacter
    {
        // Fields/Properties
        public int MagicalEnergy { get; set; }

        // Constructor
        public MagicUsingCharacter(string Name, int Strength, int Intelligence, int MagicalEnergy)
            : base(Name,Strength,Intelligence)
        {
            this.MagicalEnergy = MagicalEnergy;
        }

        // Methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine("  Mag. Power: {0}", MagicalEnergy);
            Console.WriteLine("---------------");
        }
    }
}
