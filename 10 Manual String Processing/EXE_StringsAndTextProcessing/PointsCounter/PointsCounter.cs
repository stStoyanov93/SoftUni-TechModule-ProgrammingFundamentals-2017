using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    class PointsCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var teams = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                input = CleanInput(input);
                string[] arr = input.Split('|');
                int points = int.Parse(arr[2]);
                string team;
                string player;

                if (char.IsLower(arr[0][1]))
                {
                    player = arr[0];
                    team = arr[1];
                }
                else
                {
                    team = arr[0];
                    player = arr[1];
                }

                if (!teams.ContainsKey(team))
                {
                    teams[team] = new Dictionary<string, int>();
                }

                teams[team][player] = points;

                input = Console.ReadLine();
            }

            Dictionary<string, int> finalPointsPerTeam = new Dictionary<string, int>();

            foreach (var item in teams)
            {
                finalPointsPerTeam[item.Key] = item.Value.Sum(x => x.Value);
            }

            var orderedData = finalPointsPerTeam.OrderByDescending(x => x.Value);

            foreach (var item in orderedData)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
                var MVP = teams[item.Key].OrderByDescending(x => x.Value).First();
                Console.WriteLine($"Most points scored by {MVP.Key}");
            }
        }

        public static string CleanInput(string fullInput)
        {
            fullInput = fullInput.Replace("@", "");
            fullInput = fullInput.Replace("%", "");
            fullInput = fullInput.Replace("$", "");
            fullInput = fullInput.Replace("*", "");

            return fullInput;
        }
    }
}
