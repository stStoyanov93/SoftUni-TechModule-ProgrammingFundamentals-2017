using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Substring(1, input.Length - 2);
            string[] students = input.Split(new char[] { '}' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in students)
            {
                string[] student = item
                    .Split(new string[] { "{", "}", "]", "[", " ", ",", "name", "age", "grades", ":", "\"" }, 
                    StringSplitOptions.RemoveEmptyEntries);

                if (student.Length > 2)
                {
                    Console.WriteLine($"{student[0]} : {student[1]} -> {String.Join(", ", student, 2, student.Length - 2)}");
                }
                else
                {
                    Console.WriteLine($"{student[0]} : {student[1]} -> None");
                }
            }
        }
    }
}
