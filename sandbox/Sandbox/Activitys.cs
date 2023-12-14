using System;
using System.Collections.Generic;

public class Activitys
{
    private string _date;
    protected int _timeLength;

    public Activitys (string date, int time)
    {
        _date = date;
        _timeLength = time;
    }

    public virtual double Distance()
    {
        return 0;
    }
    public virtual double Speed()
    {
        return 0;
    }
    public virtual double Pace()
    {
        return 0;
    }

    public virtual void GetSummary()
    {
        Console.Write($"{_date} {GetType().Name}({_timeLength}mins)-");
    }

}