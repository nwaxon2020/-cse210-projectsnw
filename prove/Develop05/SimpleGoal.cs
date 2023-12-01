using System;

public class SimpleGoal : Goal
{
    private bool _isComple;

    public SimpleGoal(string name, string discription, string points) : base (name, discription, points)
    {

    }
    public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return _isComple;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}
