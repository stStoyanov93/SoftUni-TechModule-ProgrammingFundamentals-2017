using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class Customer
    {
        public string Name { get; set; }
        public double Sum { get; set; }
        public List<string> Products;
        
    }
    class MostValuedCustomer
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Shop is open")
                {
                    break;
                }

                string[] items = input.Split(' ');

                products[items[0]] = double.Parse(items[1]);
            }

            List<Customer> customers = new List<Customer>();
             
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    var favoriteCustomer = customers.OrderByDescending(x => x.Sum).Take(1);

                    foreach (var customer in favoriteCustomer)
                    {
                        Console.WriteLine($"Biggest spender: {customer.Name}");
                        Console.WriteLine("^Products bought:");

                        List<KeyValuePair<string, double>> p = new List<KeyValuePair<string, double>>();

                        foreach (var item in customer.Products)
                        {
                            p.Add(new KeyValuePair<string, double>(item, products[item]));                                                     
                        }

                        customer.Sum = p.Sum(x => x.Value);

                        foreach (var item in p.Distinct().OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"^^^{item.Key}: {item.Value:F2}");
                        }

                        Console.WriteLine($"Total: {customer.Sum:F2}");
                    }

                    break;
                }

                if (input == "Discount")
                {
                    var p = products.OrderByDescending(x => x.Value).Take(3);

                    foreach (var item in p)
                    {
                        double discount = products[item.Key] * 0.1;
                        products[item.Key] -= discount;
                    }                   
                }

                string[] orders = input.Split(new string[] { " ", ":", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = orders[0];
                double sum = 0;
                List<string> items = new List<string>();

                for (int i = 1; i < orders.Length; i++)
                {
                    if (products.ContainsKey(orders[i]))
                    {
                        sum += products[orders[i]];
                        items.Add(orders[i]);
                    }            
                }

                customers.Add(new Customer()
                {
                    Name = name,
                    Sum = sum,
                    Products = items
                }
                );
            }
        }
    }
}
