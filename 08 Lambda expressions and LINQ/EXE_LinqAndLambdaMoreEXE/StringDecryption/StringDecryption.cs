using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            int[] helperNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int m = helperNumbers[0];
            int n = helperNumbers[1];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] asciiNumbers = numbers.Where(x => x >= 65 && x <= 90).Skip(m).Take(n).ToArray();

            Console.WriteLine(String.Join("", asciiNumbers.Select(x => (char)x)));
        }
    }
}