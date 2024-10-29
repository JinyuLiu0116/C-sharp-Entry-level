using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class question_6
    {
        /*
          Write an application that computes the area of a circle, rectangle, and 
cylinder. Display a menu showing the three options. Allow users to input 
which figure they want to see calculated. Based on the value inputted, 
prompt for appropriate dimensions and perform the calculations using 
the following formulas:
 Area of a circle = pi * radius2
 Area of a rectangle = length * width
 Surface area of a cylinder = 2 * pi * radius * height + 2 * pi * radius2
 Write a modularized solution that includes class methods for inputting 
data and performing calculations
        a function of circle
        a function of retangle
        a function of cylinder
        a do while loop to display a menu
        three options for user to choose
        each option calls a function
         */
        static void Main(string[] args)
        {
            char yesOrNo;
            do
            {
                Console.WriteLine("1. Calculate the area of a circle");
                Console.WriteLine("2. Calculate the area of a rectangle");
                Console.WriteLine("3. Calculate the surface area of a cylinder");
                Console.Write("Please enter a number to choose (1-3):");
                int userChoice;
                double area;
                if(int.TryParse(Console.ReadLine(), out userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("You choose: 1. Calculate the area of a circle.");
                            area = Math.Round(AreaOfCircle(), 3);
                            Console.WriteLine("Area of circle:" + area);
                            break;
                        case 2:
                            Console.WriteLine("You choose: 2. Calculate the area of a rectangle.");
                            area = Math.Round(AreaOfRectangle(), 3);
                            Console.WriteLine("Area of rectangle:" + area);
                            break;
                        case 3:
                            Console.WriteLine("You choose: 3. Calculate the surface area of a cylinder.");
                            area = Math.Round(SurAreaOfCylinder(), 3);
                            Console.WriteLine("Surface area of circle:" + area);
                            break;
                        default: 
                            Console.WriteLine("Invalid input, please enter number 1-3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }


                Console.Write("Do you want to continue? (Y/N):");
                yesOrNo = Console.ReadLine().ToUpper().FirstOrDefault();
                Console.WriteLine();
                
            } while (yesOrNo == 'Y');
            Console.WriteLine();
            Console.WriteLine("Bye bye!");
            Console.ReadKey();
        }
        static double AreaOfCircle()
        {
            
            Console.Write("Please enter radius:");
            double radius = UserInput();
            Console.WriteLine();
            Console.WriteLine("Radius: " + radius);

            return Math.PI * Math.Pow(radius, 2);
        }
        static double AreaOfRectangle()
        {
            
            Console.Write("Please enter heigh:");
            double length = UserInput();
            Console.Write("Please enter width:");
            double width = UserInput();
            Console.WriteLine();
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            return length * width;
        }
        static double SurAreaOfCylinder()
        {
            
            Console.Write("Please enter radius:");
            double radius = UserInput();
            Console.Write("Please enter heigh:");
            double heigh = UserInput();
            Console.WriteLine();
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Heigh: " + heigh);
            return 2 * Math.PI * radius * heigh + 2 * Math.Pow(radius, 2);
        }
        static double UserInput()
        {
            while (true)
            {
                double num;
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Empty input, please enter again:");
                    continue;
                }
                else if (!double.TryParse(input, out num))
                {
                    Console.Write("Invalid input number, please enter again:");
                    continue;
                }
                else if (num < 0)
                {
                    Console.Write("Negative number, please enter again:");
                    continue;
                }
                else
                    return num;
            }
        }

    }
}

