using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.O
{
    internal class ManagerSalaryCalculator : ISalaryCalculator
    {
        public double basicSalary { get; set; }
        public double rate { get; set; }
        public double CalculateOverTime()
        {
            return basicSalary * rate;
        }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
