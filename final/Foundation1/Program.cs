using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Practice This Everyday for Fast Saxophone Technique", "Better Sax", 729);
        video1.AddComment(new Comment("Eliah Holiday", "Amazing video!"));
        video1.AddComment(new Comment("Sax Lover", "This really helped me improve my skills."));
        video1.AddComment(new Comment("Music Fanatic", "Great tips and techniques."));
        videos.Add(video1);

        Video video2 = new Video("Learn Saxophone in 30 Days", "Sax Mastery", 1452);
        video2.AddComment(new Comment("John Doe", "This course is fantastic!"));
        video2.AddComment(new Comment("Jane Smith", "I can already play so much better."));
        video2.AddComment(new Comment("Sax Enthusiast", "Highly recommend to anyone wanting to learn."));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Saxophone Solos of All Time", "Sax Legends", 600);
        video3.AddComment(new Comment("Music Lover", "These solos are legendary!"));
        video3.AddComment(new Comment("Sax Player", "Incredible performances."));
        video3.AddComment(new Comment("Jazz Fan", "I love jazz and these solos are the best."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.GetCommenterName() + ": " + comment.GetText());
            }
            Console.WriteLine();
        }
    }
}