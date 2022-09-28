using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public bool ThirdRow { get; set; }
        public double CargoSpace { get; set; }
        public bool IsHybrid { get; set; }
        public int NumDoors { get; set; }
        public int NumWheels { get; set; }
        public double EngineDisplacement { get; set; }
        public string Name { get; set; }
        public string DomesticMarket { get; set; }

        public void SUVSalesPitch()
        {
            Console.WriteLine($"Welcome to the new {Name} SUV hot off the assembly line from the {DomesticMarket} factories. \n" +
                $"This {NumDoors}-door behemoth features {CargoSpace} square in. of cargo space and a {EngineDisplacement}-liter engine getting you, your eight children, and all {NumWheels} offroad tires to the store and back in style. \n" +
                $"You can always expect the latest and greatest from the new line of SUVs from {Name}. Schedule a test drive today!");
        }
    }

}
