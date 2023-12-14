using System;

public class Swimming : Activitys
{
    private int _swimmingLaps;

    public Swimming(string date, int time, int swimmingLaps) : base(date, time)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double Distance()
    {
        return _swimmingLaps * 50 / 1000.0;
    }
    public override double Speed()
    {
        return Distance() / (_timeLength / 60.0);
        
    }
    public override double Pace()
    {
        return _timeLength / Distance();
    }

    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"Distance: {_swimmingLaps:F1}km, Speed: {Speed():F1}kph, Pace: {Pace():F2} min/km");
    }
}