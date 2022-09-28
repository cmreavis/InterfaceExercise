using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public string CabType { get; set; }
        public double GroundClearance { get; set; }
        public bool IsHybrid { get; set; }
        public int NumDoors { get; set; }
        public int NumWheels { get; set; }
        public double EngineDisplacement { get; set; }
        public string Name { get; set; }
        public string DomesticMarket { get; set; }

        public void TruckSalesPitch()
        {
            Console.WriteLine($"Say hello to the newest iteration of the {Name} {CabType} truck! \n" +
                $"With a {EngineDisplacement}-liter engine and a ground clearance of {GroundClearance} inches high, you will be crawling those {NumWheels} wheels over rocks and parking lot curbs alike (with ease!) \n" +
                $"This model from the {DomesticMarket} market demands your attention. Schedule a test drive today at your local {Name} dealership.");
        }

    }

}
