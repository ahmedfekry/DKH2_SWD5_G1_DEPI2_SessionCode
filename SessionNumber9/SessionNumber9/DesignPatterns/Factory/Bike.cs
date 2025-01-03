using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Factory
{
    internal class Bike : IVehicle
    {
        public int NumberOfWheels()
        {
            return 2;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
