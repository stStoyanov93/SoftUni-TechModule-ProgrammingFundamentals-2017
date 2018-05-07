using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte num = 0;
            int overflow = 0;

            for (int i = 0; i < n; i++)
            {
                num++;

                if (num == byte.MinValue)
                {
                    overflow++;
                }
            }

            Console.WriteLine(num);

            if (overflow > 0)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }


        }
    }
}
