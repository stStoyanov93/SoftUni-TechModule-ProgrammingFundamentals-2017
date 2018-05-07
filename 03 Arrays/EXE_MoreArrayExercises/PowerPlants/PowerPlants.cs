using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants
{
    class PowerPlants
    {
        static void Main(string[] args)
        {
            int[] plantsPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int days = 0;
            int seasons = 0;
            int daysPerSeason = plantsPower.Length;

            while (PlantsStillAlive(plantsPower))
            {
                for (int day = 0; day < plantsPower.Length; day++)
                {
                    if (plantsPower[day] != 0)
                    {
                        if (days % daysPerSeason != day)
                        {
                            plantsPower[day]--;
                        }
                    }
                }

                days++;

                if (days % daysPerSeason == 0 && PlantsStillAlive(plantsPower))
                {
                    for (int i = 0; i < plantsPower.Length; i++)
                    {
                        if (plantsPower[i] != 0)
                        {
                            plantsPower[i]++;
                        }
                    }

                    seasons++;
                }
            }

            string s = string.Empty;

            if (seasons == 1)
            {
                s = "season";
            }
            else
            {
                s = "seasons";
            }

            Console.WriteLine($"survived {days} days ({seasons} {s})");


        }

        static bool PlantsStillAlive(int[] plants)
        {
            for (int live = 0; live < plants.Length; live++)
            {
                if (plants[live] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
