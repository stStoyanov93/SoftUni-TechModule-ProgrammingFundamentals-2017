using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetArmada
{
    public class Legion
    {
        public int Activity { get; set; }
        public Dictionary<string, long> Soldiers;

        public Legion()
        {
            this.Soldiers = new Dictionary<string, long>();
        }
    }
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legions = new Dictionary<string, Legion>();
            string input = String.Empty;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split(new[] {" = ", " -> ", ":"}, StringSplitOptions.RemoveEmptyEntries);

                string legionName = tokens[1];
                int activity = int.Parse(tokens[0]);
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = new Legion();
                    legions[legionName].Activity = activity;
                    legions[legionName].Soldiers.Add(soldierType, soldierCount);
                }
                else
                {
                    if (legions[legionName].Activity < activity)
                    {
                        legions[legionName].Activity = activity;
                    }

                    if (!legions[legionName].Soldiers.ContainsKey(soldierType))
                    {
                        legions[legionName].Soldiers.Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legions[legionName].Soldiers[soldierType] += soldierCount;
                    }
                }
            }

            input = Console.ReadLine();
            Regex patternwithActivity = new Regex(@"\d+\\.");

            if (patternwithActivity.IsMatch(input))
            {
                string[] arr = input.Split('\\');
                int aboveAllowedActivity = int.Parse(arr[0]);
                string type = arr[1];

                var soldiers = legions.Where(x => x.Value.Activity < aboveAllowedActivity &&
                                                  x.Value.Soldiers.ContainsKey(type)).
                                                  OrderByDescending(x => x.Value.Soldiers[type]);
                                                  

                foreach (var soldier in soldiers)
                {
                    Console.WriteLine($"{soldier.Key} -> {soldier.Value.Soldiers[type]}");
                }
            }
            else
            {
                var soldiers = legions.Where(x => x.Value.Soldiers.ContainsKey(input))
                    .OrderByDescending(x => x.Value.Activity);

                foreach (var soldier in soldiers)
                {
                    Console.WriteLine($"{soldier.Value.Activity} : {soldier.Key}");
                }
            }


        }
    }
}
