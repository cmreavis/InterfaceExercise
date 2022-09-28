using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool IsHybrid { get; set; }
        public int NumDoors { get; set; }   
        public int NumWheels { get; set; }
        public double EngineDisplacement { get; set; }
    }
}
