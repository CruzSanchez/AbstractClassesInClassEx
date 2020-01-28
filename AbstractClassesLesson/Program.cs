using System;
using System.Collections.Generic;

namespace AbstractClassesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            List<Vehicle> vehicleList = new List<Vehicle>();

            Car car1 = new Car(2016, "BMW", "3 series");
            Car car2 = new Car(2011, "BMW", "3 series");
            Car car3 = new Car(2013, "BMW", "3 series");

            vehicleList.Add(car1);
            vehicleList.Add(car2);
            vehicleList.Add(car3);

            car1.ConcreteMethodAbstractClass();
            car1.PrintConcreteDetails();
            Console.WriteLine();
            car1.PrintAbstractDetails();
            Console.WriteLine();
            car1.PrintVirtualDetails();
            Console.WriteLine();

            Motorcycle motor = new Motorcycle(2019, "100", "Ducati");
            Motorcycle motor2 = new Motorcycle(2029, "10000", "Ducati");
            Motorcycle motor3 = new Motorcycle(2039, "1000", "Ducati");

            vehicleList.Add(motor);
            vehicleList.Add(motor2);
            vehicleList.Add(motor3);

            //motor.PrintAbstractDetails();
            //Console.WriteLine();
            //motor.PrintVirtualDetails();

            foreach (var item in vehicleList)
            {
                Console.WriteLine($"Current vehicle: {item.Year}, {item.Make}, {item.Model}");
            }
            
            Console.ReadLine();
        }
    }
}
