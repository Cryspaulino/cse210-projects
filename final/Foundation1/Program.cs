using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Youtube Videos");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to make brownies", "Luz Paulino", 3);

        v1.comments.AddRange(new List<Comment>
        {
            new Comment {_commentUser = "Sarah Matias", _commentText = "I have been waiting for this recipe for so long."},
            new Comment {_commentUser = "Lucas Perez", _commentText = "This is the best!"},
            new Comment {_commentUser = "Crys Paulino", _commentText = "I am so excited to make this recipe for me and my family."}
        });
        // The AddRange we didn't learn it in class, but I was trying to find a better way to add many comments at the same time and Add couldn't take the 3-4 arguments at the name time, so instead I learned that AddRange can take different arguments and instead of declaring the member variables in the comment class as we have done before I would just do it directly inside the comments for the video.

        Video v2 = new Video( "Understanding Javascript", "Brother Thompson", 8);

        v2.comments.AddRange(new List<Comment>
        {
            new Comment {_commentUser = "Thomassito", _commentText = "This was so hard to understand in class, I am glad you posted this video."},
            new Comment {_commentUser = "_yourname", _commentText = "Promise I can never get how Javascript works."},
            new Comment {_commentUser = "Peter Peterson", _commentText = "Brother Thompson was my professor five years ago and now I am reviewing these topics, this video is awesome, keep it up!"}
        });

        Video v3 = new Video( "Algorithms", "Brother Kay", 6);

        v3.comments.AddRange(new List<Comment>
        {
            new Comment {_commentUser = "Marta Janes", _commentText = "I feel I can do things so much organized after watching this videos."},
            new Comment {_commentUser = "Tobias Wilder", _commentText = "Now my wife wants to set up algorithms for laundry and the dishwaher. I hope it works"},
            new Comment {_commentUser = "themil_emil", _commentText = "Here in 2025!"}
        });

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        foreach (Video v in videos)
        {
            v.Display();
            Console.WriteLine();
        }
        
    } 

}