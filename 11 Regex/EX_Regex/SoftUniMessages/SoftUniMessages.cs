using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniMessages
{
    class SoftUniMessages
    {
        static void Main(string[] args)
        {
            Regex patternRegex = new Regex(@"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]+$");

            string input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                int validMessageLenght = int.Parse(Console.ReadLine());

                if (patternRegex.IsMatch(input))
                {
                    Match m = patternRegex.Match(input);
                    string message = m.Groups["message"].Value;

                    if (message.Length == validMessageLenght)
                    {
                        string decodedMessage = Decode(input, message);

                        Console.WriteLine($"{message} = {decodedMessage}");
                    }
                }

                input = Console.ReadLine();
            }
        }

        public static string Decode(string input, string message)
        {
            var result = String.Empty;

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol) && (symbol - '0' < message.Length))
                {
                    result += message[symbol - '0'];
                }
            }

            return result;
        }
    }
}
