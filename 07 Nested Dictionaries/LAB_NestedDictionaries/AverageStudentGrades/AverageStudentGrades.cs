using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                if (!students.ContainsKey(s[0]))
                {
                    students.Add(s[0], new List<double>());
                }

                students[s[0]].Add(double.Parse(s[1]));
            }

            foreach (KeyValuePair<string, List<double>> item in students)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(x => ($"{x:F2}")))} (avg: {item.Value.Average():F2})");
            }

        }
    }
}
