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
            const string product1 = "French fries";
            const string product2 = "Haricot verts";
            const double productOnePerHGrams = 1.29, productTwoPerHGrams = 0.75;
            const double gramToPound = 0.00220462;
            int weightInGrams = 100;
            double weightInPounds = weightInGrams * gramToPound;
            double totalPriceOfProductOne = productOnePerHGrams * weightInGrams;
            double totalPriceOfProductTwo = productTwoPerHGrams * weightInGrams;
            double productOnePerHPounds = totalPriceOfProductOne / weightInPounds;
            double productTwoPerHPounds = totalPriceOfProductTwo / weightInPounds;

            Console.WriteLine("Product name: ----------- " + product1);
            Console.WriteLine("Price per 100 Grams: --- $" + productOnePerHGrams);
            Console.WriteLine("Weight in Grams: -------- " + weightInGrams + "g");
            Console.WriteLine("Weight in Pounds: ------- " + Math.Round(weightInPounds, 2) + " lbs");
            Console.WriteLine("Price per Pound: ------- $" + Math.Round(productOnePerHPounds, 2));
            Console.WriteLine();
            Console.WriteLine("Product name: ---------- " + product2);
            Console.WriteLine("Price per 100 Grams: --- $" + productTwoPerHGrams);
            Console.WriteLine("Weight in Grams: ------- " + weightInGrams + "g");
            Console.WriteLine("Weight in Pounds: ------ " + Math.Round(weightInPounds, 2) + " lbs");
            Console.WriteLine("Price per Pound: ------- $" + Math.Round(productTwoPerHPounds, 2));

            Console.ReadKey();
        }
    }
}
