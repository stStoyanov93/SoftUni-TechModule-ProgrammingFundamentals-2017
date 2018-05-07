using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            string[] doublesAsStrings = Console.ReadLine().Split(' ');
            List<char> word = new List<char>();
            
            for (int i = 0; i < doublesAsStrings.Length; i++)
            {
                string[] frequence = new string[2];
                frequence = doublesAsStrings[i].Split('.');

                char leftLetter = Convert.ToChar(int.Parse(frequence[0]));
                char rightLetter = Convert.ToChar(int.Parse(frequence[1]));

                if (leftLetter != 0)
                {
                    word.Insert(i, leftLetter);
                }
                if (rightLetter != 0)
                {
                    word.Insert(word.Count - i, rightLetter);
                }
            }

            Console.WriteLine(String.Join("", word));
        }      
    }
}
