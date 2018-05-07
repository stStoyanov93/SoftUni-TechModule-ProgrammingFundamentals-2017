using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SayHello(input);
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
