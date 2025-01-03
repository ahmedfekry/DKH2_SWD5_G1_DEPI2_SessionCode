using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.I
{
    internal class RobotA : IRobot
    {
        public readonly bool CanSpin = true;
        public readonly bool CanWalk = true;
        public readonly bool CanWiggleAntennas = true;
        public void ICanSpinAround()
        {

            Console.WriteLine("I can spin around");
        }

        public void ICanWalk()
        {

            Console.WriteLine("I can walk");
        }

        public void ICanWiggleAntennas()
        {
            Console.WriteLine("I can wiggle antennas");
        }
    }
}
