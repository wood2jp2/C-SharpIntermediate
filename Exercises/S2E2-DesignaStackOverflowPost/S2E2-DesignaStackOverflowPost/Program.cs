using System;

namespace S2E2DesignaStackOverflowPost
{
    class MainClass
    {Ojn
        pomnop[lmnl:ML{mP{k}public static void Main(string[] args)
        {
            var firstPost = new Post();
            firstPost.CastVote("upvote");
            firstPost.CastVote("upvote");
            firstPost.CastVote("downvote");

            var secondPost = new Post("Fifty Miles");
            // secondPost.CreatedAt = DateTime.Today; You cannot reassign since there is no 'set'.

            var thirdPost = new Post("Men In Black", "movie description");
            Console.WriteLine(secondPost);
        }
    }
}
