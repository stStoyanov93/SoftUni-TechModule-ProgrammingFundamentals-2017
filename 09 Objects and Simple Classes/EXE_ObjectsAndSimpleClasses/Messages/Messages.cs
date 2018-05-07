using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class User
    {
        public string UserName { get; set; }
        public List<Message> ReceivedMessages { get; set; }

        public User()
        {
            this.ReceivedMessages = new List<Message>();
        }
    }

    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }
    }

    class Messages
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            string input = Console.ReadLine();

            while (input != "exit")
            {
                string[] inputTokens = input.Split();

                if (inputTokens[0] == "register")
                {
                    string name = inputTokens[1];

                    users.Add(name, new User()
                    {
                        UserName = name
                    });
                }
                else
                {
                    string sender = inputTokens[0];
                    string recipient = inputTokens[2];
                    string content = inputTokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        User senderName = users[sender];

                        users[recipient]
                            .ReceivedMessages
                            .Add(new Message()
                            {
                                Sender = senderName,
                                Content = content
                            });
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] usersPair = input.Split();
            string firstUser = usersPair[0];
            string secondUser = usersPair[1];

            var firstCollection = users[secondUser].ReceivedMessages.Where(x => x.Sender.UserName == firstUser).ToList();
            var secondCollection = users[firstUser].ReceivedMessages.Where(x => x.Sender.UserName == secondUser).ToList();

            if (firstCollection.Count == 0 && secondCollection.Count == 0)
            {
                Console.WriteLine("No messages");
                return;
            }

            int biggerCollection = Math.Max(firstCollection.Count, secondCollection.Count);

            for (int i = 0; i < biggerCollection; i++)
            {
                if (i < firstCollection.Count)
                {
                    Console.WriteLine($"{firstUser}: {firstCollection[i].Content}");
                }
                if (i < secondCollection.Count)
                {
                    Console.WriteLine($"{secondCollection[i].Content} :{secondUser}");
                }
            }
        }
    }
}
