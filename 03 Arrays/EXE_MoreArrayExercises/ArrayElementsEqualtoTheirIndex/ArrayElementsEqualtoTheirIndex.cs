using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualtoTheirIndex
{
    class ArrayElementsEqualtoTheirIndex
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> intsToIndexes = new List<int>();

            for (int i = 0; i < ints.Length; i++)
            {
                if (i == ints[i])
                {
                    intsToIndexes.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", intsToIndexes));
        }
    }
}
