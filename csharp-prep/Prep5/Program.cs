using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your Name? ");
            string userName = Console.ReadLine();
            return userName;

        }

        static int PromptUserNumber ()
        {
            Console.Write("What is your  favorite number (as an integer): ");
            string userNumb = Console.ReadLine();
            int convertUserNumb = int.Parse(userNumb);
            return convertUserNumb;

        }

        static int SquareNumber  (int userSelectedNumber)
        {
            int squared = userSelectedNumber * userSelectedNumber;
            return squared;

        }

        static void DisplayResult()
        {
            DisplayWelcome();

            string name = PromptUserName();

            int number =  PromptUserNumber();

            int squared = SquareNumber(number);

            Console.WriteLine($"Brother {name} the square of your number is: {squared}");

        }

        DisplayResult();
    }
}