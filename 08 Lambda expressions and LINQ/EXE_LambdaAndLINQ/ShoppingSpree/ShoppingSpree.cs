using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            Dictionary<string, double> dict = new Dictionary<string, double>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] arr = command.Split(' ');
                string product = arr[0];
                double price = double.Parse(arr[1]);

                if (!dict.ContainsKey(product))
                {
                    dict[product] = price;
                }
                else if (dict.ContainsKey(product) && dict[product] > price)
                {
                    dict[product] = price;
                }
            }

            if (dict.Select(x => x.Value).Sum() > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                dict = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length).ToDictionary(x => x.Key, y => y.Value);

                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:F2}");
                }
            }
        }
    }
}
