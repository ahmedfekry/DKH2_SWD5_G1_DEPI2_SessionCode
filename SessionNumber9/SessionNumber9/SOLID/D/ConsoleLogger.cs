using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.D
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Starting log in the console");
            Console.WriteLine(message);
            Console.WriteLine("============================");
        }
    }
}
