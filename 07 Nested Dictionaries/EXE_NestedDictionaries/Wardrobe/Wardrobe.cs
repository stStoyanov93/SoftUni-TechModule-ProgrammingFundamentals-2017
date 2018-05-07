using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] clothes = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = clothes[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();

                    for (int y = 1; y < clothes.Length; y++)
                    {
                        /* 
                          if (clothes[y] == "-")
                        {
                            continue;
                        } 
                        */

                        if (!wardrobe[color].ContainsKey(clothes[y]))
                        {
                            wardrobe[color].Add(clothes[y], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[y]]++;
                        }
                    }
                }
                else
                {
                    for (int y = 1; y < clothes.Length; y++)
                    {
                       /* 
                         if (clothes[y] == "-")
                        {
                            continue;
                        } 
                        */

                        if (!wardrobe[color].ContainsKey(clothes[y]))
                        {
                            wardrobe[color].Add(clothes[y], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[y]]++;
                        }
                    }
                }
            }

            string[] clothToFind = Console.ReadLine().Split(' ');

            foreach (KeyValuePair<string, Dictionary<string, int>> mK in wardrobe)
            {
                Console.WriteLine($"{mK.Key} clothes:");

                foreach (KeyValuePair<string, int> item in mK.Value)
                {
                    if (mK.Key == clothToFind[0] && item.Key == clothToFind[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
