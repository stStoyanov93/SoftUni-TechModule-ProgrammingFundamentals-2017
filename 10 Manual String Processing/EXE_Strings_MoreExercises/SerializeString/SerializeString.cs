using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = new List<int>();
                }

                dict[input[i]].Add(i);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{String.Join("/", item.Value)}");
            }           
        }
    }
}
