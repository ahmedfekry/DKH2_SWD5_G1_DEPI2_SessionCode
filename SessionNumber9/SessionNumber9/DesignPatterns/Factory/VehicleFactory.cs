using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Factory
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            IVehicle vehicle = null;

            switch (vehicleType)
            {
                case "Car":
                    vehicle = new Car();
                    break;
                case "Bike":
                    vehicle = new Bike();
                    break;
                case "Richshaw":
                    vehicle = new Richshaw();
                    break;
                case "Amulance":
                    vehicle = new Amulance();
                    break;
                default:
                    throw new Exception("Invalid Vehicle Type");
            }

            return vehicle;
        }
    }
}
