using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordEncounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            string tokens = Console.ReadLine();
            char ASCIIsymbol = tokens[0];
            int minCount = int.Parse(tokens[1].ToString());

            string sentenceMatch = @"^[A-Z].*[!\?\.]$";
            string wordExtractor = @"\w+";

            List<string> validMatches = new List<string>();
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (!Regex.IsMatch(input, sentenceMatch))
                {
                    continue;
                }

                List<string> allWords = Regex.Matches(input, wordExtractor)
                .OfType<Match>()
                .Select(x => x.Groups[0].Value)
                .ToList();

               
                foreach (var item in allWords)
                {
                    int count = 0;

                    foreach (var c in item)
                    {
                        if (c == ASCIIsymbol)
                        {
                            count++;
                        }
                    }

                    if (count >= minCount)
                    {
                        validMatches.Add(item);
                    }
                }             
            }

            Console.WriteLine(String.Join(", ", validMatches));
        }
    }
}
