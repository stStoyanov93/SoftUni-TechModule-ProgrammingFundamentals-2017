using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumbers
{
    class ExactProductOfRealNumbers
    {
        static void Main(string[] args)
        {
            decimal sum = 1M;
            int n = int.Parse(Console.ReadLine());

            decimal number;

            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum *= number;
            }

            Console.WriteLine(sum);
        }
    }
}
