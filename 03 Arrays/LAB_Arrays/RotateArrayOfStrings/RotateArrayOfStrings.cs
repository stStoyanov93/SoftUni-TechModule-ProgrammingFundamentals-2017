using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] copyWords = new string[words.Length];
            Array.Copy(words, copyWords, words.Length);

            for (int i = 0; i < words.Length; i++)
            {
               
                if (i == 0)
                {
                    words[i] = copyWords[copyWords.Length - 1];
                }
                else
                {
                    words[i] = copyWords[i - 1];
                }
            }

            Console.WriteLine(String.Join(" ", words));
        }
    }
}
