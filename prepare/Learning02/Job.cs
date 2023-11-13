using System;
public class Job{
    public string _jobTitle;
    public string _companyName;
    public double _startYear;
    public double _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }


}