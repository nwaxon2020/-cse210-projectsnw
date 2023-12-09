using System;

public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string comment, string text)
    {
        _commenterName = comment;
        _text = text;
    }

    public string DisplayComment()
    {
        return $"Name: {_commenterName}\nComment: --{_text}--";
    }
}