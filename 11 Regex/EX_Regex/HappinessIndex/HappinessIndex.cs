using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HappinessIndex
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happy = new Regex(@":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;");
            Regex sad = new Regex(@":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];");

            string input = Console.ReadLine();

            var happyMatches = happy.Matches(input);
            var sadMatches = sad.Matches(input);

            double index = (double)happyMatches.Count / sadMatches.Count;
            string face = string.Empty;

            if (index >= 2)
            {
                face = ":D";
            }
            else if (index > 1)
            {
                face = ":)";
            }
            else if (index == 1)
            {
                face = ":|";
            }
            else
            {
                face = ":(";
            }

            Console.WriteLine($"Happiness index: {index:F2} {face}");
            Console.WriteLine($"[Happy count: {happyMatches.Count}, Sad count: {sadMatches.Count}]");
        }
    }
}
