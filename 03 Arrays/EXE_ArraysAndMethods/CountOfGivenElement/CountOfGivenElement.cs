using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElement
{
    class CountOfGivenElement
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
