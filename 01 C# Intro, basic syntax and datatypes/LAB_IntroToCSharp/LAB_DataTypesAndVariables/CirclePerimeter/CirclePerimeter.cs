using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * 2 * r;

            Console.WriteLine($"{perimeter:F12}");
        }
    }
}
