using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string randomLetters = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char letter in randomLetters)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter]++;
                }
                else
                {
                    dict[letter] = 1;
                }
            }

            foreach (char key in dict.Keys)
            {
                Console.WriteLine($"{key} -> {dict[key]}");
            }

        }
    }
}
