using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfAString
{
    class ValueOfAString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string letterCase = Console.ReadLine();
            int sum = 0;

            if (letterCase == "UPPERCASE")
            {
                foreach (var c in input)
                {
                    if (char.IsUpper(c))
                    {
                        sum += c;
                    }
                }
            }
            else if (letterCase == "LOWERCASE")
            {
                foreach (var c in input)
                {
                    if (char.IsLower(c))
                    {
                        sum += c;
                    }
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
