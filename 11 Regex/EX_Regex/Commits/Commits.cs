using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commits
{
    public class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }

        public Commit(string h, string m, int a, int d)
        {
            Hash = h;
            Message = m;
            Additions = a;
            Deletions = d;
        }

        public override string ToString()
        {
            string result = string.Format($"    commit {Hash}: {Message} ({Additions} additions, {Deletions} deletions)");
            return result;
        }
    }

    public class Commits
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();
            Regex pattern = new Regex(@"^https:\/\/github\.com\/(?<user>[A-Za-z0-9-]+)\/(?<repository>[A-Za-z-_]+)\/commit\/(?<hash>[A-Fa-f0-9]{40}),(?<message>[^\n]+),(?<additions>[0-9]+),(?<deletions>[0-9]+)$");

            string input = Console.ReadLine();

            while (input != "git push")
            {
                if (pattern.IsMatch(input))
                {
                    Match m = pattern.Match(input);
                    string user = m.Groups["user"].Value;
                    string repository = m.Groups["repository"].Value;
                    string hash = m.Groups["hash"].Value;
                    string message = m.Groups["message"].Value;
                    int additions = int.Parse(m.Groups["additions"].Value);
                    int deletions = int.Parse(m.Groups["deletions"].Value);

                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, new SortedDictionary<string, List<Commit>>());
                    }
                    if (!users[user].ContainsKey(repository))
                    {
                        users[user].Add(repository, new List<Commit>());
                    }
                    users[user][repository].Add(new Commit(hash, message, additions, deletions));                   
                }

                input = Console.ReadLine();
            }

            foreach (var gitUser in users)
            {
                var userName = gitUser.Key;
                var repositories = gitUser.Value;

                Console.WriteLine($"{userName}:");

                foreach (var repository in repositories)
                {
                    string repo = repository.Key;
                    List<Commit> commits = repository.Value;

                    int totalAdditions = commits.Sum(x => x.Additions);
                    int totalDeletions = commits.Sum(x => x.Deletions);

                    Console.WriteLine($"  {repo}:");

                    foreach (var commit in commits)
                    {
                        Console.WriteLine(commit);
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }

        }
    }
}
