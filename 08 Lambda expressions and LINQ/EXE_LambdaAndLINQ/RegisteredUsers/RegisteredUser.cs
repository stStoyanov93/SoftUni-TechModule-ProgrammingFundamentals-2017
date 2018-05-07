using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers
{
    class RegisteredUser
    {
        public string name;
        public DateTime date;
        public int entryNumber;

        public RegisteredUser(string name, DateTime date, int entryNumber)
        {
            this.name = name;
            this.date = date;
            this.entryNumber = entryNumber;
        }
    }
}
