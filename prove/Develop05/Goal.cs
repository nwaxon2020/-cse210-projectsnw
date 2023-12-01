using System;

public abstract class Goal
{
    private string _shortName;
    private string _discription;

    private string _points;

    public Goal(string name, string discription, string points)
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