using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C# Programming", "S Burton", 420);

        video1.AddComment(new Comment("Tendayi", "Great introduction."));
        video1.AddComment(new Comment("Gabriel", "I learnt a lot."));
        video1.AddComment(new Comment("Tinashe", "Easy to understand."));

        videos.Add(video1);

        Video video2 = new Video("What is Abstraction in C#?", "S Burton", 720);

        video2.AddComment(new Comment("Zachley", "Insightful lesson."));
        video2.AddComment(new Comment("Mandizvidza", "The examples made it easy to understand."));
        video2.AddComment(new Comment("Gwen", "Thank you for this, it was quite helpful."));

        videos.Add(video2);

        Video video3 = new Video("Encapsulation, explained.", "S Burton", 856);

        video3.AddComment(new Comment("Tatenda", "Wow! I now understand."));
        video3.AddComment(new Comment("Yatniel", "The lesson was easy to follow."));
        video3.AddComment(new Comment("Gwen", "Keep it up."));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");

            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}