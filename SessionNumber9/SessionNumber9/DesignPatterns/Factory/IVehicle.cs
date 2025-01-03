using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Factory
{
    internal interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }
}
