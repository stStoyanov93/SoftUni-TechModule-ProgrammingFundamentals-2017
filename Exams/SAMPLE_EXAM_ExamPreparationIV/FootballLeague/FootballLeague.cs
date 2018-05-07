using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Scores
    {
        public int Goals { get; set; }
        public int Score { get; set; }
    }
    class FootballLeague
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string escapeKey = Regex.Escape(key);
            string formatttedStr =
                string.Format(
                    @"(?<={0})(?<teamA>[A-Za-z]*)(?={0}).*(?<={0})(?<teamB>[A-Za-z]*)(?={0})[^ ]+ (?<scoreA>\d+):(?<scoreB>\d+)",
                    escapeKey);
            Regex pattern = new Regex(formatttedStr);
            string input;
            var countries = new Dictionary<string, Scores>();

            while ((input = Console.ReadLine()) != "final")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string teamA = String.Join("", match.Groups["teamA"].Value.ToUpper().ToCharArray().Reverse());
                    string teamB = String.Join("", match.Groups["teamB"].Value.ToUpper().ToCharArray().Reverse());
                    int goalsA = int.Parse(match.Groups["scoreA"].Value);
                    int goalsB = int.Parse(match.Groups["scoreB"].Value);

                    if (!countries.ContainsKey(teamA))
                    {
                        countries[teamA] = new Scores();
                    }
                    
                    countries[teamA].Goals += goalsA;

                    if (!countries.ContainsKey(teamB))
                    {
                        countries[teamB] = new Scores();
                    }

                    countries[teamB].Goals += goalsB;

                    if (goalsA > goalsB)
                    {
                        countries[teamA].Score += 3;
                    }
                    else if (goalsA < goalsB)
                    {
                        countries[teamB].Score += 3;
                    }
                    else
                    {
                        countries[teamA].Score += 1;
                        countries[teamB].Score += 1;
                    }

                }
            }

            var orderedData = countries.OrderByDescending(x => x.Value.Score).ThenBy(x => x.Key);
            int index = 1;

            Console.WriteLine("League standings:");
            foreach (var team in orderedData)
            {
                Console.WriteLine($"{index}. {team.Key} {team.Value.Score}");
                index++;
            }

            var orderedByGoals = countries.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3);

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in orderedByGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }
    }
}
