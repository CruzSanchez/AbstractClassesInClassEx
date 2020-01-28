using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesLesson
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public Motorcycle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public override void PrintAbstractDetails()
        {
            Console.WriteLine("Motorcycle details: blah blah blah...");
        }

        public override void PrintVirtualDetails()
        {
            base.PrintVirtualDetails();
        }
    }
}
