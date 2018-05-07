using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementinTheArray
{
    class SmallestElementinTheArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestN = int.MaxValue;

            foreach (int item in arr)
            {
                if (item < smallestN)
                {
                    smallestN = item;
                }
            }

            Console.WriteLine(smallestN);
            
        }
    }
}
