using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitbyWordCasing
{
    class SplitbyWordCasing
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\'', '"', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> uppercase = new List<string>();
            List<string> lowercase = new List<string>();
            List<string> mixedcase = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != "," || text[i] != " ")
                {
                    if (isUpperCase(text[i]))
                    {
                        uppercase.Add(text[i]);
                    }
                    else if (isLowerCase(text[i]))
                    {
                        lowercase.Add(text[i]);
                    }
                    else
                    {
                        mixedcase.Add(text[i]);
                    }
                }                
            }

            Console.WriteLine($"Lower-case: " + String.Join(", ", lowercase));
            Console.WriteLine($"Mixed-case: " + String.Join(", ", mixedcase));
            Console.WriteLine($"Upper-case: " + String.Join(", ", uppercase));
        }

        public static bool isUpperCase(string word)
        {          
            bool isUppercase = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    return false;
                }

                if (char.IsLower(word[i]))
                {
                    return false;
                }       
            }

            return isUppercase;
        }
        public static bool isLowerCase(string word)
        {
            bool isLowerCase = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    return false;
                }

                if (char.IsUpper(word[i]))
                {
                    isLowerCase = false;
                    break;
                }
            }

            return isLowerCase;
        }
    }
}
