using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatStr(input, count);
        }

        public static void RepeatStr(string input, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(input);
            }
        }
    }
}
