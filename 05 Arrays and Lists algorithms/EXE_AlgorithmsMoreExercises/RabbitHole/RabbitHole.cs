using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int index = 0;
            bool isBombed = false;

            while (true)
            {

                if (list[index] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string[] elements = list[index].Split('|');

                    if (elements[0] == "Right")
                    {
                        index = (index + int.Parse(elements[1])) % list.Count;
                        energy -= int.Parse(elements[1]);
                    }
                    else if (elements[0] == "Left")
                    {                       
                        index = Math.Abs(index - int.Parse(elements[1])) % list.Count;
                        energy -= int.Parse(elements[1]);
                    }
                    else if (elements[0] == "Bomb")
                    {
                        energy -= int.Parse(elements[1]);
                        list.RemoveAt(index);
                        index = 0;
                        isBombed = true;
                    }
                }

                if (energy <= 0)
                {
                    if (isBombed)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                    }
                    else
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                    }

                    break;
                }

                if (list[list.Count - 1] != "RabbitHole")
                {
                    list.RemoveAt(list.Count - 1);
                }

                list.Add($"Bomb|{energy}");
            }
                                   
        }
    }
}
