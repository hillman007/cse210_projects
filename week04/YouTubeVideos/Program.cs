using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "Tech Guru", 600);
        video1.AddComment("Alice", "Great tutorial, very helpful!");
        video1.AddComment("Bob", "Can you explain more about classes?");
        video1.AddComment("Charlie", "Loved the examples!");

        Video video2 = new Video("How to Cook Pasta", "Chef Mario", 450);
        video2.AddComment("Dave", "Yummy! Trying this today.");
        video2.AddComment("Eva", "Can I use gluten-free pasta?");
        video2.AddComment("Frank", "Thanks for the recipe!");

        Video video3 = new Video("Space Exploration", "NASA Channel", 1200);
        video3.AddComment("Grace", "Mind-blowing discoveries!");
        video3.AddComment("Hank", "I want to be an astronaut!");
        video3.AddComment("Ivy", "Such an informative video!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}