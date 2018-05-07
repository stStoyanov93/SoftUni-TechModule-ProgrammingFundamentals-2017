using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class RV
    {
        public int NightStayed { get; set; }
        public List<string> RVs;

        public RV()
        {
            RVs = new List<string>();
        }

    }

    class Camping
    {
        static void Main(string[] args)
        {
            Dictionary<string, RV> campers = new Dictionary<string, RV>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');
                string name = tokens[0];
                string typeOfRV = tokens[1];
                int nightsStaying = int.Parse(tokens[2]);

                if (!campers.ContainsKey(name))
                {
                    campers[name] = new RV();
                }

                campers[name].NightStayed += nightsStaying;
                campers[name].RVs.Add(typeOfRV);

            }

            var orderedCampers = campers.OrderByDescending(x => x.Value.RVs.Count).ThenBy(x => x.Key.Length);

            foreach (var kvp in orderedCampers)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.RVs.Count}");

                foreach (var item in kvp.Value.RVs)
                {
                    Console.WriteLine($"***{item}");
                }

                Console.WriteLine($"Total stay: {kvp.Value.NightStayed} nights");
            }
        }
    }
}
