using System.Reflection.Metadata.Ecma335;

namespace SessionNumber6Notification
{
    public delegate void NotifyDriver(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("John", 60, 100);
            int numberOfEvents = 0;

            //Car.NotifyDriver notify = NotifyDriver;

            //car.n
            //car.RegisterNotifier(NotifyDriver);
            //car.RegisterNotifier(TheCarExploded);

            //car.UnRegisterNotifier(new Car.NotifyDriver(TheCarExploded));
            car._IsAboutToExplode += delegate(object obj,CarEventArgs args) 
            {
                numberOfEvents++;
                Console.WriteLine("======= Warning ==========");
                if (obj is Car c)
                {
                    Console.WriteLine($"Message from {c.DriverName}, {args.Message}");
                }
                Console.WriteLine("===========================");
            };

            car._CarExploded += delegate(object obj,CarEventArgs args1) 
            {
                numberOfEvents++;
                Console.WriteLine("This is from the car exploded");
                Console.WriteLine("====== Error==============");
                if (obj is Car c)
                {
                    Console.WriteLine($"Message from {c.DriverName}, {args1.Message}");
                }
                Console.WriteLine("==========================");
            };


            for(int i = 0; i < 10; i++)
            {
                car.Accelerate(10);
            }

            Console.WriteLine($"Number of events: {numberOfEvents}");   
        }

        //public static void CarAboutToExplode(object obj, CarEventArgs args)
        //{
        //    Console.WriteLine("======= Warning ==========");
        //    //Console.WriteLine(message);
        //    if (obj is Car c)
        //    {
        //        Console.WriteLine($"Message from {c.DriverName}, {args.Message}");
        //    }
        //    Console.WriteLine("===========================");
        //}

        //public static void TheCarExploded(object obj,CarEventArgs args)
        //{
        //    //Console.WriteLine("This is from the car exploded");
        //    Console.WriteLine("====== Error==============");
        //    //Console.WriteLine(message);
        //    if (obj is Car c)
        //    {
        //        Console.WriteLine($"Message from {c.DriverName}, {args.Message}");
        //    }
        //    Console.WriteLine("==========================");
        //}   
    }
}
