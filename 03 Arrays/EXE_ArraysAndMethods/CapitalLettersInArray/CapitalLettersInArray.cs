using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalLettersInArray
{
    class CapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1 && (arr[i][0] >= 65 && arr[i][0] <= 90))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
