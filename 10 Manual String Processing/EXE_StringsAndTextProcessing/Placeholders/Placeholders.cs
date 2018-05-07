using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] sentnceAndValues = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string[] values = sentnceAndValues[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string sentece = sentnceAndValues[0];                

                for (int i = 0; i < values.Length; i++)
                {
                    sentece = sentece.Replace("{" + i + "}", values[i]);
                }

                Console.WriteLine(sentece);

                input = Console.ReadLine();
            }
        }
    }
}
