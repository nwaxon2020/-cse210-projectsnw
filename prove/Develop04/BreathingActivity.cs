using System;
using System.Xml;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _discription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        
        string breathIn = $"Breathe in....";
        string breathOut = "Now breathe out....";

        DateTime timer = DateTime.Now;
        DateTime UsertTimer = timer.AddSeconds(_duration);

        Console.Clear();
        Console.WriteLine("\nGet ready...");
        ShowSpiner(250);

        while( DateTime.Now < UsertTimer)
        {   
            Console.Write("\n");
            Console.Write($"{breathIn}");
            ShowCountDown(5);
       
            Console.Write($"\n{breathOut}");
            ShowCountDown(6); 
            Console.Write("\n");         

        }
        
    }
} 