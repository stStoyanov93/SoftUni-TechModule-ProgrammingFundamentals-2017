using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymetry
{
    class ArraySymetry
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] arrReversed = new string[arr.Length];
            Array.Copy(arr, arrReversed, arr.Length);
            Array.Reverse(arrReversed);
            

            bool isSymetric = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != arrReversed[i].Length || !isSymetric)
                {
                    isSymetric = false;
                    break;
                }
                else
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] != arrReversed[i][j])
                        {
                            isSymetric = false;
                            break;
                        }
                    }
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
