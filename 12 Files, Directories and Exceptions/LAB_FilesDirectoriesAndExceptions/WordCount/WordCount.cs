using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            string[] words = File.ReadAllText("words.txt").ToLower().Split();

            foreach (var w in words)
            {
                data[w] = 0;
            }

            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var w in text)
            {
                if (data.ContainsKey(w))
                {
                    data[w] += 1;
                }
            }

            using(StreamWriter writer = new StreamWriter("output.txt"))
            {
                var orderedData = data.OrderByDescending(x => x.Value);

                foreach (var item in orderedData)
                {
                   writer.WriteLine($"{item.Key}-{item.Value}");
                }
            }
            
        }
    }
}
