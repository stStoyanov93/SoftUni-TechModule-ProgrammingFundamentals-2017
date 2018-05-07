using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int sum = 0;
            int count = 0;

            foreach (string item in arr)
            {
                foreach (char ch in item)
                {
                    sum += ch;
                    count++;
                }
            }

            char average = Convert.ToChar(sum / count);
            Console.WriteLine(String.Join(average.ToString().ToUpper(), arr));
        }
    }
}
