using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();

        Console.WriteLine($"\nWelcome to the Journal Program");

        bool askQueston = true;

        while (askQueston)
        {
            Console.WriteLine($"Please select one of the following Choices\n 1. Write\n 2. Save\n 3. Load\n 4. Display\n 5. Quit");
            Console.Write("What will you like to do? ");

            string choice = Console.ReadLine();

            if (int.Parse(choice) == 1)
            {
                DateTime entryDate = DateTime.Now;

                entry._date = entryDate.ToShortDateString();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.Write($"{entry._promptText}\n>> ");
                entry._entryText = Console.ReadLine();

                Console.WriteLine($"\n Entry Recored...successfully");

                journal.AddEntry(entry);

            }

            else if(int.Parse(choice) == 2)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if(int.Parse(choice) == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (int.Parse(choice) == 5)
            {             
                Console.WriteLine("Program Exited Successfully...\n");
                askQueston = false;
            }
            else if (int.Parse(choice) > 5 || int.Parse(choice) <= 0)
            {
                Console.WriteLine("Invalid Entry...Please check the option Numbers again!!\n");
            }

        } 
        journal.DisplayAll();

        
    }
}