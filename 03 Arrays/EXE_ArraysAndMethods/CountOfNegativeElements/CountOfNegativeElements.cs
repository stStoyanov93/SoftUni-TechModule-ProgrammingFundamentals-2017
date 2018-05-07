using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNegativeElements
{
    class CountOfNegativeElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr[i] = a;

                if (a < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
