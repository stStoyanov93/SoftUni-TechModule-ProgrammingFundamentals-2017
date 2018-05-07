using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsStaying = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nightsStaying;
                doublePrice = 65 * nightsStaying;
                suitePrice = 75 * nightsStaying;              
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsStaying;
                doublePrice = 72 * nightsStaying;
                suitePrice = 82 * nightsStaying;
            }
            else if(month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightsStaying;
                doublePrice = 77 * nightsStaying;
                suitePrice = 89 * nightsStaying;
            }

            if (nightsStaying > 7 && (month == "September" || month == "October"))
            {
                if (month == "September")
                {
                    studioPrice -= 60;                 
                }
                else if(month == "October")
                {
                    studioPrice -= 50;
                }
            }

            if ((month == "May" || month == "October") && (nightsStaying > 7))
            {
                studioPrice -= studioPrice * 0.05;           
            }
            else if ((month == "June" || month == "September") && nightsStaying > 14)
            {
                doublePrice -= doublePrice * 0.1;
            }
            else if((month == "July" || month == "August" || month == "December") && nightsStaying > 14)
            {
                suitePrice -= suitePrice * 0.15;
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
