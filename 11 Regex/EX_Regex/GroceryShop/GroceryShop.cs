using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroceryShop
{
    class GroceryShop
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            string productMatch = @"^[A-Z][a-z]+:[0-9]{1,2}\.[0-9]+$";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "bill")
                {
                    break;
                }

                if (!Regex.IsMatch(input, productMatch))
                {
                    continue;
                }

                var matchedInput = input.Split(':');

                products[matchedInput[0]] = double.Parse(matchedInput[1]);
            }

            var orderedProducts = products.OrderByDescending(x => x.Value);

            foreach (var item in orderedProducts)
            {
                Console.WriteLine($"{item.Key} costs {item.Value:F2}");
            }
        }
    }
}
