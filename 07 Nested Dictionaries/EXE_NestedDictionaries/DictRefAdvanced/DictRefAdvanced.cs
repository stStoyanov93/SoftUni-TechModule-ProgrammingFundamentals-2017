using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(new string[] { "->", " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string otherKey = tokens[1];
                char[] checkIfDigit = tokens[1].ToCharArray();

                if (Char.IsDigit(checkIfDigit[0]))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        dict[name].Add(int.Parse(tokens[i]));
                    }
                }
                else if (!dict.ContainsKey(otherKey))
                {
                    continue;
                }
                else
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = new List<int>();
                    }

                    for (int i = 0; i < dict[otherKey].Count; i++)
                    {
                        dict[name].Add(dict[otherKey][i]);
                    }
                }
            }

            foreach (var k in dict)
            {
                Console.WriteLine($"{k.Key} === {String.Join(", ", k.Value)}");
            }
        }
    }
}
