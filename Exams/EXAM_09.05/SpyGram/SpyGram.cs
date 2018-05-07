using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpyGram
{
    class Message
    {
        public string sender { get; set; }
        public string decryptedMessage { get; set; }

        public Message(string s, string m)
        {
            this.sender = s;
            this.decryptedMessage = m;
        }
    }
    class SpyGram
    {
        static void Main(string[] args)
        {
            int[] privateKey = Console.ReadLine().ToCharArray().Select(x => x - '0').ToArray();
            Regex pattern = new Regex(@"^TO: (?<sender>[A-Z]+); MESSAGE: .+;$");
            List<Message> messages = new List<Message>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string s = match.Groups["sender"].Value;
                    string message = DecryptedMSG(privateKey, match.Value);

                    messages.Add(new Message(s, message));
                }
            }

            var orderedData = messages.OrderBy(x => x.sender);

            foreach (var m in orderedData)
            {
                Console.WriteLine(m.decryptedMessage);
            }
        }

        public static string DecryptedMSG(int[] key, string msg)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;

            for (int i = 0; i < msg.Length; i++)
            {
                if (index == key.Length)
                {
                    index = 0;
                }

                sb.Append((char)(msg[i] + key[index]));

                index++;
            }

            return sb.ToString();
        }
    }
}
