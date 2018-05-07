using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    class JSONStringify
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            string input = Console.ReadLine();

            while (input != "stringify")
            {
                string[] arr = input.Split(new char[] {' ', '-', ',', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string name = arr[0];
                string age = arr[1];
                string final;

                if (arr.Length == 2)
                {   
                    final = $"{{name:\"{name}\",age:{age},grades:[]}}";
                }
                else
                {
                    string grades = input.Substring(input.IndexOf('>') + 2);
                    final = $"{{name:\"{name}\",age:{age},grades:[{grades}]}}";
                }

                students.Add(final);
                input = Console.ReadLine();
            }

            Console.WriteLine("[" + (String.Join(",", students)) + "]");
        }
    }
}
