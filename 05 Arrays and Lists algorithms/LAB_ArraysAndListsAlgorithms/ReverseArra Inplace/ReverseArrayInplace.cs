using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInplace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int index = 0; index < arr.Length / 2; index++)
            {
                int temp = arr[index];
                arr[index] = arr[arr.Length - 1 - index];
                arr[arr.Length - 1 - index] = temp;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
