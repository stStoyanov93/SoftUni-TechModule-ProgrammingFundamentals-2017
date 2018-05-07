using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> banks = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bankName = inputTokens[0];
                string accountName = inputTokens[1];
                decimal sum = decimal.Parse(inputTokens[2]);

                if (!banks.ContainsKey(bankName))
                {
                    banks[bankName] = new Dictionary<string, decimal>(); 
                }

                if (!banks[bankName].ContainsKey(accountName))
                {
                    banks[bankName][accountName] = 0M;
                }

                banks[bankName][accountName] += sum;
            }

            var orderedBanks = banks.OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value));

            foreach (var bank in orderedBanks)
            {
                var orderedAccounts = bank.Value.OrderByDescending(x => x.Value);

                foreach (var item in orderedAccounts)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value} ({bank.Key})");
                }
            }
        }
    }
}
