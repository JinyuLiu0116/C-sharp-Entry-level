using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        /*
         A large Internet merchandise provider determines its shipping charges 
based on the number of items purchased. As the number increases, 
the shipping charges proportionally decrease. This is done to encour
age more purchases. If a single item is purchased, the shipping charge 
is $2.99. When customers purchase between 2 and 5 items, they are 
charged the initial $2.99 for the first item and then $1.99 per item for the 
remaining items. For customers who purchase more than 5 items but 
less than 15, they are charged the initial $2.99 for the first item, $1.99 per 
item for items 2 through 5, and $1.49 per item for the remaining items. 
If they purchase 15 or more items, they are charged the initial $2.99 for 
the first item, $1.99 per item for items 2 through 5, and $1.49 per item 
for items 6 through 14, and then just $0.99 per item for the remaining 
items. Allow the user to enter the number of items purchased. Define 
appropriate constants, use the decimal data type, and display the ship
ping formatted charges
         item 1 : 2.99
         item 2-5: 1.99
         item 6-14: 1.49
         item 15-...: 0.99
         user enter number of items
         variable type: float
         display formatted charges

         */
        const float INITIAL_PRICE = 2.99f;
        const float SECOND_HIGH_PRICE = 1.99f;
        const float THIRD_HIGH_PRICE = 1.49f;
        const float LOWEST_PRICE = 0.99f;
        static void Main(string[] args)
        {
            string userInput;
            int numberOfItems;
            float totalCharge;
            Console.Write("Please enter the number of items purchased:");
            while (true)
            {
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Write("Empty input value, please enter the number again:");
                    continue;
                }
                else if (!int.TryParse(userInput, out numberOfItems))
                {
                    Console.Write("Invalid input, please enter an integer:");
                    continue;
                }
                else if (numberOfItems < 0)
                {
                    Console.Write("Negative number, please enter a positive integer:");
                    continue;
                }
                else
                {
                    Console.WriteLine("You have {0} of items purchased.", numberOfItems);
                    break;
                }
              
            }

            totalCharge = CalculateCharges(numberOfItems);
            DisplayCharges(numberOfItems, totalCharge);


            Console.ReadKey();
        }
        static float CalculateCharges(in int num)
        {
            if(num == 0)
            {
                return 0.0f;
            }
            float total = 0.0f;
            for (int i = 1; i <= num; i++)
            {
                
                if (i == 1)
                {
                    total += INITIAL_PRICE;
                }
                else if (i >= 2 && i <= 5)
                {
                    total += SECOND_HIGH_PRICE;
                }
                else if(i >=6 && i <= 14)
                {
                    total += THIRD_HIGH_PRICE;
                }
                else
                {
                    total += LOWEST_PRICE;
                }
            }
            return total;
        }
        static void DisplayCharges(in int num, in float total)
        {
            Console.WriteLine("Number of items:----- " + num);
            if (num == 0)
            {
                Console.WriteLine("Total charge:-------- $" + total);
            }
            else if(num >= 1)
            {
                Console.WriteLine("Item 1:-------------- $" + INITIAL_PRICE);
            }
            if(num >=2)
            {
                if (num > 5)
                {
                    Console.WriteLine("Item 2-5:------------ $" + SECOND_HIGH_PRICE * 4);
                }
                else
                {
                    Console.WriteLine($"Item 2-{num}:------------ $" + SECOND_HIGH_PRICE * (num - 1));

                }
            }
            if(num >= 6)
            {
                if (num > 14)
                {
                    Console.WriteLine("Item 6-14:----------- $" + THIRD_HIGH_PRICE * 9);
                }
                else
                {
                    Console.WriteLine($"Item 6-{num}:------------ $" + THIRD_HIGH_PRICE * (num - 5));

                }
            }
            if(num >= 15)
            {
                if (num == 15)
                {
                    Console.WriteLine("Item 15:------------- $" + LOWEST_PRICE);
                }
                else
                {
                    Console.WriteLine($"Item 15-{num}:---------- $" + LOWEST_PRICE * (num - 14));

                }
            }
            Console.WriteLine("Total charge: --------$" + total);

        }
    }
}

