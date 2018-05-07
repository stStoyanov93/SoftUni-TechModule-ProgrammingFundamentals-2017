using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Dict_Ref
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string command;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] pair = command.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(pair[1]) && pair[1].Any(Char.IsLetter))
                {
                    continue;
                }
                else if (!dict.ContainsKey(pair[1]))
                {
                    dict[pair[0]] = int.Parse(pair[1]);
                }
                else
                {
                    dict[pair[0]] = dict[pair[1]];
                }
            }

            foreach (string item in dict.Keys)
            {
                Console.WriteLine($"{item} === {dict[item]}");
            }

        }
    }
}
