using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            Regex patternPM = new Regex(@"^\d+ <-> [A-Za-z0-9]+$");
            Regex patternBroadcast = new Regex(@"^\D+ <-> [A-Za-z0-9]+$");
            var PMs = new List<string>();
            var broadcasts = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                if (patternPM.IsMatch(input))
                {
                    string[] arr = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);
                    string message = arr[1];

                    string recepient = String.Join("", arr[0].ToCharArray().Reverse());

                    PMs.Add(String.Concat(recepient, " -> ", message));
                }

                if (patternBroadcast.IsMatch(input))
                {
                    string[] arr = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    string message = arr[0];

                    string broadcast = String.Empty;

                    for (int i = 0; i < arr[1].Length; i++)
                    {
                        if (char.IsLower(arr[1][i]))
                        {
                            broadcast += arr[1][i].ToString().ToUpper();
                            
                        }
                        else if (char.IsUpper(arr[1][i]))
                        {
                            broadcast += arr[1][i].ToString().ToLower();
                        }
                        else
                        {
                            broadcast += arr[1][i];
                        }
                    }
                    broadcasts.Add(broadcast + " -> " + message);
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Messages:");

            if (PMs.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in PMs)
                {
                    Console.WriteLine(item);
                }
            }

        }

    }
}
