using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Word word1 = new Word(scriptureText);

        string[]splitedText = scriptureText.Split(" ");

        int countScriptureText = 0;

        Reference reference = new Reference("John", 3, 16);
        string show = reference.Display();

        Scripture scripture = new Scripture(reference, scriptureText);   

        foreach(string word in splitedText)
        {
            countScriptureText++;
        }

        string userChoice = "play";

        Console.Write($"{scripture.GetDisplayText()}"); 

        Console.Write("\n\nPlease enter to continue or type 'quit' to finish: ");
        userChoice = Console.ReadLine(); 

        while(userChoice != "quit" || !scripture.IsCompletelyHidden())
        {
            word1.Show();
           Console.Clear();
           
            Console.Write($"{show} ");
            scripture.HideRandomWords(countScriptureText);
        
            Console.Write("\n\nPlease enter to continue or type 'quit' to finish: ");
            userChoice = Console.ReadLine(); 

            countScriptureText --;
            if(userChoice =="quit")
            {
                break;
            }
        }

        Console.WriteLine("Program ended.");


        // string word = "John-3:16; For God so loved the world that he gave his only begotten son that who so ever beliveth in him should not perish but have everlasting life";

        //  List<string> words = new List<string>(word.Split(" "));

        // foreach (string wrd in words)
        // {
        //     Console.WriteLine(wrd);
        // }
        // Console.WriteLine(words.Count);


    












       


    }
}