using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal distanceToProximaCenturi = 9450000000000 * 4.22M;
            decimal distanceToCenterOfMilkyWay = 9450000000000 * 26000M;
            decimal milkyWayDiameter = 9450000000000 * 100000M;
            decimal distanceToObservableEnd = 9450000000000 * 46500000000M;

            Console.WriteLine($"{distanceToProximaCenturi:e2}");
            Console.WriteLine($"{distanceToCenterOfMilkyWay:e2}");
            Console.WriteLine($"{milkyWayDiameter:e2}");
            Console.WriteLine($"{distanceToObservableEnd:e2}");
        }
    }
}
