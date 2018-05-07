using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborWar
{
    class NeighborWar
    {
        static void Main(string[] args)
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());

            int pHealth = 100;
            int gHealth = 100;
            int round = 1;

            while (pHealth > 0 && gHealth > 0)
            {
                if (round % 2 != 0)
                {
                    gHealth -= peshoDMG;

                    if (gHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    
                }
                else
                {
                    pHealth -= goshoDMG;

                    if (pHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                }             

                if (round % 3 == 0)
                {
                    pHealth += 10;
                    gHealth += 10;
                }

                round++;
            }
        }
    }
}
