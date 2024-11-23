using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{

    internal class Program
    {
        static Random rand = new Random();
        
        static void Main(string[] args)
        {
            int[] arrayNum = new int[10];
            int NumForSearch = 15;

            FillArray(arrayNum);
            Console.Write("arrayNum:");
            //display using for loop
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write(arrayNum[i]+" ");
            }
            Console.WriteLine();

            Array.Sort(arrayNum);
            Console.Write("arrayNum:");
            //display using foreach loop
            DisPlayArray(arrayNum);
            Console.WriteLine();

            if (Array.BinarySearch(arrayNum, NumForSearch) < 0) 
            {
                Console.WriteLine("Number not found");
            }
            else
            {
                Console.WriteLine("Number: " + NumForSearch + " in index position: " + Array.BinarySearch(arrayNum, NumForSearch));
            }




            Console.ReadKey();
        }
        static void FillArray(int[] array) 
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 20);
            }
        
        }
        static void DisPlayArray(int[] array) 
        {
            foreach(int it in array)
            {
                Console.Write(it + " ");
            }
        }
    }
}

