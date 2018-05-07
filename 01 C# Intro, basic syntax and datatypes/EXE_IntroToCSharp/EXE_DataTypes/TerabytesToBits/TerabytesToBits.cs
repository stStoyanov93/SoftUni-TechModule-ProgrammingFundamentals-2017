using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerabytesToBits
{
    class TerabytesToBits
    {
        static void Main(string[] args)
        {
            double tb = double.Parse(Console.ReadLine());

            decimal bits = ((decimal)Math.Pow(1024, 4) * 8) * (decimal)tb;

            Console.WriteLine(Math.Round(bits));
        }
    }
}
