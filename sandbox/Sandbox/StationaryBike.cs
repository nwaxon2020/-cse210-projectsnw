using System;

public class StationaryBike : Activitys
{
    private double _speed;

    public StationaryBike(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed;
    }
    public override double Speed()
    {
        return 60.0 / Pace();
        
    }
    public override double Pace()
    {
        return 60.0 / _speed;
    }

    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"Distance: {_speed:F1}km, Speed: {Speed():F1}kph, Pace: {Pace():F2} min/km");
    }
}