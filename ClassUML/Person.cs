using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Person
    {
        // Fields
        private string name;
        private string address;

        // Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Constructors
        public Person() { } // Default

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        // Methods
        public override string ToString()
        {
            return "Person[name= " + this.Name + ", address= " + this.Address + "]";
        }
    }
}
