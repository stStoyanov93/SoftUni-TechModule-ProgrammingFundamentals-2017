using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Spy
    {
        public string SpyName { get; set; }
        public ulong DaysInService { get; set; }
        

        public Spy(string name, ulong days)
        {
            this.SpyName = name;
            this.DaysInService = days;

        }
    }
    class NSA
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<Spy>> spies = new Dictionary<string, List<Spy>>();

            while ((input = Console.ReadLine()) != "quit")
            {
                string[] arr = input.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string country = arr[0];
                string name = arr[1];
                ulong daysServed = ulong.Parse(arr[2]);

                if (!spies.ContainsKey(country))
                {
                    spies.Add(country, new List<Spy>());
                }

                if (spies[country].Any(x => x.SpyName == name))
                {
                    foreach (var v in spies[country])
                    {
                        if (v.SpyName == name)
                        {
                            v.DaysInService = daysServed;
                            break;
                        }
                    }
                }
                else
                {
                    spies[country].Add(new Spy(name, daysServed));
                }
            }

            var orderedData = spies.OrderByDescending(x => x.Value.Count);

            foreach (var country in orderedData)
            {
                Console.WriteLine($"Country: {country.Key}");

                var orderedSpies = country.Value.OrderByDescending(x => x.DaysInService);

                foreach (var spy in orderedSpies)
                {
                    Console.WriteLine($"**{spy.SpyName} : {spy.DaysInService}");
                }
            }
        }
    }
}
