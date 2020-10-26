using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Staff : Person
    {
        // Fields
        private string school;
        private double pay;

        // Properties
        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        // Constructors
        public Staff() { } // Default

        public Staff(string Name, string Address, string School, double Pay)
            : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        // Methods
        public override string ToString()
        {
            return "Staff[" + base.ToString() + ", school= " + this.School + ", pay=" + this.Pay + "]";
        }
    }
}
