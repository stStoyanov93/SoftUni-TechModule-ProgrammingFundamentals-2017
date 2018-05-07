using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();
            PopulateDictionary(arr, words);

            var orderedD = from entry in words orderby entry.Value descending select entry;
            int sum = words.Values.Sum();

            foreach (var item in orderedD)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times ({(item.Value / (double) sum * 100):F2}%)");
            }
        }

        private static void PopulateDictionary(string[] arr, Dictionary<string, int> words)
        {
            foreach (string item in arr)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words.Add(item, 1);
                }
            }
        }
    }
}
