using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            List<RegisteredUser> users = new List<RegisteredUser>();
            int entry = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                DateTime value = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                users.Add(new RegisteredUser(name, value, entry));

                entry++;
            }

            users = users.OrderBy(x => x.date).ThenByDescending(x => x.entryNumber).Take(5).OrderByDescending(x => x.date).ToList();

            foreach (var item in users)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
