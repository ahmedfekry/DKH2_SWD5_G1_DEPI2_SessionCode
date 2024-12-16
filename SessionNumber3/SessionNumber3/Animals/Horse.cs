using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    public class Horse : BarAnimal
    {
        public override void CanBreathUnderWater()
        {
            Console.WriteLine("I can't breath under water");
        }
    }
}
