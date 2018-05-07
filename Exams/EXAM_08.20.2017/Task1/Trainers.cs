using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Trainers
    {
        static void Main(string[] args)
        {
            checked
            {
                Dictionary<string, decimal> data = new Dictionary<string, decimal>();
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    long distanceInMeters = long.Parse(Console.ReadLine()) * 1600L;
                    decimal cargoInKG = decimal.Parse(Console.ReadLine()) * 1000.0M;
                    string teamName = Console.ReadLine();

                    decimal participantEarnedMoney = (cargoInKG * 1.5M) - (0.7M * distanceInMeters * 2.5M);

                    if (!data.ContainsKey(teamName))
                    {
                        data.Add(teamName, participantEarnedMoney);
                    }
                    else
                    {
                        data[teamName] += participantEarnedMoney;
                    }

                    
                }

                string bestTeam = string.Empty;
                decimal bestScore = decimal.MinValue;

                foreach (var item in data)
                {
                    if (item.Value > bestScore)
                    {
                        bestTeam = item.Key;
                        bestScore = item.Value;
                    }
                }

                if (bestTeam != string.Empty)
                {
                    Console.WriteLine($"The {bestTeam} Trainers win with ${Math.Round(bestScore, 3, MidpointRounding.AwayFromZero):F3}.");
                }

                foreach (var item in data)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                
            }
        }
    }
}
