using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heighOfRectangle, widthOfRectangle;
            double area, perimeter;
            
            heighOfRectangle = getHight();
            widthOfRectangle = getWidth();
            area = heighOfRectangle * widthOfRectangle;
            perimeter = (heighOfRectangle + widthOfRectangle) * 2;
            Console.WriteLine($"Hight of Rectangle: {heighOfRectangle}");
            Console.WriteLine($"Width of Rectangle: {widthOfRectangle}");
            Console.WriteLine($"Area of Rectangle: {area}");
            Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
            
            Console.ReadKey();
        }
        static double getHight(){
            string userInput;
            double height;
            while (true){
                Console.Write("Please enter the heigh of rectangle:");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput)) {
                    Console.WriteLine("Empty input value");
                    continue;
                }
                else if(!double.TryParse(userInput, out height)){
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if(height <= 0){
                    Console.WriteLine("Height must be positive value");
                    continue;
                }
                else
                {
                    return height;
                }
            }
        }
        static double getWidth()
        {
            string userInput;
            double Width;
            while (true)
            {
                Console.Write("Please enter the width of rectangle:");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Empty input value");
                    continue;
                }
                else if (!double.TryParse(userInput, out Width))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if (Width <= 0)
                {
                    Console.WriteLine("Width must be positive value");
                    continue;
                }
                else
                {
                    return Width;
                }
            }
        }
    }
}

