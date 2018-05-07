using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesAndCities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dict = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string continent = s[0];
                string country = s[1];
                string town = s[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new SortedDictionary<string, SortedSet<string>>();
                    dict[continent].Add(country, new SortedSet<string>());
                    dict[continent][country].Add(town);
                }
                else
                {
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new SortedSet<string>{town});
                    }
                    else
                    {
                        dict[continent][country].Add(town);
                    }
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (KeyValuePair<string, SortedSet<string>> country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
