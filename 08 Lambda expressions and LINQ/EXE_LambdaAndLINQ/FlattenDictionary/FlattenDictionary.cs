using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{

    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<InnerValuesCollection>> dict = new Dictionary<string, List<InnerValuesCollection>>();
            int index = 0;

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] arr = command.Split(' ');
                string key = arr[1];

                if (arr[0] == "flatten")
                {
                    if (dict.ContainsKey(key))
                    {
                        for (int i = 0; i < dict[key].Count; i++)
                        {
                            dict[key][i].Value = dict[key][i].Key + dict[key][i].Value;
                            dict[key][i].IsFlat = true;
                        }
                    }

                    continue;
                }

                string outerKey = arr[0];
                string innerKey = arr[1];
                string value = arr[2];

                if (!dict.ContainsKey(outerKey))
                {
                    dict[outerKey] = new List<InnerValuesCollection>();
                }

                bool isFound = false;

                foreach (var item in dict[outerKey])
                {
                    if (item.Key == innerKey && item.IsFlat == false)
                    {
                        item.Value = value;
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    dict[outerKey].Add(new InnerValuesCollection(innerKey, value, index));
                    index++;
                }
            }

            var orderedKeys = dict.OrderByDescending(x => x.Key.Length);

            foreach (var outerKey in orderedKeys)
            {
                int count = 1;

                Console.WriteLine($"{outerKey.Key}");

                var orderedList = outerKey.Value.OrderBy(x => x.Key.Length).Where(x => x.IsFlat == false);

                foreach (var i in orderedList)
                {
                    Console.WriteLine($"{count}. {i.Key} - {i.Value}");
                    count++;
                }

                var flats = outerKey.Value.OrderBy(x => x.EntryNumber).Where(x => x.IsFlat == true);

                foreach (var f in flats)
                {
                    Console.WriteLine($"{count}. {f.Value}");
                    count++;
                }
            }
        }
    }
}
