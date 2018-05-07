using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < list.Count; i++)
            {
                for (int y = i; y > 0; y--)
                {
                    if (list[y - 1] < list[y])
                    {
                        int temp = list[y];
                        list[y] = list[y - 1];
                        list[y - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
