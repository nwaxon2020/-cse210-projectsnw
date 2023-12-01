using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    
    }

    public void Start()
    {
        int userChoice = 0;

        while(userChoice != 6)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the Menu: ");

            string choice = Console.ReadLine();
            userChoice = int.Parse(choice);

            if(userChoice == 1)
            {
                CreateGoals();
            }
        }
        Console.WriteLine("\nProgram has ended\n");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoals()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of Goal will you like to create? ");
        
        string ans = Console.ReadLine();
        int userAns = int.Parse(ans);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short discription of it? ");
        string goalDiscription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoint = Console.ReadLine();

        if (userAns == 1)
        {          
            SimpleGoal simpleGoal = new SimpleGoal(goalName,goalDiscription,goalPoint);

            _goals.Add(simpleGoal);
        }
        else if (userAns == 2)
        {
            EternalGoals eternalGoals = new EternalGoals(goalName,goalDiscription,goalPoint);

            _goals.Add(eternalGoals);
        }
        else if (userAns == 3)
        {
            Console.Write("How many times dose this goal needs to be accomplished for a bonous? ");
            string target = Console.ReadLine();
            int goalTarget = int.Parse(target);

            Console.Write("What is the bonous for accomplishing it that many times? ");
            string bonous = Console.ReadLine();
            int goalBonous = int.Parse(bonous);

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName,goalDiscription,goalPoint,goalTarget,goalBonous);

            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("\nWrong selection Entry\n");
        }



    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}