using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.O
{
    public interface ISalaryCalculator
    {
        void CalculateSalary();
        double CalculateOverTime();
    }
}
