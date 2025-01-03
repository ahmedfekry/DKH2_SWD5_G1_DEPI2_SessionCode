using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Singleton
{
    internal class CurrencyConverter
    {
        public Dictionary<string, double> _currencyRates = new Dictionary<string, double>();

        private static CurrencyConverter _instance;

        private static object _lock = new object();

        private CurrencyConverter()
        {
            // call to the database
            _currencyRates.Add("USD", 50.0);
            _currencyRates.Add("EUR", 55.85);
            _currencyRates.Add("DR", 13.00);
        }

        public static CurrencyConverter getInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new CurrencyConverter();
                }
            }
            
            return _instance;
        }

        public double Convert(string toCurrency, double amount)
        {
            double toRate = _currencyRates[toCurrency];

            return amount / toRate;
        }
    }
}
