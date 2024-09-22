using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int tempInCelsius;
            int tempInFahrenheit;
            const int BaseValue = 32;

           
            while(true)
            {
                Console.Write("Please enter temperature in Celsius(-50 to 50):");
                userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out tempInCelsius))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if(tempInCelsius< -50 || tempInCelsius > 50)
                {
                    Console.WriteLine("Invalid input number");
                    continue;
                }
                else
                {
                    break;
                }
            }
            double covertion = tempInCelsius * (9.0 / 5) + BaseValue;
            covertion = Math.Round(covertion);
            tempInFahrenheit = (int)covertion;
            Console.WriteLine("Temperature in Celsius: " + tempInCelsius + " degree");
            Console.WriteLine("Temperature in Fahrenheit: " + tempInFahrenheit + " degree");

            Console.ReadKey();
        }
    }
}
