using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class question_7
    {
        /* 
         
Write a program that produces a multiplication table with 25 rows of 
computations. Allow the user to input the first and last base values for 
the multiplication table. Display a column in the table beginning with 
the first base inputted value. The last column should be the ending base 
value entered. The first row should be for 1 times the beginning base,  
1 times the (beginning base value + 1), through 1 times the ending base 
value. The last row should be for 25 times the beginning base, 25 times 
the (beginning base value + 1), through 25 times the ending base value. 
Base values can range from 2 to 8. Display an error message if an invalid 
base is entered. Display an aesthetically formatted multiplication table. 
An example of output produced when 2 and 8 are entered appears in 
Figure 6-22.
        int baseNumber (1-25) use for loop
        int firstBase (user input 2-8)
        int lastBase (user input 2-8)
        a function get and check user input and return an interge
        display 25 rows

         */
        static void Main(string[] args)
        {
            const int MAX_TIMES = 25;
            Console.Write("Enter your first base number (2-8):");
            int firstBase = GetUserInput();
            Console.WriteLine();
            Console.Write("Enter your last base number (2-8):");
            int lastBase = GetUserInput();
            Console.WriteLine();

            Console.Write("n\t");
            if (firstBase < lastBase)
            {
                for (int i = firstBase; i <= lastBase; i++)
                {
                    Console.Write($"{i}\t");
                }
            }
            else
            {
                for (int i = firstBase; i >= lastBase; i--)
                {
                    Console.Write($"{i}\t");
                }
            }
            Console.WriteLine();

            for (int rows = 1; rows <= MAX_TIMES; rows++)
            {
                Console.Write($"{rows}\t");
                if(firstBase < lastBase)
                {
                    for (int cols = firstBase; cols <= lastBase; cols++)
                    {
                        Console.Write($"{cols * (rows + 1)}\t");
                    }
                }
                else
                {
                    for (int cols = firstBase; cols >= lastBase; cols--)
                    {
                        Console.Write($"{cols * (rows + 1)}\t");
                    }
                }

                Console.WriteLine();
            }
            


            Console.ReadKey();
        }
        static int GetUserInput()
        {
            string userInput;
            int Num;
            while (true)
            {
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Write("Empty input, please enter a number:");
                    continue;
                }
                else if(!int.TryParse(userInput, out Num)){
                    Console.Write("Invalid input, please enter a number:");
                    continue;
                }
                else if(Num < 2 || Num > 8)
                {
                    Console.Write("Number out of range, please enter a number (2-8):");
                    continue;
                }
                else
                {
                    return Num;
                }

            }
        }
    }
}

