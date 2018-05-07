using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 4 + 8 + 12;
            double courses = Math.Ceiling((double)n / capacity);
            Console.WriteLine(courses);
        }
    }
}
