using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private double _duration;

    private int numbOfComment;

    List<Comment>_comment = new List<Comment>();

    public Video(string title, string author, double time)
    {
        _title = title;
        _author = author;
        _duration = time;

        numbOfComment = 0;
    }

    public void UpdateComment(Comment comment)
    {
       _comment.Add(comment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("Welcome to the 'ABSTRACT' Program");
        Console.WriteLine($"  Title: {_title}\n  Author: {_author},\n  Video-Duration: {_duration} mins");

        Console.WriteLine("_____Video Comments_____");
        foreach(Comment comt in _comment)
        {
           Console.WriteLine($"{comt.DisplayComment()}");
            numbOfComment ++;
        }
        Console.WriteLine($"\nTotal Video Comments: {numbOfComment}\n");
    }
}   