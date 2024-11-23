using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listColor = new List<string>();

            listColor.Add("Red");
            listColor.Add("Blue");
            listColor.Add("Gray");
            Console.Write("Color: ");
            DisplayColor(listColor);
            Console.WriteLine();

            listColor.Insert(1, "Green");
            Console.Write("Color insert: ");
            DisplayColor(listColor);
            Console.WriteLine();

            listColor.Reverse();
            Console.Write("Color reverse: ");
            DisplayColor(listColor);
            Console.WriteLine();



            Console.ReadKey();
        }
        static void DisplayColor(List<string> Color)
        {
            foreach(string color in Color)
            {
                Console.Write(color+" ");
            }
        }

    }
}

