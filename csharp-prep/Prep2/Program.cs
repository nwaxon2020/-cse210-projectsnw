using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Console.Write("What is your grade in percentage: ");
        string userInput = Console.ReadLine();

        int userGrade = int.Parse(userInput);

        int gradeSign = userGrade % 10;

        string letter;

        string sign = "";

        if(gradeSign >= 7)
        {
            sign = "+";
        }
        else if(gradeSign < 3)
        {
            sign = "-";
        }

        if(userGrade >= 70){       

            if(userGrade >= 90)
            {

                letter = "A";
                Console.WriteLine($"Your Grade is {letter}{sign}");
            }
            else if(userGrade>= 80)
            {
                letter = "B";
                Console.WriteLine($"Your Grade is {letter}{sign}");
            }
            else{
                letter = "C";
                Console.WriteLine($"Your Grade is {letter}{sign}");
            }
            Console.WriteLine($"Congratulation you passed (Score: {userGrade})");
        } 
        else
        {
            if(userGrade>= 60)
            {
                letter = "D";
                Console.WriteLine($"Your Grade is {letter}");
            }
            else
            {
                letter = "F";
                Console.WriteLine($"Your Grade is {letter}");
            }
            Console.WriteLine($"Please try again next semester you cannot be Promoted (Score: {userGrade})");
        } 
    }
}