using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[1];
                string bank = tokens[0];
                decimal balance = decimal.Parse(tokens[2]);

                accounts.Add(new BankAccount()
                {
                    Name = name,
                    Bank = bank,
                    Balance = balance
                });

                input = Console.ReadLine();
            }

            accounts = accounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList();

            foreach (var item in accounts)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }
}
