using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.I.AnotherExample
{
    internal class Human : IWorkable, IFeadable
    {
        public void Work()
        {
            Console.WriteLine("I Can work");
        }

        public void CanEat()
        {
            Console.WriteLine("I Can eat");
        }

    }
}
