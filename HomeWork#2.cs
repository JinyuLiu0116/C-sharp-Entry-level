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
            // Question 1:
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

            // Question 2:
            double dMiles;
            double dKilometers;
            const double converToKilometers = 1.609344;
            int iFeet;
            const int converToFeet = 5280;
            while (true)
            {
                string userInput;
                Console.Write("Enter a distance as Miles(-1 to exit):");
                userInput = Console.ReadLine();
                if (userInput == "-1") {
                    Console.WriteLine("Thank you!");
                    break;
                }
                if (!double.TryParse(userInput, out dMiles))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if (dMiles < 0)
                {
                    Console.WriteLine("Distance cannot be negative");
                }
                else
                {
                    dKilometers = Math.Round(dMiles * converToKilometers, 2);
                    iFeet = (int)Math.Round(dMiles * converToFeet);

                    Console.WriteLine("Miles: " + Math.Round(dMiles, 2));
                    Console.WriteLine("Kilometers: " + dKilometers);
                    Console.WriteLine("Feet: " + iFeet);
                }
            }
    
            Console.ReadKey();
        }
    }
}
