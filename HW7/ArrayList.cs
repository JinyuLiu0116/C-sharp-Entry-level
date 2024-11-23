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
        static Random rand = new Random();

        static void Main(string[] args)
        {
            ArrayList alFruits = new ArrayList();

            alFruits.Add("Peach");
            alFruits.Add("Watermelon");
            alFruits.Add("Pum");

            Console.Write("Fruits: ");
            for (int i = 0; i < alFruits.Count; i++) 
            {
                Console.Write(alFruits[i] + " ");
            }
            Console.WriteLine();

            alFruits.Add("Apple");
            alFruits.Add("Bluebarry");
            alFruits.Remove("Pum");

            alFruits.Sort();
            Console.Write("Fruits: ");
            DisplayArrayList(alFruits);


            Console.ReadKey();
        }
        static void DisplayArrayList(ArrayList Fruits)
        {
            foreach(string fruit in Fruits)
            {
                Console.Write(fruit + " ");
            }
        }

    }
}

