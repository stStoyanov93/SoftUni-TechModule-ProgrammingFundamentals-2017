using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = Product(n);

            Console.WriteLine(a);
        }

        public static int Product(int n)
        {
            int sumOdds = 0;
            int sumEvens = 0;
            int nCopy = Math.Abs(n);

            while (nCopy > 0)
            {
                int num = nCopy % 10;

                if (num % 2 == 0)
                {
                    sumEvens += num;
                }
                else
                {
                    sumOdds += num;
                }

                nCopy /= 10;
            }

            return sumOdds * sumEvens;
        }
    }
}
