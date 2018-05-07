using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            if (command == "Min")
            {
                Console.WriteLine(nums.Where(x => x >= nums.Average()).Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(nums.Where(x => x >= nums.Average()).Max());
            }
            else if (command == "All")
            {
                Console.WriteLine(String.Join(" ", nums.Where(x => x >= nums.Average()).OrderBy(x => x).ToList()));
            }
        }
    }
}
