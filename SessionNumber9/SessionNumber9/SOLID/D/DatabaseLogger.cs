using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.D
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Starting to log the error in the database");
            Console.WriteLine("Database Logger: " + message);
            Console.WriteLine("=========================================");
        }
    }
}
