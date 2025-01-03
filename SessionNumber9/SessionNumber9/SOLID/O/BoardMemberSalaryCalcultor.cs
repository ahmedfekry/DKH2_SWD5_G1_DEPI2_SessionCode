using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.O
{
    internal class BoardMemberSalaryCalcultor : ISalaryCalculator
    {
        public double BasicSalary { get; set; }
        public readonly double Rate = 1.8;
        public double CalculateOverTime()
        {
            return BasicSalary * Rate;
        }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
