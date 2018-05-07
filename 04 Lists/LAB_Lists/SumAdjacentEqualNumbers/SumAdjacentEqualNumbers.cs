using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            while (ContainsDublicates(input))
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                        input[i] += input[i];
                        input.Remove(input[i + 1]);
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", input));
        }

        public static bool ContainsDublicates(List<double> list)
        {
            bool duplicated = false;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    duplicated = true;
                    break;
                }
            }

            return duplicated;
        }
    }
}
