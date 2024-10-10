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
            double dMiles;
            double dKilometers;
            const double CONVER_TO_KILMOETERS = 1.609344;
            int iFeet;
            const int  CONVER_TO_FEET = 5280;
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
