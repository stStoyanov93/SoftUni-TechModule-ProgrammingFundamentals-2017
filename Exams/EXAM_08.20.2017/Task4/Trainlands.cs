using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Wagon
    {
        public long wagonPower { get; set; }
        public string Name { get; set; }

        public Wagon(string name, long power)
        {
            this.Name = name;
            this.wagonPower = power;
        }
    }

    class Trainlands
    {
        public static void Main()
        {
            var data = new Dictionary<string, List<Wagon>>();
            string input;

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                var tokens = input.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[2];
                    long wagonPower = long.Parse(tokens[3]);

                    if (!data.ContainsKey(trainName))
                    {
                        data[trainName] = new List<Wagon>();
                    }

                    data[trainName].Add(new Wagon(wagonName, wagonPower));
                }
                else if (tokens[1] == "=")
                {
                    string trainName = tokens[0];
                    string otherTrain = tokens[2];

                    if (!data.ContainsKey(trainName))
                    {
                        data[trainName] = new List<Wagon>();
                    }

                    data[trainName].Clear();

                    foreach (var item in data[otherTrain])
                    {
                        data[trainName].Add(new Wagon(item.Name, item.wagonPower));
                    }
                }
                else if (tokens[1] == "->")
                {
                    string trainName = tokens[0];
                    string otherTrain = tokens[2];

                    if (!data.ContainsKey(trainName))
                    {
                        data[trainName] = new List<Wagon>();
                    }

                    foreach (var item in data[otherTrain])
                    {
                        data[trainName].Add(new Wagon(item.Name, item.wagonPower));
                    }

                    data.Remove(otherTrain);
                }
            }

            var orderedData = data.OrderByDescending(x => x.Value.Sum(y => y.wagonPower)).ThenBy(x => x.Value.Count);

            foreach (var item in orderedData)
            {
                Console.WriteLine($"Train: {item.Key}");

                var orderedWagons = item.Value.OrderByDescending(x => x.wagonPower);

                foreach (var wg in orderedWagons)
                {
                    Console.WriteLine($"###{wg.Name} - {wg.wagonPower}");
                }
            }
        }       
    }
}
