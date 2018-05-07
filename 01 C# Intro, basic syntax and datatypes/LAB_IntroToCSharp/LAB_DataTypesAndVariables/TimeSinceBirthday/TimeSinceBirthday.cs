using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_DataTypesAndVariables
{
    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            byte years = byte.Parse(Console.ReadLine());

            uint days = years * (uint)365;
            uint hours = days * 24;
            uint minutes = hours * 60;

            Console.WriteLine($"{years} years - {days} days - {hours} hours - {minutes} minutes.");
        }
    }
}
