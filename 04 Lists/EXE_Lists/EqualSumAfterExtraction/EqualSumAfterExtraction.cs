using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list2.RemoveAll(x => list1.Any(y => y == x));


            if (list1.Sum() == list2.Sum())
            {
                Console.WriteLine($"Yes. Sum: {list1.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(list1.Sum() - list2.Sum())}");
            }
        }
    }
}
