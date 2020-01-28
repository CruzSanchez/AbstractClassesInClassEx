using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesLesson 
{
    class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public void PrintConcreteDetails()
        {
            Console.WriteLine("This a concrete method in a concrete class!");
            Console.WriteLine($"These are the following qualities of the vehicle Year: {Year}, Make: {Make}, Model: {Model}");
        }

        public override void PrintAbstractDetails()
        {
            Console.WriteLine("This is the Cars class implementation of our abstract method!");
            Console.WriteLine($"These are the following qualities of the vehicle Make: {Make}, Model: {Model}, Year: {Year}");
        }

        public override void PrintVirtualDetails()
        {
            Console.WriteLine("The virtual method was overridden!!");
            Console.WriteLine($"These are the following qualities of the vehicle Make: {Make}, Year: {Year}, Model: {Model}");
        }        
    }
}
