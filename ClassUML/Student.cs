using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Student : Person
    {
        // Fields
        private string program;
        private int year;
        private double fee;

        // Properties
        public string Program
        {
            get { return program; }
            set { program = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value;  }
        }

        // Constructors
        public Student() { } // Default

        public Student(string Name, string Address, string Program, int Year, double Fee)
            : base(Name,Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        // Methods
        public override string ToString()
        {
            return "Student["+ base.ToString() + ", program= " + this.Program + ", year= " + this.year + ", fee=" + this.Fee + "]";
        }
    }
}
