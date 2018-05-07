using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000M = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            int rest = 5;

            double traveledDistance = (double) wingFlaps / 1000 * distancePer1000M;

            BigInteger totalSeconds = (wingFlaps / 100) + ((wingFlaps / endurance) * 5);

            Console.WriteLine($"{traveledDistance:F2} m.");
            Console.WriteLine(totalSeconds + " s.");
        }
    }
}
