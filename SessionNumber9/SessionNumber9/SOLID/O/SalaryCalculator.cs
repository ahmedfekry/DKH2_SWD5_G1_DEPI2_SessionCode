using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.O
{
    internal class SalaryCalculator
    {
        public double BasicSalary { get; set; }
        public void calculateSalary(Employee employee)
        {

        }

        public double CalculateOverTime(Employee employee)
        {
            if (employee.EmployeeType == "Normal Employee")
            {
                return this.BasicSalary * 1.5;
            }
            else if(employee.EmployeeType == "Manager")
            {
                return this.BasicSalary * 1.8;
            }
            else if( employee.EmployeeType == "Senior Manager")
            {

            }
            return this.BasicSalary;
        }
    }
}
