using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            Regex fishPattern = new Regex(@">*<\(+['\-x]>");

            string input = Console.ReadLine();
            var fish = fishPattern.Matches(input);
            int index = 1;

            foreach (Match m in fish)
            {
                string f = m.Value;
                int tailLenght = 0;
                int bodyLenght = 0;
                string status = string.Empty;

                foreach (var c in f)
                {
                    if (c == '>')
                    {
                        tailLenght++;
                    }                   
                    else if (c == '(')
                    {
                        bodyLenght++;
                    }
                    else if (c == '\'')
                    {
                        status = "Awake";
                    }
                    else if (c == 'x')
                    {
                        status = "Dead";
                    }
                    else if (c == '-')
                    {
                        status = "Asleep";
                    }                   
                }

                tailLenght--;

                string tailType = GetTailType(tailLenght);
                string bodyType = GetBodyType(bodyLenght);

                Console.WriteLine($"Fish {index}: {f}");

                if (tailType != "None")
                {
                    Console.WriteLine($"  Tail type: {tailType} ({tailLenght * 2} cm)");
                }
                else
                {
                    Console.WriteLine("  Tail type: None");
                }

                Console.WriteLine($"  Body type: {bodyType} ({bodyLenght * 2} cm)");
                Console.WriteLine($"  Status: {status}");
                index++;
            }

            if (index == 1)
            {
                Console.WriteLine("No fish found.");
            }
        }

        public static string GetTailType(int lenght)
        {
            if (lenght > 5)
            {
                return "Long";
            }
            else if (lenght > 1)
            {
                return "Medium";
            }
            else if (lenght == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }
        public static string GetBodyType(int lenght)
        {
            if (lenght > 10)
            {
                return "Long";
            }
            else if (lenght > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }

        }
    }
}
