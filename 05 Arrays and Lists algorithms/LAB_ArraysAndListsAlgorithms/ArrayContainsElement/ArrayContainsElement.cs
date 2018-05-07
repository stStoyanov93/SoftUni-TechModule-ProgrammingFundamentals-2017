using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            List<int> l = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
            int element = int.Parse(Console.ReadLine());

            foreach (int item in l)
            {
                if (item == element)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
