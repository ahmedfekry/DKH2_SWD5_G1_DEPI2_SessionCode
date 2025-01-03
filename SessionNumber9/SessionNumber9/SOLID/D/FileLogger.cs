using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.D
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Starting to log the error in a file");
            Console.WriteLine(message);
            Console.WriteLine("=========================================");
        }
    }
}
