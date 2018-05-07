using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char y = first; y <= second; y++)
                {
                    for (char z = first; z <= second; z++)
                    {
                        if (i != third && y != third && z != third)
                        {
                            Console.Write($"{i}{y}{z} ");                     
                        }
                    }
                }
            }
        }
    }
}
