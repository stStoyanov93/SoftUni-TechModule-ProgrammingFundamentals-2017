using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Spyfer
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {

                if (i != 0 && i != list.Count - 1)
                {
                    int neghboursSum = list[i - 1] + list[i + 1];

                    if (list[i] == neghboursSum)
                    {
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && list[i] == list[i + 1])
                {
                    list.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i == list.Count - 1 && list[i] == list[i - 1])
                {
                    list.RemoveAt(i - 1);
                    i = 0;
                }
            }

           
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
