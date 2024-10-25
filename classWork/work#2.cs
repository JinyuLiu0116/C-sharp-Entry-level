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
            int[] arrOfNum;
            arrOfNum = new int[10];

            Random rand = new Random;

            for(int i = 0; i < arrOfNum.Length; i++){
                arrOfNum[i] = rand.Next(1,100);
            }

            foreach(int it in arrOfNum){
                Console.Write("{0} ", it);
            }
            Console.WriteLine();

            arrOfNum.Sort();

            foreach(int it in arrOfNum){
                Console.Write("{0} ", it);
            }
            
            Console.ReadKey();
        }
        
    }
    
}
