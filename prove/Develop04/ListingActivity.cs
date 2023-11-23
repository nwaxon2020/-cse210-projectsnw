using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _discription =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        ShowSpiner(250);

        Console.WriteLine("\nList as many response you can to the following pormpt");

        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime timer = DateTime.Now;
        DateTime UsertTimer = timer.AddSeconds(_duration);

        Console.Write("\n\n"); 

        while( DateTime.Now < UsertTimer)
        { 
            Console.Write(">> ");  
            Console.ReadLine(); 
            _count ++;
        }
        Console.WriteLine($"You listed {_count} items");

    }
    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add(" Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");

        Random random = new Random();
        int randomQuestion = random.Next(_prompts.Count);

        Console.WriteLine($"--{_prompts[randomQuestion]}--");   
    }
    public string GetListFromUser()
    {           
        return "";
    }
}