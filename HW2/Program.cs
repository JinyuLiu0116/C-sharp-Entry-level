using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string employeeName = "Joshua Montain";
            float monthlySale = 1300000.00f;
            const float commisionRate = 0.07f;
            const float federalTaxRate = 0.18f;
            const float retirementRate = 0.1f;
            const float socialSecurityRate = 0.06f;
            float grossSalary, netSalary, federalTax, retirement, socialSecurity;

            grossSalary = monthlySale * commisionRate;
            federalTax = grossSalary * federalTaxRate;
            retirement = grossSalary * retirementRate;
            socialSecurity = grossSalary * socialSecurityRate;
            netSalary = grossSalary - federalTax - retirement - socialSecurity;
            Console.WriteLine("Employee Name ---------------: " + employeeName);
            Console.WriteLine("Sales for this month --------: " + monthlySale);
            Console.WriteLine("Sales commission(" + commisionRate * 100 + "%): -------: " + Math.Round(grossSalary, 2));
            Console.WriteLine("Fedral tax(" + federalTaxRate * 100 + "%): ------------: " + Math.Round(federalTax, 2));
            Console.WriteLine("Retirement program(" + retirementRate * 100 + "%): ----: " + Math.Round(retirement, 2));
            Console.WriteLine("Social Security(" + socialSecurityRate * 100 + "%): --------: " + Math.Round(socialSecurity, 2));
            Console.WriteLine("Take-home pay: --------------: " + Math.Round(netSalary, 2));

            Console.ReadKey();
        }
    }
}
