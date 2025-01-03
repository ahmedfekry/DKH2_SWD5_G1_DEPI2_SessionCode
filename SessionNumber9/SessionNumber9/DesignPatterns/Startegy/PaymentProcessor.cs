using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Startegy
{
    internal class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;
        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            this._paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment()
        {
            this._paymentStrategy.Pay(100); 
        }
    }
}
