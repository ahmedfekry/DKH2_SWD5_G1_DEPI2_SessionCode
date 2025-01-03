using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Factory
{
    internal class Richshaw : IVehicle
    {
        public int NumberOfWheels()
        {
            return 3;
        }

        public string VehicleType()
        {
            return "Richshaw";
        }
    }
}
