using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double heavyWindsMiles = double.Parse(Console.ReadLine());

            double milesInNormalWinds = distance - heavyWindsMiles;
            double consumptionInNormalWinds = milesInNormalWinds * 25;
            double consumptionInHeavyWinds = heavyWindsMiles * (25 * 1.5);
            double totalConsumption = consumptionInHeavyWinds + consumptionInNormalWinds +
                                      ((consumptionInHeavyWinds + consumptionInNormalWinds) * 0.05);

            Console.WriteLine($"Fuel needed: {Math.Round(totalConsumption, 2, MidpointRounding.AwayFromZero):F2}L");

            double fuelLeft = tankCapacity - totalConsumption;

            if (fuelLeft >= 0)
            {
                Console.WriteLine($"Enough with {Math.Round(fuelLeft, 2, MidpointRounding.AwayFromZero):F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Round(Math.Abs(fuelLeft), 2, MidpointRounding.AwayFromZero):F2}L more fuel.");
            }
        }
    }
}
