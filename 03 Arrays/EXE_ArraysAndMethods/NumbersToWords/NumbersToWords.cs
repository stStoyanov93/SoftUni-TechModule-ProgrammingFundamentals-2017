using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int absN = Math.Abs(num);

                if (absN.ToString().Length < 3)
                {
                    continue;
                }
                else
                {
                    string result = string.Empty;
                    result += ReturnNum(num);

                    if (num < 0 && (result != "too large" && result != "too small"))
                    {
                        result = "minus " + result;
                    }

                    Console.WriteLine(result);
                }
            }
        }

        public static string ReturnNum(int n)
        {           
           if (n > 999)
            {
                return "too large";
            }
            else if (n < -999)
            {
                return "too small";
            }
            else
            {
                n = Math.Abs(n);
                char[] arr = n.ToString().ToCharArray();

                if (arr[1] == '0' && arr[2] == '0')
                {
                    return ReturnHundrends(n) + "-hundred";
                }
                else if (arr[1] == '0')
                {
                    return ReturnHundrends(n) + "-hundred and " + ReturnNLessThanTen(n);
                }
                else if(arr[1] == '1' && arr[2] != '0')
                {
                    return ReturnHundrends(n) + "-hundred and " + ReturnTweens(n);
                }
                else
                {
                    return ReturnHundrends(n) + "-hundred and " + ReturnTens(n) + " " + ReturnNLessThanTen(n);
                }
            }
            
        }

        public static string ReturnHundrends(int n)
        {
            string s = n.ToString();
            char ss = s[0];

            switch (ss)
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
                default:
                    return "";
            }
        }
        public static string ReturnNLessThanTen(int n)
        {
            string s = n.ToString();
            char ss = s[2];

            switch (ss)
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
                default:
                    return "";
            }
        }
        public static string ReturnTweens(int n)
        {
            string s = n.ToString();
            string ss = s.Substring(1);

            switch (ss)
            {
                case "11":
                    return "eleven";
                case "12":
                    return "twelve";
                case "13":
                    return "thirteen";
                case "14":
                    return "fourteen";
                case "15":
                    return "fifteen";
                case "16":
                    return "sixteen";
                case "17":
                    return "seventeen";
                case "18":
                    return "eighteen";
                case "19":
                    return "nineteen";
                default:
                    return "";
            }
        }
        public static string ReturnTens(int n)
        {
            string s = n.ToString();
            char ss = s[1];

            switch (ss)
            {          
                case '2':
                    return "twenty";
                case '3':
                    return "thirty";
                case '4':
                    return "fourty";
                case '5':
                    return "fifty";
                case '6':
                    return "sixty";
                case '7':
                    return "seventy";
                case '8':
                    return "eighty";
                case '9':
                    return "ninety";
                default:
                    return "";
            }
        }

    }
}
