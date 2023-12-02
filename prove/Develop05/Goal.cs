using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _discription;
    protected int _points;

    public Goal(string name, string discription, int points)
    {
        _shortName = name;
        _discription = discription;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_discription})";
    }
    public abstract string GetStringRepresentation();


}