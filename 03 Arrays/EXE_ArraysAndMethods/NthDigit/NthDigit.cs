using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(n, index));
        }

        public static long FindNthDigit(long number, int index)
        {
            int currentIndex = 1;

            while(number > 0)
            {
                if (currentIndex == index)
                {
                    return number % 10;
                }
                else
                {
                    number /= 10;
                    currentIndex++;
                }
            }

            return number % 10;
        }
    }
}
