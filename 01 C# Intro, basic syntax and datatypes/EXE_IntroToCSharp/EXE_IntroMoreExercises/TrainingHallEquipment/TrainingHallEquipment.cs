using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                if (count > 1)
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }

                sum += count * price;
            }

            if (sum <= budget)
            {
                Console.WriteLine($"Subtotal: ${sum:F2}");
                Console.WriteLine($"Money left: ${budget - sum:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${sum:F2}");
                Console.WriteLine($"Not enough. We need ${sum - budget:F2} more.");
            }
        }
    }
}
