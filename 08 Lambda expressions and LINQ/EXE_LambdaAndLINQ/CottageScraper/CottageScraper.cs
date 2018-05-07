using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> trees = new List<KeyValuePair<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                

                if (input == "chop chop")
                {
                    break;
                }

                string[] arr = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string treeType = arr[0];
                int height = int.Parse(arr[1]);

                trees.Add(new KeyValuePair<string, int>(treeType, height));
            }

            string neededType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(trees.Average(x => x.Value), 2);

            double usedLogsTotal = Math.Round(pricePerMeter * 
                (trees.Where(x => x.Key == neededType && x.Value >= minHeight).
                Sum(x => x.Value))
                , 2);

            double unusedLogsTotal = Math.Round((pricePerMeter * 0.25) *
                (trees.Where(x => x.Key != neededType || x.Value < minHeight)
                .Sum(x => x.Value))
                , 2);

            double totalPrice = Math.Round(usedLogsTotal + unusedLogsTotal, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsTotal:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsTotal:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:F2}");
        }
    }
}
