using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Video objects
        Video video1 = new Video("Rafting Adventure", "Samantha", 12);
        Video video2 = new Video("Dog Training Tips", "Carlos", 8);
        Video video3 = new Video("Concert Highlights", "Maria", 15);

        // Add comments to video1
        video1.AddComment(new Comment("Ana", "Looks amazing!"));
        video1.AddComment(new Comment("Luis", "I want to try rafting now."));
        video1.AddComment(new Comment("Pedro", "Great video!"));

        // Add comments to video2
        video2.AddComment(new Comment("Sofia", "Very helpful tips."));
        video2.AddComment(new Comment("Diego", "My dog loved this."));
        video2.AddComment(new Comment("Elena", "Thanks for sharing!"));

        // Add comments to video3
        video3.AddComment(new Comment("Juan", "Best concert ever."));
        video3.AddComment(new Comment("Carla", "Wish I was there."));
        video3.AddComment(new Comment("Miguel", "Amazing energy!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display info for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}