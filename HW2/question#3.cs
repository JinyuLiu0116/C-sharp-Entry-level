using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static int UserInput()
        {
            string userInput;
            int amount = 0;
            while (true)
            {
                userInput = Console.ReadLine();
                if (userInput == "-1") {
                    return -1;
                }
                if (!int.TryParse(userInput, out amount))
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Please enter again:");
                    continue;
                }
                else if (amount < 0)
                {
                    Console.WriteLine("Cannot have negative number of Coins");
                    Console.Write("Please enter again:");
                    continue;
                }
                else
                    break;
            }
            return amount;
        }
        static double CalculateAmount(int pennies, int nickels, int dimes, int quarters, 
            int converNickels, int converDimes, int converQuarters)
        {
            double dAmount = 0.0;
            dAmount = pennies+(nickels * converNickels) + (dimes * converDimes) + (quarters * converQuarters);
            dAmount = (dAmount / 100);
            return dAmount;
        }
        static void Main(string[] args)
        {
            const int iConverNickels = 5;
            const int iConverDimes = 10;
            const int iConverQuarters = 25;
            int iPennies, iNickels, iDimes, iQuarters;
            double dTotle;
            while (true)
            {
                Console.Write("Enter the nuber of Pennies:");
                iPennies = UserInput();
                if (iPennies == -1)
                {
                    iPennies = 0;
                }
                Console.WriteLine(iPennies + " Pennies");

                Console.Write("Enter the nuber of Nickels:");
                iNickels = UserInput();
                if (iNickels == -1)
                {
                    iNickels = 0;
                }
                Console.WriteLine(iNickels + " Nickels");

                Console.Write("Enter the nuber of Dimes:");
                iDimes = UserInput();
                if (iDimes == -1)
                {
                    iDimes = 0;
                }
                Console.WriteLine(iDimes + " Dimes");

                Console.Write("Enter the nuber of Quarters:");
                iQuarters = UserInput();
                if (iQuarters == -1)
                {
                    iQuarters = 0;
                }
                Console.WriteLine(iQuarters + " Quarters");

                dTotle = CalculateAmount(iPennies, iNickels, iDimes, iQuarters, iConverNickels, iConverDimes, iConverQuarters);
                Console.WriteLine("The amount of money is: $"+dTotle);
                string continueOrExit;
                while(true)
                {
                    Console.Write("Enter 'y' to continue, 'n' to exit:");
                    continueOrExit = Console.ReadLine();
                    if(continueOrExit.Substring(0).ToLower() != "y" && continueOrExit.Substring(0).ToLower() != "n")
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if(continueOrExit == "y") continue;
                if(continueOrExit == "n") break;
            }
            Console.WriteLine("Thank you");
            Console.ReadKey();
        }
    }
}

