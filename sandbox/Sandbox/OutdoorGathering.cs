using System;

public class OutdoorGathering : Event // base class added
{
    private string _weatherStatment;

    public OutdoorGathering(string title, string descriptions, string date, string time, Address address, string weather) : base(title, descriptions, date, time, address)
    {
        _weatherStatment = weather; // weather constructor
    }

    public string FullDetails() // Full Address for this class 
    {
        return $"{base.StandardDetails()}\nWeather Forcast: {_weatherStatment}";
    }
}