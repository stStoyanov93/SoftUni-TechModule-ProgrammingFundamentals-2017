using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGameOfNumbers
{
    class AGameOfNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 0;
            string found = String.Empty;

            for (int i = first; i <= second; i++)
            {
                for (int y = first; y <= second; y++)
                {
                    if (i + y == magicNumber)
                    {                      
                        found = $"{i} + {y} = {magicNumber}";
                    }

                    count++;
                }
            }

            if (found == String.Empty)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {found}");
            }
        }
    }
}
