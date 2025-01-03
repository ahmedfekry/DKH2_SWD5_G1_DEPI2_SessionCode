using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Startegy
{
    internal class DebitCard : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine("Amount paid using Debit Card: " + amount);
        }
    }
}
