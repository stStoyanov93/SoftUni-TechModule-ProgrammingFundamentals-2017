using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseCharactersAndStringsAndNext2
{
    class PractiseCharactersAndStringsAndNext2
    {
        static void Main(string[] args)
        {
            /*
            string university = "Software University";
            char firstL = 'B';
            char secondL = 'y';
            char thirdL = 'e';
            string final = "I love programming";

            Console.WriteLine(university);
            Console.WriteLine(firstL);
            Console.WriteLine(secondL);
            Console.WriteLine(thirdL);
            Console.WriteLine(final);
            */

            /* Hexadecimal format
            int n = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(n);
            */

            string input = Console.ReadLine();

            switch (input)
            {
                case "zero":
                    Console.WriteLine(0);
                    break;
                case "one":
                    Console.WriteLine(1);
                    break;
                case "two":
                    Console.WriteLine(2);
                    break;
                case "three":
                    Console.WriteLine(3);
                    break;
                case "four":
                    Console.WriteLine(4);
                    break;
                case "five":
                    Console.WriteLine(5);
                    break;
                case "six":
                    Console.WriteLine(6);
                    break;
                case "seven":
                    Console.WriteLine(7);
                    break;
                case "eight":
                    Console.WriteLine(8);
                    break;
                case "nine":
                    Console.WriteLine(9);
                    break;
            }
        }
    }
}
