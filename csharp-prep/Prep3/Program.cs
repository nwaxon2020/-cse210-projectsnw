using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        // Random number = new Random();
        // int systemNumber = number.Next(1, 11);

        // int convertUserInput;

        // do
        // {
        //     Console.Write("Guess the magic Number: ");
        //     string userInput = Console.ReadLine();

        //     convertUserInput = int.Parse(userInput);
            
        //     if (convertUserInput > systemNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else if (convertUserInput < systemNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else
        //     {
        //         break;
        //     }

        // } while (convertUserInput != systemNumber);

        // Console.WriteLine($"Congratulations You guessed it!(Choice: {convertUserInput})");


        Console.Write("What is the magic number? ");       
        string userInput = Console.ReadLine();
        int convertUserInput = int.Parse(userInput);

        int convertUserChoice;


        do
        {        

            Console.Write("What is your guess? ");
            string userChoice = Console.ReadLine();
            convertUserChoice =  int.Parse(userChoice);

            if (convertUserChoice > convertUserInput)
            {
                Console.WriteLine("Lower");
            }
            else if (convertUserChoice < convertUserInput)
            {
                Console.WriteLine("Higher");
            }

        } while (convertUserChoice != convertUserInput);

        Console.WriteLine("You guessed it!");

       

    }
}