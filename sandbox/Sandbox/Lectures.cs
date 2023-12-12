using System;
using System.Reflection;

public class Lectures : Event
{
    private string _speakerName;
    private int _hallCapacity;

    public Lectures(string title, string speaker, int hallCapacity, string descriptions, string date, string time, Address address) : base(title, descriptions, date, time, address)
    {
        _speakerName = speaker; // get speaker's Name
        _hallCapacity = hallCapacity; // get Capacity
    }

    public string FullDetails() // Full Address for this class
    {
        return $"Speaker: {_speakerName}\nHall Seating Capacity: {_hallCapacity}\n{base.StandardDetails()}";
    }
}

