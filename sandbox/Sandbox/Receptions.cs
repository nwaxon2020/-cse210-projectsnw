using System;

public class Receptions : Event
{
    private string _emailRSVP;

    public Receptions(string title, string descriptions, string date, string time, Address address, string email) : base(title, descriptions, date, time, address)
    {
        _emailRSVP = email;
    }

     public string FullDetails() // get Full Address for this class
    {
        return $"RSVP Email: {_emailRSVP}\n{base.StandardDetails()}";
    }
}