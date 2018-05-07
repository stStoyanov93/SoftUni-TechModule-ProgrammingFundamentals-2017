using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Dictionary<string, int>> destinations = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "ready")
                {
                    break;
                }

                string[] arr = command.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string city = arr[0];

                if (!destinations.ContainsKey(city))
                {
                    destinations[city] = new Dictionary<string, int>();
                }

                for (int y = 1; y < arr.Length; y++)
                {
                    string[] transport = arr[y].Split(new char[] { '-' });

                    
                        destinations[city][transport[0]] = int.Parse(transport[1]);
                    
                   
                }
            }

            while (true)
            {
                command = Console.ReadLine();

                if (command == "travel time!")
                {
                    break;
                }

                string[] destination = command.Split(' ');
                string city = destination[0];
                int seats = int.Parse(destination[1]);

                foreach (var k in destinations.Keys)
                {
                    if (k == city)
                    {
                        int sum = 0;

                        foreach (KeyValuePair<string, int> item in destinations[k])
                        {
                            sum += item.Value;
                        }

                        sum -= seats;

                        if (sum >= 0)
                        {
                            Console.WriteLine($"{city} -> all {seats} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{city} -> all except {Math.Abs(sum)} accommodated");
                        }
                    }
                }
            }

        }
    }
}
