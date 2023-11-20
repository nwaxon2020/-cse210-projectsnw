using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Assignment assignment = new Assignment();
        MathAssignment mathAssignment = new MathAssignment("Setion 5-6","7-12","Prince Nwachukwu","Geometry");
        WritingAssignment writingAssignment = new WritingAssignment("European History","Mary Waters","The Causes of World War II by Mary Waters");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine("");
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine("");
        Console.WriteLine(writingAssignment.GetSummary());
    }
}