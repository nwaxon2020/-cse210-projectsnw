using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string show = reference.Display();
        Scripture scripture = new Scripture(reference, "for God so loved the world that he gave his only begotten son that who so ever ");
           
           
        string userChoice = "play";

        while(userChoice != "quit")
        {
            Console.Clear();

            Console.Write($"{show} ");
            Console.Write($"{scripture.GetDisplayText()}");

            Console.Write("\n\nPlease enter to continue or type 'quit' to finish: ");
            userChoice = Console.ReadLine();
        }




        // string word = "John-3:16; For God so loved the world that he gave his only begotten son that who so ever beliveth in him should not perish but have everlasting life";

        //  List<string> words = new List<string>(word.Split(" "));

        // foreach (string wrd in words)
        // {
        //     Console.WriteLine(wrd);
        // }
        // Console.WriteLine(words.Count);


    












       


    }
}