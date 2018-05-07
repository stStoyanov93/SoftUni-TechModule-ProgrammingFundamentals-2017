using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {          
            string regex = @"(?<=[SHDC]|^)([2-9JKAQ]|10)[SHDC]";
            string input = Console.ReadLine();
            
            var matches = Regex.Matches(input, regex)
                .OfType<Match>()
                .Select(x => x.Groups[0].Value)
                .ToArray();

                Console.WriteLine(String.Join(", ", matches));           
        }
    }
}
