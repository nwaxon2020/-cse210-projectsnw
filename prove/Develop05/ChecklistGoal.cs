using System;
using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonous;


    public ChecklistGoal (string name, string discription, string points, int target, int bonous): base(name, discription, points)
    {
        _target = target; 
        _bonous = bonous;
    }

    public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"-- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}