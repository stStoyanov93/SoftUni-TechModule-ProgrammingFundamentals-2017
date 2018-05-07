using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"bigger type: {TypeOfData(a)}");
                Console.WriteLine($"smaller type: {TypeOfData(b)}");
                Console.WriteLine($"{a} can overflow {TypeOfData(b)} {Overflow(a, b)} times");
            }
            else
            {
                Console.WriteLine($"bigger type: {TypeOfData(b)}");
                Console.WriteLine($"smaller type: {TypeOfData(a)}");
                Console.WriteLine($"{b} can overflow {TypeOfData(a)} {Overflow(b, a)} times");
            }
        }

        public static string TypeOfData(ulong n)
        {
            if (n <= byte.MaxValue)
            {
                return "byte";
            }
            else if (n <= ushort.MaxValue)
            {
                return "ushort";
            }
            else if (n <= uint.MaxValue)
            {
                return "uint";
            }
            else
            {
                return "ulong";
            }
        }
        public static decimal Overflow(ulong bigger, ulong smaller)
        {
            decimal overflow = 0;

            if (TypeOfData(smaller) == "byte")
            {
                overflow = Math.Round((decimal)bigger / byte.MaxValue);
            }
            else if (TypeOfData(smaller) == "ushort")
            {
                overflow = Math.Round((decimal)bigger / ushort.MaxValue);
            }
            else if (TypeOfData(smaller) == "uint")
            {
                overflow = Math.Round((decimal)bigger / uint.MaxValue);
            }
            else
            {
                overflow = Math.Round((decimal)bigger / ulong.MaxValue);
            }

            return overflow;
        }
    }
}
