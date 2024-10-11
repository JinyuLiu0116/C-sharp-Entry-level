using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWassigment_1
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| A | SIN(A) | COS(A) | TAN(A) |");
            Console.WriteLine("--------------------------------");
            for (int index = 0; index <= 45; index++)
            {
                double radia = (index * Math.PI) / 180;
                string sin = Math.Round(Math.Sin(radia),4).ToString("F4");
                string cos = Math.Round(Math.Cos(radia),4).ToString("F4");
                string tan = Math.Round(Math.Tan(radia),4).ToString("F4");
                Console.WriteLine($"| {index} | {sin} | {cos} | {tan} |");
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
    }
}
