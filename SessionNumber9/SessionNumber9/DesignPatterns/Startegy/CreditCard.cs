using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Startegy
{
    internal class CreditCard : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine("Payment done by creadit card");
        }
    }
}
