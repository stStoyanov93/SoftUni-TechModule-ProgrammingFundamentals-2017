using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                s += Encrypt(ch);
            }
            Console.WriteLine(s);
        }

        public static string Encrypt(char ch)
        {
            int n = (int)ch;
            char[] chToArray = n.ToString().ToCharArray();

            string result = chToArray[0].ToString() + chToArray[chToArray.Length - 1].ToString();
            char newF = (char)(n + (chToArray[chToArray.Length - 1] - '0'));
            char newE = (char)(n - (chToArray[0] - '0'));
            result = newF.ToString() + result + newE.ToString();

            return result;
        }
    }
}
