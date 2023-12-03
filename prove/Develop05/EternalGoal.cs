using System;
using System.Drawing;

public class EternalGoals : Goal
{
    public EternalGoals (string name, string discription, int points): base(name, discription, points)
    {

    }

    public override void RecordEvent()
    {
        _points ++;
        Console.WriteLine($"Congratulations you have earned {_points} points");       
    }
    public override bool IsCompleted()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_discription},{_points}";
    }
}