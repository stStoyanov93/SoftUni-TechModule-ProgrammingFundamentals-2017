using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", intList.Distinct()));
        }
    }
}
