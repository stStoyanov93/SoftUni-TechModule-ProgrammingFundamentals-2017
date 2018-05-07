using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            int[] beehvives = Console.ReadLine().Trim().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Trim().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            List<long> survivors = new List<long>();

            for (int i = 0; i < beehvives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    survivors.Add(beehvives[i]);
                    continue;
                }

                long s = hornets.Sum() - beehvives[i];

                if (s <= 0)
                {
                    hornets.RemoveAt(0);

                    if (s < 0)
                    {
                        survivors.Add(Math.Abs(s));
                    }
                }
            }

            if (survivors.Count == 0)
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(String.Join(" ", survivors));
            }
        }
    }
}
