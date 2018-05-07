using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class SocialMediaPosts
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "drop the media")
                {
                    break;
                }

                string[] arr = command.Split(' ');
                string chosenAction = arr[0];

                if (chosenAction == "post")
                {
                    posts.Add(new Post(arr[1]));
                }
                else if (chosenAction == "like")
                {
                    posts.Find(x => x.name == arr[1]).likes++;
                }
                else if (chosenAction == "dislike")
                {
                    posts.Find(x => x.name == arr[1]).dislikes++;
                }
                else if (chosenAction == "comment")
                {
                    int length = chosenAction.Length + arr[1].Length + arr[2].Length + 3;
                    posts.Find(x => x.name == arr[1]).AddComment(arr[2], command.Substring(length));
                }
            }

            foreach (Post item in posts)
            {
                Console.WriteLine($"Post: {item.name} | Likes: {item.likes} | Dislikes: {item.dislikes}");
                Console.WriteLine("Comments:");

                if (item.comments.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var c in item.comments)
                    {
                        Console.WriteLine($"*  {c.Key}: {c.Value}");
                    }
                }
            }
        }
    }
}
