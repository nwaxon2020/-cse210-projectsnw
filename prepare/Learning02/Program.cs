using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Job job1 = new Job();
        job1._jobTitle = "Softwre Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Console.WriteLine($"{job1._companyName}\n{job2._companyName}\n");

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._personName = "Prince";
        myResume._job.Add(job1);
        myResume._job.Add(job2);      
        
        myResume.ResumeFunctions();

    }
}