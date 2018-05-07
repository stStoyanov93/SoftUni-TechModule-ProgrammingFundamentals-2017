using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while(true)
            {
                bool swapped = false;

                for (int y = 0; y < arr.Length - 1; y++)
                {
                    if (arr[y] > arr[y+1])
                    {
                        int temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
