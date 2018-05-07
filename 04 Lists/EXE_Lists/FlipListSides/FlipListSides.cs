using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lastPosition = list.Count - 1;

            for (int i = 1; i < list.Count / 2; i++)
            {
                int switchElement = list[i];

                list[i] = list[lastPosition - i];
                list[lastPosition - i] = switchElement;
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
