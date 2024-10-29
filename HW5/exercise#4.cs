using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    /*
Print isosceles triangles. For each triangle, allow the user to input two 
values: a character to be used for printing the triangle and the size of the 
peak for the triangle. Test the input for valid characters. The size of the 
triangle should not be larger than 10. If an invalid non-numeric charac
ter is entered for size or if the value entered for size is larger than 10, use 
3 as the default value. If an invalid entry is entered for the character, use 
an asterisk ( * ) as the default character. Allow multiple triangles to be 
printed. For example, if the user inputs # for the character and 6 for the 
peak, you should produce the following display:
 #
 # #
 # # #
 # # # #
 # # # # #
 # # # # # #
 # # # # #
 # # # #
 # # #
 # #
 #
     default number = 3 
     user input number 3-10
     default chart = '*'

     */
    internal class question_9
    {
        static void Main(string[] args)
        {
            string userInput_size;
            string userInput_char;
            int sizeOfTriangle;
            char charOfTriangle;
            char userChoice;
            do
            {
                Console.Write("Enter an integer number for the size of triangle(3-10):");
                userInput_size = Console.ReadLine();
                sizeOfTriangle = AssignSize(userInput_size);
                Console.WriteLine();

                Console.Write("Enter an symbol to build the triganle:");
                userInput_char = Console.ReadLine();
                charOfTriangle = AssignSymbol(userInput_char);
                Console.WriteLine();

                DisplayTriganle(sizeOfTriangle, charOfTriangle);
                Console.WriteLine();

                Console.Write("Do you want to play again (Y/N):");
                userChoice = Console.ReadLine().ToUpper().FirstOrDefault();
                if (userChoice == 'Y')
                {
                    Console.Write("Let's go! ");
                    continue;
                }
                else
                    break;

            } while (true);
            Console.WriteLine("Bye bye!");


            Console.ReadKey();
        }
        static int AssignSize(in string userInput_size)
        {
            int size;
            if (string.IsNullOrEmpty(userInput_size) || !int.TryParse(userInput_size, out size))
            {
                Console.WriteLine("Invalid input, use default value: 3");
                return 3;
            }
            else if (size < 3 || size > 10)
            {
                Console.WriteLine("Input number out of range, use default value: 3");
                return 3;
            }
            return size;

        }
        static char AssignSymbol(in string userInput_char)
        {
            char symbol;
            if (string.IsNullOrEmpty(userInput_char) || !char.TryParse(userInput_char, out symbol))
            {
                Console.WriteLine("Invalid input, user default character: *");
                return '*';
            }
            return symbol;
        }
        static void DisplayTriganle(in int size, in char symbol)
        {
            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    Console.Write($"{symbol}");
                }
                Console.WriteLine();
            }
            for (int rows = 1; rows < size; rows++)
            {
                for (int cols = 0; cols <= size - 1 - rows; cols++)
                {
                    Console.Write($"{symbol}");
                }
                Console.WriteLine();
            }
        }

    }
}

