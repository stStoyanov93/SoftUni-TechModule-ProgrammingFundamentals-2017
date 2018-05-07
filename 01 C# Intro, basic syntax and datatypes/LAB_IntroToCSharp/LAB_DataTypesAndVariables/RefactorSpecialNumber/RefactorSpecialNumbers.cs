using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumber
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool toe = false;

            for (int i = 1; i <= n; i++)
            {
                int sum  = 0;
                int middleN = i;

                while (middleN > 0)
                {
                    sum += middleN % 10;
                    middleN = middleN / 10;
                }

                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {toe}");
            }        
        }
    }
}
