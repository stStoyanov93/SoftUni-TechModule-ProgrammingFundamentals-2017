using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            bool longBooleanCheck = noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") ||
                noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z");

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1, 1);
                noun += "ies";          
            }
            else if (longBooleanCheck)
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }

            Console.WriteLine(noun);
        }
    }
}
