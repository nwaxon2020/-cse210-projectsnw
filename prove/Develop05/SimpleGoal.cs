using System;

public class SimpleGoal : Goal
{
    private bool _isComple;

    public SimpleGoal(string name, string discription, int points) : base (name, discription, points)
    {
        _isComple = false;
    }
    public override void RecordEvent()
    {
        _isComple = true;
        Console.WriteLine($"Cogratulations you have earned {_points} points");
    }
    public override bool IsCompleted()
    {
        return _isComple;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_discription},{_points},{_isComple}";
    }
}
