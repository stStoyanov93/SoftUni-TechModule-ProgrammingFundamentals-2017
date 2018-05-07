using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletsOfLatinLetters
{
    class TripletsOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int key = n - 1;

            for (int i = 0; i <= key; i++)
            {
                for (int j = 0; j <= key; j++)
                {
                    for (int k = 0; k <= key; k++)
                    {
                        Console.WriteLine($"{(char) ('a' + i)}{(char) ('a' + j)}{(char) ('a' + k)}");
                    }
                }
            }
        }
    }
}
