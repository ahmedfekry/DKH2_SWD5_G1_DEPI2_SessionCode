using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Factory
{
    internal class Amulance : IVehicle
    {
        public int NumberOfWheels()
        {
            return 4;
        }

        public string VehicleType()
        {
            return "Amulance";
        }
    }
}
