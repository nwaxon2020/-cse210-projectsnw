using System;

public class Running : Activitys
{
    private double _distance;

    public Running(string date, int time, double distance ) : base(date, time)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / (_timeLength / 60.0);
        
    }
    public override double Pace()
    {
        return _timeLength / _distance;
    }

    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"Distance: {_distance:F1}km, Speed: {Speed():F1}kph, Pace: {Pace():F2} min/km");
    }
}