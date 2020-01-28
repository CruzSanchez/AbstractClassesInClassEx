using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesLesson
{
    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void ConcreteMethodAbstractClass()
        {
            Console.WriteLine("Concrete method in an abstract class!");
        }

        public abstract void PrintAbstractDetails();

        public virtual void PrintVirtualDetails()
        {
            Console.WriteLine("From our virtual method!!");
            Console.WriteLine($"These are the following qualities of the vehicle Year: {Year}, Make: {Make}, Model: {Model}");            
        }
    }
}
