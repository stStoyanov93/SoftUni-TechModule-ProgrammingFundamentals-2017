using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class Lambada
    {
        public string SelectorObject { get; set; }
        public string DancedSelector { get; set; }
        public bool Danced { get; set; }
        public string Property { get; set; }
    }

    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            Dictionary<string, Lambada> lambadas = new Dictionary<string, Lambada>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "lambada")
                {
                    foreach (var item in lambadas)
                    {
                        if (item.Value.Danced)
                        {
                            Console.WriteLine($"{item.Key} => {item.Value.DancedSelector}.{item.Value.Property}");
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} => {item.Value.SelectorObject}.{item.Value.Property}");
                        }                      
                    }

                    break;
                }
                else if (input == "dance")
                {
                    List<string> lambs = lambadas.Keys.ToList();

                    foreach (var item in lambs)
                    {
                        lambadas[item].DancedSelector = $"{lambadas[item].SelectorObject}." + lambadas[item].DancedSelector;
                        lambadas[item].Danced = true;
                    }
                }
                else
                {
                    string[] inputTokens = input.Split(new string[] { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);
                    string key = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string property = inputTokens[2];

                    lambadas[key] = new Lambada() { SelectorObject = selectorObject, Property = property, DancedSelector = selectorObject };
                }

            }
        }
    }
}
