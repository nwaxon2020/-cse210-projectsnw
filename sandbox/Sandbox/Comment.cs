using System;

public class Comment
{
    private string _commenterName; // CommnerName Attribute
    private string _text; // Comment Attribute

    // Contructor to pass in the Commenter Name and the Comment
    public Comment(string comment, string text)
    {
        _commenterName = comment;
        _text = text;
    }

    public string DisplayComment() // Return the Name of the commenter and the comment
    {
        return $"Name: {_commenterName}\nComment: --{_text}--";
    }
}