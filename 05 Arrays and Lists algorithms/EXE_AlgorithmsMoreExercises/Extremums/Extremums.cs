using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Extremums
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            string[] finalNums = new string[nums.Length];
            Array.Copy(nums, finalNums, nums.Length);
            string command = Console.ReadLine();
            int sum = 0;

            if (command == "Max")
            {              

                for (int i = 0; i < nums.Length; i++)
                {
                    
                    string number = nums[i];
                    int m = int.Parse(number);

                    for (int y = 0; y < number.Length; y++)
                    {                      
                        string temp = shiftRight(number);

                        if (int.Parse(temp) > m)
                        {
                            m = int.Parse(temp);
                            finalNums[i] = temp;
                        }

                        number = temp;
                    }
                    
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += int.Parse(finalNums[i]);
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {

                    string number = nums[i];
                    int m = int.Parse(number);

                    for (int y = 0; y < number.Length; y++)
                    {
                        string temp = shiftRight(number);

                        if (int.Parse(temp) < m)
                        {
                            m = int.Parse(temp);
                            finalNums[i] = (int.Parse(temp)).ToString();
                        }

                        number = temp;
                    }

                }

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += int.Parse(finalNums[i]);
                }
            }

            Console.WriteLine(String.Join(", ", finalNums));
            Console.WriteLine(sum);
        }

        public static string shiftRight(string arr)
        {
            char[] demo = arr.ToCharArray();

            for (int i = 1; i < arr.Length; i++)
            {
                demo[i] = arr[i - 1];
            }

            demo[0] = arr[demo.Length - 1];

            string s = "";

            foreach (char item in demo)
            {
                s += item;
            }

            return s;
        }
    }
}
