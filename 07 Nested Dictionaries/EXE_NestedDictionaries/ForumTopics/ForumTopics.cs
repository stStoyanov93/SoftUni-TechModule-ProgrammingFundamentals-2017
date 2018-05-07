using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "filter")
                {
                    break;
                }

                string[] tokens = command.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    dict[key].Add(tokens[i]);
                    dict[key] = dict[key].Distinct().ToList();
                }               
            }



            string[] tagsToLookFor = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in dict)
            {
                bool isContained = true;

                foreach (string tag in tagsToLookFor)
                {
                    if (!item.Value.Contains(tag))
                    {
                        isContained = false;
                        break;
                    }
                }

                if (isContained)
                {
                    Console.WriteLine($"{item.Key} | {String.Join(", ", item.Value.Select(x => "#" + x))}");
                }
            }
        }
    }
}
