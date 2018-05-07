using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int y = 1; y <= m && sum < maxSum; y++)
                {
                    sum += 3 * (i * y);
                    count++;                                
                }

                if (sum >= maxSum)
                {
                    Console.WriteLine(count + " combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSum}");
                    break;
                }
            }

            if (sum < maxSum)
            {
                Console.WriteLine(count + " combinations");
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
