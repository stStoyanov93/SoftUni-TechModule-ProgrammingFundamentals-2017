using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> shells = new Dictionary<string, List<int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Aggregate")
                {
                    break;
                }

                string[] arr = command.Split(' ');
                string region = arr[0];
                int size = int.Parse(arr[1]);

                if (!shells.ContainsKey(region))
                {
                    shells[region] = new List<int>();
                }

                if (!shells[region].Contains(size))
                {
                    shells[region].Add(size);
                }
            }

            foreach (KeyValuePair<string, List<int>> item in shells)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(", ", item.Value)} ({Math.Round(item.Value.Sum() - item.Value.Average(), MidpointRounding.AwayFromZero)})");
            }
        }
    }
}
