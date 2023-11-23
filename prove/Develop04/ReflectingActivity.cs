using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _discription =  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        ShowSpiner(250);

        Console.WriteLine("\nConsider the following Prompt:\n");
        
        DisplayPrompt();

        Console.Write("\nWhen you have somthing in mind, press enter to continue. ");
        Console.ReadLine();

        Console.Write("\nNow pounder each of the following quetions as they relate to this experience You may be in: ");

        ShowCountDown(5);

        Console.Clear();

        DateTime timer = DateTime.Now;
        DateTime UsertTimer = timer.AddSeconds(_duration);

        while( DateTime.Now < UsertTimer)
        {   
            Console.Write("\n");
            DisplayQustion();
            Console.Write("\n");
        }

    }
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int randomQuestion = random.Next(_prompts.Count);

        return _prompts[randomQuestion];      
        
    }
    public string GetRandomQuetion()
    {
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add(" How can you keep this experience in mind in the future? ");

        Random random = new Random();
        int randomQuestion = random.Next(_questions.Count);

        return _questions[randomQuestion];      
        
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQustion()
    {       
        Console.Write($">> {GetRandomQuetion()}");
        ShowSpiner(400);     
    }


}