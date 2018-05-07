using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbers
{
    class CountOfOddNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) % 2 != 0) 
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
