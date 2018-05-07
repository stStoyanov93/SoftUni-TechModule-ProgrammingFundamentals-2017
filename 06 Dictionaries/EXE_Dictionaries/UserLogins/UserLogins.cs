using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string command;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "login")
                {
                    break;
                }

                string[] pair = command.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                dict[pair[0]] = pair[1];
            }

            int unsuccesfulLogins = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] pair = command.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (dict.ContainsKey(pair[0]))
                {
                    if (dict[pair[0]] == pair[1])
                    {
                        Console.WriteLine($"{pair[0]}: logged in successfully");
                    }
                    else
                    {
                        unsuccesfulLogins++;
                        Console.WriteLine($"{pair[0]}: login failed");
                    }
                }
                else
                {
                    unsuccesfulLogins++;
                    Console.WriteLine($"{pair[0]}: login failed");
                }
            }

            Console.WriteLine($"unsuccessful login attempts: {unsuccesfulLogins}");
        }
    }
}
