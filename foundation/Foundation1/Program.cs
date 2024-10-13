using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("I can't believe THIS happened!", "Tony Baker", 400);
        video1.AddComment("Alice", "This is amazing!");
        video1.AddComment("Bob", "Wow, I can't believe it!");
        video1.AddComment("Sam", "What happened?");

        Video video2 = new Video("I spent $5 on THIS Tesla!", "Mike Brown", 350);
        video2.AddComment("Charlie", "Incredible deal!");
        video2.AddComment("Greg", "I love telsa");
        video2.AddComment("Horace", "First");

        Video video3 = new Video("I ate 12 Pizzas!", "Joey Smith", 1800);
        video3.AddComment("David", "That's insane!");
        video3.AddComment("Pam", "This is making me hungry!");
        video3.AddComment("Bruce", "I love Pizza Hut");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"{video.GetDisplayText()}\n");
        }
    }

}