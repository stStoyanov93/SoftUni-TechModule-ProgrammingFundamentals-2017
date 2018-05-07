using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListinHalf
{
    class TearListinHalf
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> copy = new List<string>();
            bool isNotLast = true;
            int iCount = list.Count / 2;
            int y = 0;

            while (isNotLast)
            {
                for (int i = 0; i < list.Count / 2; i += 3)
                {
                    if (iCount >= list.Count)
                    {
                        isNotLast = false;
                        break;
                    }

                    copy.Add(list[iCount][0].ToString());
                    copy.Add(list[y]);
                    copy.Add(list[iCount][1].ToString());

                    y++;
                    iCount++;
                }
            }

            Console.WriteLine(String.Join(" ", copy));

        }
    }
}
