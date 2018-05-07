using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine()); ;

            for (int i = 0; i < capacity.Length; i++)
            {
                int hoursLasted = 0;
                double cap = capacity[i];               

                for (int y = 1; y <= hours; y++)
                {
                    cap -= usagePerHour[i];
                    hoursLasted++;

                    if (cap <= 0)
                    {
                        break;
                    }
                }

                if (cap <= 0)
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursLasted} hours)");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: {cap:F2} mAh ({((cap / capacity[i]) * 100):F2})%");
                }
            }
        }
    }
}
