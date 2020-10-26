using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Warrior : GameCharacter
    {
        // Fields/Properties
        public string WeaponType { get; set; }

        // Constructor
        public Warrior(string Name, int Strength, int Intelligence, string WeaponType)
            : base(Name, Strength, Intelligence)
        {
            this.WeaponType = WeaponType;
        }

        // Methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine("  Weapon Type: {0}", WeaponType);
            Console.WriteLine("---------------");
        }
    }
}
