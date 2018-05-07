using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {              
                int n;

                for (int i = 0; i < 100; i++)
                {
                    n = int.Parse(Console.ReadLine());
                    count++;
                }

                Console.WriteLine(count);
            }
            catch (Exception)
            {

                Console.WriteLine(count);
            }
        }
    }
}
