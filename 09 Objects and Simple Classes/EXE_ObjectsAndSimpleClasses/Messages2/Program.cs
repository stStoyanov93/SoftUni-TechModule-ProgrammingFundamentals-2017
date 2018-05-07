using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }

        public User(string username, List<Message> rcvdmsgs)
        {
            Username = username;
            ReceivedMessages = rcvdmsgs;
        }
    }
    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message(string content, User sender)
        {
            Content = content;
            Sender = sender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<User> listOfUsers = new List<User>();
            var listOfMessages = new List<Message>();

            while (input != "exit")
            {
                var inputParams = input.Split(' ');

                if (inputParams[0] == "register")
                {
                    var registerUser = new User(inputParams[1], new List<Message>());
                    listOfUsers.Add(registerUser);
                }
                else
                {
                    if (listOfUsers.Exists(u => u.Username == inputParams[0]) && listOfUsers.Exists(u => u.Username == inputParams[2]))
                    {
                        User currentSender = listOfUsers.Where(u => u.Username == inputParams[0]).Single();
                        var currentMessage = new Message(inputParams[3], currentSender);
                        listOfMessages.Add(currentMessage);
                        User currentReciever = listOfUsers.Where(u => u.Username == inputParams[2]).Single();
                        currentReciever.ReceivedMessages.Add(currentMessage);
                    }
                }

                input = Console.ReadLine();
            }

            var usernames = Console.ReadLine().Split(' ');

            var sentBy1 = listOfMessages.Where(s => s.Sender.Username == usernames[0]).ToList();
            var sentBy2 = listOfMessages.Where(s => s.Sender.Username == usernames[1]).ToList();

            var k = Math.Max(sentBy1.Count, sentBy2.Count);

            if (k <= 0)
            {
                Console.WriteLine("No messages");
                return;
            }

            for (int i = 0; i < k; i++)
            {
                if (i < sentBy1.Count)
                {
                    Console.WriteLine($"{usernames[0]}: {sentBy1[i].Content}");
                }
                if (i < sentBy2.Count)
                {
                    Console.WriteLine($"{sentBy2[i].Content} :{usernames[1]}");
                }
            }
        }
    }
}
