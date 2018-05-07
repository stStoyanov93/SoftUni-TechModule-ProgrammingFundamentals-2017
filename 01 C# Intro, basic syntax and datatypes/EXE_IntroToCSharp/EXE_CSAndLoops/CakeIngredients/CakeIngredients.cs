using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string input;
            int count = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }

                Console.WriteLine($"Adding ingredient {input}.");
                ++count;
            }
        }
    }
}
