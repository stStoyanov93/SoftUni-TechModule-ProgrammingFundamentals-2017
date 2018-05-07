using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "done")
            {
                string firstItem = command[0];
                string secondItem = command[1];

                string name;
                string n;

                if (IsANumber(secondItem))
                {
                    n = secondItem;
                    name = GetNameOrNumber(numbers, names,secondItem);
                    secondItem = name;
                }
                else
                {
                    n = GetNameOrNumber(numbers, names, secondItem);
                    name = secondItem;
                    secondItem = n;
                }

                int sum = GetSumOfDigits(n);

                if (firstItem == "call")
                {
                    Console.WriteLine("calling {0}...", secondItem);
                    if (sum % 2 == 0)
                    {
                        int minutes = sum / 60;
                        int seconds = sum % 60;
                        Console.WriteLine("call ended. duration: {0}:{1}",
                            minutes.ToString().PadLeft(2, '0'),
                            seconds.ToString().PadLeft(2, '0'));
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                }
                else if (firstItem == "message")
                {
                    Console.WriteLine("sending sms to {0}...", secondItem);
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        static bool IsANumber(string input)
        {
            for (int i = 0; i < input.Length; ++i)
            {
                if (IsADigit(input[i]))
                {
                    return true;
                }
            }

            return false;
        }
        static bool IsADigit(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

        static string GetNameOrNumber(string[] numbers, string[] names, string entry)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == entry)
                {
                    return names[i];
                }
                else if (names[i] == entry)
                {
                    return numbers[i];
                }
            }

            return "Not found";
        }
        static int GetSumOfDigits(string number)
        {
            int sum = 0;
            for (int cnt = 0; cnt < number.Length; cnt++)
            {
                if (IsADigit(number[cnt]))
                {
                    sum += number[cnt] - '0';
                }
            }

            return sum;
        }

    }
}
