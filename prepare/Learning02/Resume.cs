using System;
public class Resume{
    public string _personName;
    public List<Job> _job = new List<Job>();

    public void ResumeFunctions(){

        Console.WriteLine($"Name: {_personName}\nJobs:");

        foreach (Job personJob in _job)
        {
            personJob.DisplayJobDetails();
        }      
    }
}