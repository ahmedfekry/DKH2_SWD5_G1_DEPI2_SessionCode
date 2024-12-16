using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    internal class WildAnimals : Animal
    {
        public void CanEatHumans()
        {
            Console.WriteLine(this.Name + " can eat humans");
        }
    }
}
