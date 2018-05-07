using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveStrings
{
    class Last3ConsecutiveStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] strings = new string[3];

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2])
                {
                    strings[0] = arr[i];
                    strings[1] = arr[i + 1];
                    strings[2] = arr[i + 2];
                }
            }

            Console.WriteLine(String.Join(" ", strings));
        }
    }
}
