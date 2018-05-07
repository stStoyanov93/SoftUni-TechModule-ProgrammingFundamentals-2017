using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string messedUpWord = Console.ReadLine();           
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arrChars = new int[messedUpWord.Length];

            for (int i = 0; i < messedUpWord.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrChars[i] = messedUpWord[i] - arr[i];
                }
                else
                {
                    arrChars[i] = arr[i] + messedUpWord[i];
                }
            }

            for (int i = 0; i < arrChars.Length; i++)
            {
                Console.Write(Convert.ToChar(arrChars[i]));
            }

            Console.WriteLine();
        }
    }
}
