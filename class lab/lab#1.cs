using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace windowsForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string result = "";
            //int counter = 0;
            //while (counter < 10)
            //{
            //    counter++;
            //    result += "\t" + counter + "\t" + Math.Pow(counter, 2) + "\n";
            //}
            //MessageBox.Show(result, "1 through 10 and their squares", MessageBoxButtons.OKCancel);
            //Console.ReadKey();
            try
            {
                int numberOfItemsPurchased;

                Console.Write("Testing reading of an integer\n\n");

                numberOfItemsPurchased = GetNumberOfItems();

                Console.WriteLine("The number of items purchases is " + numberOfItemsPurchased);
            }
            catch (Exception ex) { 
                Console.WriteLine("Catch exception:"+ex.Message);
            }

            Console.ReadKey();
        }
        static int GetNumberOfItems()
        {

            string numOfItems = "10a";
            int number;
            if (string.IsNullOrEmpty(numOfItems))
            {
                throw new Exception("Empty vaue");
            }
            else if(!int.TryParse(numOfItems, out number))
            {
                throw new Exception("Invalid value format");
            }
            else
                return number;
        }
    }
}

