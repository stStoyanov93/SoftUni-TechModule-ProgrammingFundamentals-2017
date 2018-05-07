using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesbyContinentandCountry
{
    class CitiesbyContinentandCountry
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');

                if (!dict.ContainsKey(arr[0]))
                {
                    dict[arr[0]] = new Dictionary<string, List<string>>();

                    if (!dict[arr[0]].ContainsKey(arr[1]))
                    {
                        dict[arr[0]].Add(arr[1], new List<string>{ arr[2]});
                    }
                    else
                    {
                        dict[arr[0]][arr[1]].Add(arr[2]);
                    }
                }
                else
                {
                    if (!dict[arr[0]].ContainsKey(arr[1]))
                    {
                        dict[arr[0]].Add(arr[1], new List<string> { arr[2] });
                    }
                    else
                    {
                        dict[arr[0]][arr[1]].Add(arr[2]);
                    }
                }               
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (KeyValuePair<string, List<string>> country in continent.Value)
                {                    
                    Console.WriteLine($" {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
