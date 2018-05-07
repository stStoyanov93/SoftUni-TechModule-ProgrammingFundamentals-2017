using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        public static List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.Split();
                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeList(index);
                        //Console.WriteLine(String.Join(" ", list));
                    }
                }
                else if (command == "max")
                {
                    string req = tokens[1];

                    FindMax(req);
                }
                else if (command == "min")
                {
                    string req = tokens[1];

                    FindMin(req);
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    string req = tokens[2];

                    if (count > list.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FindFirstX(req, count);
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string req = tokens[2];

                    if (count > list.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FindLastX(req, count);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        private static void FindFirstX(string req, int count)
        {
            if (req == "even" && list.Any(x => x % 2 == 0))
            {
                var n = list.Where(x => x % 2 == 0).Take(count);
                Console.WriteLine($"[{string.Join(", ", n)}]");
            }
            else if (req == "odd" && list.Any(x => x % 2 == 1))
            {
                var n = list.Where(x => x % 2 == 1).Take(count);
                Console.WriteLine($"[{string.Join(", ", n)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        private static void FindLastX(string req, int count)
        {
            if (req == "even" && list.Any(x => x % 2 == 0))
            {
                var n = list.Where(x => x % 2 == 0).Reverse().Take(count).Reverse();
                Console.WriteLine($"[{string.Join(", ", n)}]");
            }
            else if (req == "odd" && list.Any(x => x % 2 == 1))
            {
                var n = list.Where(x => x % 2 == 1).Reverse().Take(count).Reverse();
                Console.WriteLine($"[{string.Join(", ", n)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FindMin(string req)
        {
            if (req == "even" && list.Any(x => x % 2 == 0))
            {
                var n = list.Where(x => x % 2 == 0).Min();
                Console.WriteLine(list.LastIndexOf(n));
            }
            else if (req == "odd" && list.Any(x => x % 2 == 1))
            {
                var n = list.Where(x => x % 2 == 1).Min();
                Console.WriteLine(list.LastIndexOf(n));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMax(string req)
        {
            if (req == "even" && list.Any(x => x % 2 == 0))
            {
                var n = list.Where(x => x % 2 == 0).Max();
                Console.WriteLine(list.LastIndexOf(n));
            }
            else if (req == "odd" && list.Any(x => x % 2 == 1))
            {
                var n = list.Where(x => x % 2 == 1).Max();
                Console.WriteLine(list.LastIndexOf(n));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void ExchangeList(int index)
        {
            var firstElements = list.Take(index + 1);
            var secondElements = list.Skip(index + 1);
            list = secondElements.Concat(firstElements).ToList();
        }
    }
}
