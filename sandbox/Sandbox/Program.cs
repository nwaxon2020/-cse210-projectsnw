using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Video video1 = new Video("Legend Of The Seeker","Mike Williams",44.8);
        Comment vid1Comment1 = new Comment("Mike Johnson","Wow! what a great movie");
        Comment vid1Comment2 = new Comment("Prince Nwachukwu","I am not a fan of this type of Film but it's great");
        Comment vid1Comment3 = new Comment("Sussan Cowel","I don't like this movie");
        video1.UpdateComment(vid1Comment1);
        video1.UpdateComment(vid1Comment2);
        video1.UpdateComment(vid1Comment3);
        video1.DisplayVideoDetails();

        Video video2 = new Video("Spider-Man","Disney",60.3);
        Comment vid2Comment1 = new Comment("Ikechukwu","No comments");
        Comment vid2Comment2 = new Comment("Alma","Is it on sale already?");
        Comment vid2Comment3 = new Comment("Marry Allison","The production of this movie is poor");
        video2.UpdateComment(vid2Comment1);
        video2.UpdateComment(vid2Comment2);
        video2.UpdateComment(vid2Comment3);
        video2.DisplayVideoDetails();

        Video video3 = new Video("Captain America","Marvels",56);
        Comment vid3Comment1 = new Comment("Matthew","Nice job by this team");
        Comment vid3Comment2 = new Comment("Eddie","I Love the ending");
        Comment vid3Comment3 = new Comment("Johnathan","Fantactis.\n Please when is the prt 2 comming out");
        Comment vid3Comment4 = new Comment("Rosline Efe","I wish i had super powers");
        video3.UpdateComment(vid3Comment1);
        video3.UpdateComment(vid3Comment2);
        video3.UpdateComment(vid3Comment3);
        video3.UpdateComment(vid3Comment4);
        video3.DisplayVideoDetails();
      
    }
}