using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            Regex patter = new Regex(@"^(<\[[^A-Za-z0-9]*\]\.){1}(\.\[[A-Za-z0-9]*\]\.)*$");
            List<string> list = new List<string>();
            string input;

            while ((input = Console.ReadLine()) != "Traincode!")
            {
                if (patter.IsMatch(input))
                {
                    Match m = patter.Match(input);
                    list.Add(m.ToString());
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
