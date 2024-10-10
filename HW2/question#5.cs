using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PRODUCT_1 = "French fries";
            const string PRODUCT_2 = "Haricot verts";
            const double PRODUCT_1_PER_GRAM = 1.29, PRODUCT_2_PER_GRAM = 0.75;
            const double GRAM_CONVER_TO_POUND = 0.00220462;
            int weightInGrams = 100;
            double weightInPounds = weightInGrams * GRAM_CONVER_TO_POUND;
            double totalPriceOfProductOne = PRODUCT_1_PER_GRAM * weightInGrams;
            double totalPriceOfProductTwo = PRODUCT_2_PER_GRAM * weightInGrams;
            double productOnePerHPounds = (totalPriceOfProductOne / weightInPounds) / 100;
            double productTwoPerHPounds = (totalPriceOfProductTwo / weightInPounds) / 100;

            Console.WriteLine("Product name: ----------- " + PRODUCT_1);
            Console.WriteLine("Price per 100 Grams: --- $" + PRODUCT_1_PE_GRAM);
            Console.WriteLine("Weight in Grams: -------- " + weightInGrams + "g");
            Console.WriteLine("Weight in Pounds: ------- " + Math.Round(weightInPounds, 2) + " lbs");
            Console.WriteLine("Price per Pound: ------- $" + Math.Round(productOnePerHPounds, 2));
            Console.WriteLine();
            Console.WriteLine("Product name: ---------- " + PRODUCT_2);
            Console.WriteLine("Price per 100 Grams: --- $" + PRODUCT_2_PER_GRAM);
            Console.WriteLine("Weight in Grams: ------- " + weightInGrams + "g");
            Console.WriteLine("Weight in Pounds: ------ " + Math.Round(weightInPounds, 2) + " lbs");
            Console.WriteLine("Price per Pound: ------- $" + Math.Round(productTwoPerHPounds, 2));

            Console.ReadKey();
        }
    }
}
