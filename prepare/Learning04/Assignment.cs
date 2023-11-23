using System;
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "unknown";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    

    public string GetSummary()
    {
        return $"Student Name: {_studentName}\n Topic: {_topic}";
    }
}