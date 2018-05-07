using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    public class DNASequences
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum;

            for (int first = 1; first <= 4; first++)
            {
                for (int second = 1; second <= 4; second++)
                {
                    for (int third = 1; third <= 4; third++)
                    {
                        sum = first + second + third;

                        if (sum < n)
                        {
                            Console.Write($"X{ReturnNucleotide(first)}{ReturnNucleotide(second)}{ReturnNucleotide(third)}X ");
                        }
                        else
                        {
                            Console.Write($"O{ReturnNucleotide(first)}{ReturnNucleotide(second)}{ReturnNucleotide(third)}O ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

        public static string ReturnNucleotide(int i)
        {
            if (i == 1)
            {
                return "A";
            }
            else if (i == 2)
            {
                return "C";
            }
            else if (i == 3)
            {
                return "G";
            }
            else
            {
                return "T";
            }
        }
    }
}
