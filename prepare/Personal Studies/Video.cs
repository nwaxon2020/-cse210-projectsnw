using System;

public abstract class Video
{
    private string _title;
    private string _author;
    private double _time;

    public Video(string title, string author, double time)
    {
        _title = title;
        _author = author;
        _time = time;
    }

    public abstract void ViewVideos();
    public abstract void CreatVideo();
    public abstract void Comments();

    public string GetVideoDetails()
    {
        return $"Title: {_title}\n    Author: {_author}\n    Time: {_time} mins";
    }
}