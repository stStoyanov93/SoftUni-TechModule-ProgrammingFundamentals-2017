using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            int P2OfSideA = sideA * sideA;
            int P2OfSideB = sideB * sideB;
            int P2OfSideC = sideC * sideC;

            bool checkIfValid = (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
            
            if (checkIfValid)
            {
                Console.WriteLine("Triangle is valid.");

                if (P2OfSideA + P2OfSideB == P2OfSideC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (P2OfSideA + P2OfSideC == P2OfSideB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (P2OfSideB + P2OfSideC == P2OfSideA)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");              
            }
           
        }
    }
}
