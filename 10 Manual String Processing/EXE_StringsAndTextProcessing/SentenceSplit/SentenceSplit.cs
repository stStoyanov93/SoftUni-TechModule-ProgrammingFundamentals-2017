using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string[] arr = sentence.Split(new string[] { delimeter }, StringSplitOptions.None);

            Console.WriteLine("[" + String.Join(", ", arr) +"]");

        }
    }
}
