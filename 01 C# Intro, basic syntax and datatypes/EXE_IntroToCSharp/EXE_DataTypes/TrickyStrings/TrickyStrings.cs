using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                if (i == n -1)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    Console.Write(input + delimeter);
                }
            }
        }
    }
}
