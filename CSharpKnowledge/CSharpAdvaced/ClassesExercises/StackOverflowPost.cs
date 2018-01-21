using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class StackOverflowPost
    {
        public int ID { get; } = new Random().Next();
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }

        public void VoteUp()
        {
            checked
            {
                Votes++;
            }
        }

        public void VoteDown()
        {
            checked
            {
                Votes--;
            }
        }

        public static void testStackPost()
        {
            var post = new StackOverflowPost()
            {
                Title = "Why move from VBA to C#?",
                Description = "Here follows 20 pages of various reasons..."
            };

            post.VoteDown();
            post.VoteUp(); post.VoteUp(); post.VoteUp(); post.VoteUp();
            Console.WriteLine(post.Votes);
        }
    }
}
