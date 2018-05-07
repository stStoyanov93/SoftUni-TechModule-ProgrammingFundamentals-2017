using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
            string command;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Over")
                {
                    break;
                }

                string[] pair = command.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (pair[0].All(Char.IsDigit))
                {
                    dict[pair[1]] = long.Parse(pair[0]);
                }
                else
                {
                    dict[pair[0]] = long.Parse(pair[1]);
                }
            }

            foreach (string item in dict.Keys)
            {
                Console.WriteLine($"{item} -> {dict[item]}");
            }
        }
    }
}
