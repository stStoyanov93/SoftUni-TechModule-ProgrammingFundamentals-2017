using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            bool commandIsSpin = false;
            
            string input;
            string final = string.Empty;
            string previousInput = string.Empty;

            while (n > count)
            {               
                input = Console.ReadLine();

                if (input == previousInput)
                {
                    if (input != "spin")
                    {
                        count++;
                    }

                    final = string.Empty;
                    continue;
                }

                if (input == "spin" && !commandIsSpin)
                {
                    commandIsSpin = true;
                    previousInput = input;
                    continue;
                }
                else if (input == "spin" && commandIsSpin)
                {
                    commandIsSpin = false;
                    previousInput = input;
                    continue;
                }

                if (!commandIsSpin)
                {
                    final += input;
                }
                else
                {
                    final = input + final;
                }

                previousInput = input;
                count++;
            }

            Console.WriteLine(final);
        }
    }
}
