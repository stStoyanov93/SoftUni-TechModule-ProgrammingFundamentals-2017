using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l;

            for (int i = 0; i < n; i++)
            {
                l = int.Parse(Console.ReadLine());
                Console.Write((char)l);
            }
        }
    }
}
