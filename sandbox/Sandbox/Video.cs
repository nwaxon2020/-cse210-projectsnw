using System;
using System.Collections.Generic;

public class Video
{
    private string _title; // Title Attribute
    private string _author; // Author Attribute
    private double _duration; // Video Duration Attribute

    private int numbOfComment; // Amount of cumment Attribute
    private List<Comment> _comment = new List<Comment>(); // List of Comments Attribute

    public Video(string title, string author, double time) // Video Contructor
    {
        _title = title;
        _author = author;
        _duration = time;

        numbOfComment = 0; // initialize the number of comment
    }

    public void UpdateComment(Comment comment) // Add comment to the comment list method
    {
       _comment.Add(comment); // Add comment to the comment list 
    }

    public void DisplayVideoDetails() // Method to display all neccessary Videos and their comments
    {
        Console.WriteLine("Welcome to the 'ABSTRACT' Program");
        Console.WriteLine($"  Title: {_title}\n  Author: {_author},\n  Video-Duration: {_duration} mins");

        Console.WriteLine("_____Video Comments_____");
        foreach(Comment comt in _comment)// Increment the comment list
        {
           Console.WriteLine($"{comt.DisplayComment()}"); // Display the user written comment
            numbOfComment ++;
        }
        Console.WriteLine($"\nTotal Video Comments: {numbOfComment}\n");
    }
}   