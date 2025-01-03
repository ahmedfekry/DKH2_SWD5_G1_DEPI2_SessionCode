using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.I
{
    internal class RobotB : IRobot
    {
        public void ICanSpinAround()
        {

            Console.WriteLine("I can spin around");

        }

        public void ICanWalk()
        {

            Console.WriteLine("I can walk");
        }
    }
}
