using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Website
    {
        public string Name { get; set; }
        public string Domain { get; set; }
        public List<string> Quary { get; set; }
    }
    class Websites
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string domain = tokens[1];
                List<string> qs = new List<string>();

                if (tokens.Length > 2)
                {
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        qs.Add(tokens[i]);
                    }

                    Console.Write($"https://www.{name}.{domain}/query?=");

                    for (int i = 0; i < qs.Count; i++)
                    {
                        if (i == qs.Count - 1)
                        {
                            Console.Write($"[{qs[i]}]");
                        }
                        else
                        {
                            Console.Write($"[{qs[i]}]&");
                        }
                    }
                }
                else
                {
                    Console.Write($"https://www.{name}.{domain}");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
