P﻿using System;
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
            const string EMPLOYEE_NAME = "Joshua Montain";
            float monthlySale = 1300000.00f;
            const float COMMISION_RATE = 0.07f;
            const float FEDERAL_TAX_RATE = 0.18f;
            const float RETIREMENT_RATE = 0.1f;
            const float SOCIAL_SECURITY_RATE = 0.06f;
            float grossSalary, netSalary, federalTax, retirement, socialSecurity;

            grossSalary = monthlySale * COMMISION_RATE;
            federalTax = grossSalary * FEDERAL_TAX_RATE;
            retirement = grossSalary * RETIREMENT_RATE;
            socialSecurity = grossSalary * SOCIAL_SECURITY_RATE;
            netSalary = grossSalary - federalTax - retirement - socialSecurity;
            Console.WriteLine("Employee Name ---------------: " + EMPLOYEE_NAME);
            Console.WriteLine("Sales for this month --------: " + monthlySale);
            Console.WriteLine("Sales commission(" + COMMISION_RATE * 100 + "%): -------: " + Math.Round(grossSalary, 2));
            Console.WriteLine("Fedral tax(" + FEDERAL_TAX_RATE * 100 + "%): ------------: " + Math.Round(federalTax, 2));
            Console.WriteLine("Retirement program(" + RETIREMENT_RATE * 100 + "%): ----: " + Math.Round(retirement, 2));
            Console.WriteLine("Social Security(" + SOCIAL_SECURITY_RATE * 100 + "%): --------: " + Math.Round(socialSecurity, 2));
            Console.WriteLine("Take-home pay: --------------: " + Math.Round(netSalary, 2));

            Console.ReadKey();
        }
    }
}
