using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurencesOfLargerNumbers
{
    class CountOccurencesOfLargerNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double n = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
