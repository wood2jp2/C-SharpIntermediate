using System;
namespace S2E2DesignaStackOverflowPost
{
    public class Post
    {
        int Votes { get; set; } = 0;
        string Title { get; set; }
        string Description { get; set; }
        DateTime CreatedAt { get; } = DateTime.Now;

        public Post()
        {
        }

        public Post(string title) : this() {
            Title = title;
        }

        public Post(string title, string description) : this(title) {
            Description = description;
        }

        public void CastVote(string vote)
        {
            if (vote == "upvote"){
                Votes += 1;
            }
            else if (vote == "downvote") {
                Votes -= 1;
            }
            Console.WriteLine(Votes);
        } 
    }
}
