using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayofStrings
{
    class SortArrayofStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            for (int i = 1; i < arr.Length; i++)
            {
                for (int y = i; y > 0; y--)
                {
                    if (arr[y-1].CompareTo(arr[y]) > 0)
                    {
                        string temp = arr[y];
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
