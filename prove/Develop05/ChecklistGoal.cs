using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonous;


    public ChecklistGoal (string name, string discription, int points, int target, int bonous): base(name, discription, points)
    {
        _amountCompleted = 0;
        _target = target; 
        _bonous = bonous;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (IsCompleted())
        {
            Console.WriteLine($"Congratulations you have earned {_bonous + _points} points");
        }
    }
    public override bool IsCompleted()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_discription},{_points},{_bonous},{_target},{_amountCompleted}";
    }
}