using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class ConverTemp
    {
        static void Main(string[] args)
        {
            double tempInF = Math.Round(userInput(), 2);
            double tempInC;
            int baseNum = 32;
            tempInC = Math.Round(5.0 / 9 * (tempInF - baseNum), 2);
            Console.WriteLine($"Temperature in Fahrenheit: {tempInF} degree");
            Console.WriteLine($"Temperature in Celsius: {tempInC} degree");

            Console.ReadKey();
        }
        static double userInput()
        {
            string input;
            double temp;
            while (true)
            {
                Console.Write("Please enter temperature in Fahrenheit:");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Empty input");
                    continue;
                }
                else if (!double.TryParse(input, out temp))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if (temp < -40 || temp > 120)
                {
                    Console.WriteLine("Temperature out of range");
                    continue;
                }
                else
                    return temp;
            }
        }
    }
}
            
