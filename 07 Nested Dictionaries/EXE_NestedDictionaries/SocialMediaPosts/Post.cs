using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Post
    {
        public string name;
        public int likes { get; set; }
        public int dislikes { get; set; }
        public Dictionary<string, string> comments;

        public Post(string name)
        {
            this.name = name;
            comments = new Dictionary<string, string>();
        }

        public void AddComment(string name, string content)
        {
            comments.Add(name, content);
        }

    }
}
