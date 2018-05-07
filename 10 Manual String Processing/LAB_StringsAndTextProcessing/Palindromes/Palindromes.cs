using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '!', ',', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == String.Join("", words[i].Reverse()))
                {
                    palindromes.Add(words[i]);
                }
            }

            var sortedPalindromes = palindromes.Distinct().OrderBy(x => x);

            Console.WriteLine(string.Join(", ", sortedPalindromes));
            
        }
    }
}
