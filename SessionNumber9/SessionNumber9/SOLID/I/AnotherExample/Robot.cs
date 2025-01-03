using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.I.AnotherExample
{
    internal class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("I Can work");
        }

    }
}
