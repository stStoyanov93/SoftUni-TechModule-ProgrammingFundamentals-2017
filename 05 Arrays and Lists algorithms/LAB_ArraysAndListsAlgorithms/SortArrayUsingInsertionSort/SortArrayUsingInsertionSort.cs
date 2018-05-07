using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < arr.Length; i++)
            {
                for (int y = i; y > 0; y--)
                {
                    if (arr[y - 1] > arr[y])
                    {
                        int temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;                       
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
