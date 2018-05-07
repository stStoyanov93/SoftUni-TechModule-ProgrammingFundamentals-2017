using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EX_DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

             sbyte first = -100;
             byte second = 128;
             short third = -3540;
             ushort fourth = 64876;
             uint fifth = 2147483648;
             long sixth = -1141583228L;
             BigInteger seventh = -1223372036854775808;

             Console.WriteLine(first);
             Console.WriteLine(second);
             Console.WriteLine(third);
             Console.WriteLine(fourth);
             Console.WriteLine(fifth);
             Console.WriteLine(sixth);
             Console.WriteLine(seventh);
             */

            /*
            decimal first = 3.141592653589793238M;
            double second = 1.60217657;
            decimal third = 7.8184261974584555216535342341M;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            */

            int a = int.Parse(Console.ReadLine()); ;
            int b = int.Parse(Console.ReadLine()); ;

            int c = b;

            b = a;
            a = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
