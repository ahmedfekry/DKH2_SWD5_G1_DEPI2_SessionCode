using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.D
{
    internal class Application
    {
        private ILogger logger;
        public bool IsErrorRaised { get; set; }
        public Application(ILogger logger)
        {
            this.logger = logger;
        }
        public void Start()
        {
            Console.WriteLine("The application Started");
        }

        public void Stop() 
        { 
            Console.WriteLine("The application Stopped"); 
        }

        public void ConnectToTheDatabase() 
        { 
            Console.WriteLine("Connected to the database");
            if (this.IsErrorRaised)
            {
                this.logger.Log("Filed to connect to the database");

            }
        }

        public void DoSomeLogic() 
        { 
            Console.WriteLine("Doing some logic");
            if (this.IsErrorRaised)
            {
                this.logger.Log("Filed to apply the logic");
            }

        }
    }
}
