using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> list1 = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    list1.Add(list[i]);
                }
            }

            Console.WriteLine(String.Join("", list1));
        }
    }
}
