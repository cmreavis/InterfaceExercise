using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public string SeatsLayout { get; set; }
        public double ZeroToSixty { get; set; }
        public bool IsHybrid { get; set; }
        public int NumDoors { get; set; }
        public int NumWheels { get; set; }
        public double EngineDisplacement { get; set; }
        public string Name { get; set; }
        public string DomesticMarket { get; set; }

        public void CarSalesPitch()
        {
            Console.WriteLine($"This is a brand new {Name} {SeatsLayout} coming from the {DomesticMarket} domestic market! \n" +
                $"This car features a zero to sixty time of {ZeroToSixty} seconds from that {EngineDisplacement}-liter engine putting power to all {NumWheels} wheels! \n" +
                $"Inquire inside for pricing and additional information on this beautiful new {Name} {SeatsLayout}.");
        }
    }
}
