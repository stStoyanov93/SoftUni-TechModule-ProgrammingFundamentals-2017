using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> dict= new Dictionary<int, int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            List<int> keys = dict.Keys.ToList();
            keys.Sort();

            for (int i = 0; i < keys.Count; i++)
            {
                Console.WriteLine($"{keys[i]} -> {dict[keys[i]]}");
            }
        }
    }
}
