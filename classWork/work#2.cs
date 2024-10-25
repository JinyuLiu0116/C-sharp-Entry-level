using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace classAssignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senNum = -99;
            int sum=0;
            int averageTem;
            int numOfInput = 0;
            while (true)
            {
                string input;
                int userInputNum;
                Console.Write("Please enter temputer:");
                input = Console.ReadLine();
                //if (string.IsNullOrEmpty(input))
                //{
                //    continue;
                //}
                //else if (!int.TryParse(input, out userInputNum))
                //{
                //    continue;
                //}
                //else
                //{
                userInputNum = int.Parse(input);
                if (userInputNum != senNum)
                {
                    sum += userInputNum;
                    numOfInput++;
                    continue;
                }
                else
                    break;
                //}
            }
            averageTem = (sum + senNum) / numOfInput;
            Console.WriteLine("Average temputer:" + averageTem);
            Console.ReadKey();


        }
        
    }
    
}
