using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        VideoComment video = new VideoComment("Legend of the seeker","Mark Williams",4.5,"drink", "food");

        video.RunProgram();
        
    }
}