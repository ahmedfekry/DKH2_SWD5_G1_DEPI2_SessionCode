using SessionNumber9.DesignPatterns.Factory;
using SessionNumber9.DesignPatterns.Repository;
using SessionNumber9.DesignPatterns.Singleton;
using SessionNumber9.DesignPatterns.Startegy;
using SessionNumber9.DesignPatterns.Startegy.Database;
using SessionNumber9.SOLID.D;
using SessionNumber9.SOLID.I;
using SessionNumber9.SOLID.L;

namespace SessionNumber9
{
    internal class Program
    {
        //SOLID
        /*
         * S => single resposibitly
         *      Every class should have only one mission and one reason to change
         * O => Open-Closed Principle
         *      Open for extension but closed for modifications
         * L => Liskov principle
         *      If S is a subtype of T, then objects of type T in a program may be replaced with objects of type S without altering any of the desirable properties of that program.
         * I => interface segrigation
         *      Clients should not be forced to implement methods that they do not use.
         * D => Dependancy Inversion
         *  High-level modules should not depend on low-level modules. Both should depend on the abstraction.

            Abstractions should not depend on details. Details should depend on abstractions.
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            //ILogger logger = new ConsoleLogger();

            //Application app = new Application(logger);

            //app.Start();
            //app.IsErrorRaised = true;
            //app.ConnectToTheDatabase();
            //app.DoSomeLogic();
            //app.Stop();

            // Singleton Pattern
            //CurrencyConverter currencyConverter = CurrencyConverter.getInstance();

            //double result = currencyConverter.Convert("USD", 100);

            //Console.WriteLine(" Equivlant in USD : " + result.ToString());

            //result = currencyConverter.Convert("EUR", 100);
            //Console.WriteLine(" Equivlant in EUR : " + result.ToString());

            //CurrencyConverter Another = CurrencyConverter.getInstance();


            //result = Another.Convert("DR", 100);
            //Console.WriteLine(" Equivlant in DR : " + result.ToString());

            //IVehicle vehicle = new Car();

            //Console.WriteLine(vehicle.VehicleType()) ;

            //vehicle = new Bike();

            //Console.WriteLine(vehicle.VehicleType()) ;

            //vehicle = new Richshaw();
            //Console.WriteLine(vehicle.VehicleType()) ;

            //IVehicle vehicle = VehicleFactory.GetVehicle("Car");
            //Console.WriteLine(vehicle.VehicleType());
            // vehicle = VehicleFactory.GetVehicle("Amulance");
            //Console.WriteLine(vehicle.VehicleType());


            PaymentProcessor paymentProcessor;
            while (true)
            {
                Console.WriteLine("Please select Payment Method : ");
                Console.WriteLine("1. Credit Card");
                Console.WriteLine("2. Debit Card");
                Console.WriteLine("3. Wallet");
                int x = int.Parse(Console.ReadLine().ToString());

                if (x == 1)
                {
                    paymentProcessor = new PaymentProcessor(new CreditCard());
                    paymentProcessor.ProcessPayment();
                }
                else if (x == 2)
                {
                    paymentProcessor = new PaymentProcessor(new DebitCard());
                    paymentProcessor.ProcessPayment();
                }
                else if (x == 3)
                {
                    paymentProcessor = new PaymentProcessor(new Wallet());
                    paymentProcessor.ProcessPayment();
                }
                else
                {
                    break;
                }
            }

            //DatabaseConnector databaseConnector = new DatabaseConnector(new NoSql());

            //IUserRepository userRepository = new UserSqlRepository();

            //userRepository.AddUser(new User { Name = "Ali", Age = 20 });

        }
    }
}
