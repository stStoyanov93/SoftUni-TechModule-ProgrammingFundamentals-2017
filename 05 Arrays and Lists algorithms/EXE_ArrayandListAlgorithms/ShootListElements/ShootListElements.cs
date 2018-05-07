using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class ShootListElements
    {
        static List<int> values = new List<int>();

        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            int lastRemovedElement = -1;

            while (command != "stop")
            {              
                if (command == "bang")
                {
                    if (values.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedElement}");
                        break;
                    }
                    else
                    {
                        double average = values.Average();
                        
                        for (int i = 0; i < values.Count; i++)
                        {
                            if (values[i] <= average)
                            {
                                lastRemovedElement = values[i];
                                values.RemoveAt(i);
                                Console.WriteLine($"shot {lastRemovedElement}");
                                break;
                            }
                        }

                        DecrementAll();
                    }
                }
                else
                {
                    values.Insert(0, Convert.ToInt32(command));               
                }

                command = Console.ReadLine();
            }

            if (command == "stop" && values.Count > 0)
            {
                Console.WriteLine($"survivors: " + String.Join(" ", values));
            }
            else if (command == "stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedElement}");
            }
        }

        public static void DecrementAll()
        {
            for (int i = 0; i < values.Count; i++)
            {
                values[i]--;
            }
        }
    }
}
