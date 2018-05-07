using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop the game")
                {
                    break;
                }

                string[] arr = command.Split('|');
                string team = arr[1];
                string player = arr[0];
                int points = int.Parse(arr[2]);

                if (!teams.ContainsKey(team))
                {
                    teams[team] = new Dictionary<string, int>();
                }

                if (teams[team].Count >= 3)
                {
                    continue;
                }
                else
                {
                    teams[team][player] = points;
                }
            }

            teams = teams.OrderByDescending(x => x.Value.Sum(y => y.Value)).ToDictionary(x => x.Key, y => y.Value);

            int teamRanking = 1;

            foreach (var team in teams)
            {
                string teamName = team.Key;
                var players = team.Value.OrderByDescending(x => x.Value);

                Console.WriteLine($"{teamRanking}. {teamName}; Players:");


            }
        }
    }
}
