using System;

public class EternalGoals : Goal
{
    public EternalGoals (string name, string discription, string points): base(name, discription, points)
    {

    }

    public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}