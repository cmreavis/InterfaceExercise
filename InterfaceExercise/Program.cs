using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            List<Car> cars = new List<Car>();

            Car teslaS = new Car()
            {
                SeatsLayout = "sedan",
                ZeroToSixty = 1.99,
                IsHybrid = true,
                NumDoors = 4,
                NumWheels = 4,
                EngineDisplacement = 0.0,
                Name = "Tesla",
                DomesticMarket = "USA"
            };
            cars.Add(teslaS);   
            Car twoSeries = new Car()
            {
                SeatsLayout = "Coupe",
                ZeroToSixty = 4.0,
                IsHybrid = false,
                NumDoors = 2,
                NumWheels = 4,
                EngineDisplacement = 3.0,
                Name = "BMW",
                DomesticMarket = "Europe"
            };
            cars.Add(twoSeries);

            List<Truck> trucks = new List<Truck>();

            Truck fordTruck = new Truck()
            {
                CabType = "Crew Cab",
                GroundClearance = 9.4,
                IsHybrid = true,
                NumDoors = 4,
                NumWheels = 4,
                EngineDisplacement = 3.5,
                Name = "Ford",
                DomesticMarket = "USA"
            };
            trucks.Add(fordTruck);
            Truck rivianTruck = new Truck()
            {
                CabType = "Quad Cab",
                GroundClearance = 14.9,
                IsHybrid = true,
                NumDoors = 4,
                NumWheels = 4,
                EngineDisplacement = 0.0,
                Name = "Rivian",
                DomesticMarket = "USA"
            };
            trucks.Add(rivianTruck);

            List<SUV> suvs = new List<SUV>();

            SUV fourRunner = new SUV()
            {
                ThirdRow = true,
                CargoSpace = 47.2,
                IsHybrid = false,
                NumDoors = 4,
                NumWheels = 4,
                EngineDisplacement = 4.0,
                Name = "Toyota",
                DomesticMarket = "Japan"
            };
            suvs.Add(fourRunner);
            SUV denali = new SUV()
            {
                ThirdRow = true,
                CargoSpace = 94.7,
                IsHybrid = false,
                NumDoors = 5,
                NumWheels = 4,
                EngineDisplacement = 6.2,
                Name = "GMC",
                DomesticMarket = "USA",
            };
            suvs.Add(denali);

            Console.WriteLine("Enjoying the game? Please take a few moments to hear from our sponsors.");
            Console.WriteLine();

            foreach (var car in cars)
            {
                car.CarSalesPitch();
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var truck in trucks)
            {
                truck.TruckSalesPitch();
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var SUV in suvs)
            {
                SUV.SUVSalesPitch();
                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}
