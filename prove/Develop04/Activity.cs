using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class Activity
{
    protected string _name;
    protected string _discription;
    protected int _duration;

    public Activity()
    {
        _name = "breathing";
        _discription = "brething is live always";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name} Activity");
        Console.WriteLine($"\n{_discription}");

        Console.Write("\nHow long, in seconds, would you like for your seccission? ");

        string reply = Console.ReadLine();

        _duration = int.Parse(reply);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!!");
        ShowSpiner(250);
        Console.WriteLine($"You have completed another {_duration} of the {_name} Activity");
        ShowSpiner(250);
    }
    public void ShowSpiner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach(string spin in animation)
        {
            Console.Write(spin);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }

        
        //_duration = seconds;
    }
    public void ShowCountDown(int seconds)
    {    
        for(int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        };
        
    }
}