using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int minN = Math.Min(a, b);
            int maxN = Math.Max(a, b);

            for (int i = minN; i <= maxN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
