using System;
using System.Reflection;

public class Event
{
    private string _eventTitle; // Event Title Attribute
    private string _description; // Event Discription Attribute
    private string _date; // Event Date Attribute
    private string _time; // Event Time Attribute
    private Address _eventAddress; // Event Address as a class Attribute
    // Please Note that i used the same Address class created for the online ordering program to get the Address for this class 

    public Event(string title, string descriptions, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = descriptions;
        _date = date;
        _time = time;
        _eventAddress = address;
    }

    private string Address() // Display the address gotten from the Adress class
    {
       return _eventAddress.DisplayAddress();
    }

    public string StandardDetails() // General Standard Event Details.
    {
        return $"Title: {_eventTitle}\nDiscription: {_description}\nDate: {_date}\nTime: {_time}\n{Address()}\n";
    }

    public string ShortDiscripton() // General Short Discription
    {
        return $"\nEvent Type: {GetType().Name}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}