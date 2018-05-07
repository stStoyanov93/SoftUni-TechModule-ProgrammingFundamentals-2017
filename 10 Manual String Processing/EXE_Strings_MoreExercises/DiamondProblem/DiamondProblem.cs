using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    class DiamondProblem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int indexL = -1;
            int indexR = -1;
            bool diamontIsFound = false;

            while ((indexL = input.IndexOf('<', indexL + 1)) > -1
                && (indexR = input.IndexOf('>', indexL + 1)) > -1)
            {
                string diamond = input.Substring(indexL + 1, indexR - indexL - 1);
                int carat = 0;
                diamontIsFound = true;

                foreach (var item in diamond)
                {
                    if (char.IsDigit(item))
                    {
                        carat += item - '0';
                    }
                }

                Console.WriteLine($"Found {carat} carat diamond");
            }

            if (!diamontIsFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
