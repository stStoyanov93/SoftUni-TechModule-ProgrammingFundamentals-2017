using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> list = new List<int>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                bool inserted = false;
                int currentElement = arr[i];

                for (int y = 0; y < list.Count; y++)
                {
                    int currentListElement = list[y];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        list.Insert(Math.Max(0, y), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    list.Add(currentElement);
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
