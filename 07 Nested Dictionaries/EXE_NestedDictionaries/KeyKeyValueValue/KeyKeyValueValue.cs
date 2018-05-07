using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(new string[] { ";", " => "}, StringSplitOptions.RemoveEmptyEntries);

                for (int y = 1; y < s.Length; y++)
                {
                    if (!dict.ContainsKey(s[0]))
                    {
                        dict.Add(s[0], new List<string>());
                    }

                    dict[s[0]].Add(s[y]);                                   
                }
            }

            foreach (string mK in dict.Keys)
            {
                if (mK.Contains(key))
                {
                    Console.WriteLine($"{mK}:");

                    foreach (string item in dict[mK])
                    {
                        if (item.Contains(value))
                        {
                            Console.WriteLine($"-{item}");
                        }
                    }
                }
            }          
        }
    }
}
