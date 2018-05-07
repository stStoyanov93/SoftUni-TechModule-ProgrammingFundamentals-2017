using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] arr = command.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                dict[arr[0]] = arr[1];
            }

            Dictionary<string, string> dictNotNull = dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, y => y.Value);
            Dictionary<string, string> nulls = dict.Where(x => x.Value == "null").ToDictionary(x => x.Key, y => y.Value);

            string valueToReplace = Console.ReadLine();

            foreach (var item in dict.Keys)
            {
                if (dict[item] == "null")
                {
                    nulls[item] = valueToReplace;
                }
            }

            foreach (var item in dictNotNull)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in nulls)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");                
            }
        }
    }
}
