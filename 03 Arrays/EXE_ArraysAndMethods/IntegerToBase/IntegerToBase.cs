using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(n, b));
        }

        public static string IntToBase(long n, int b)
        {
            string result = String.Empty;

            while(n > 0)
            {
                result = (n % b).ToString() + result;
                n /= b;
            }

            return result;
        }
    }
}
