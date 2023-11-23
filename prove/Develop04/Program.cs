using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Activity activity = new Activity();

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        

        string doActivity = "yes";

        while (doActivity == "yes")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice number from the menu: ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            else if (userChoice == "2")
            {
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            else if (userChoice == "3")
            {   
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

            else if (userChoice == "4")
            {   
                break;
            }

            else
            {
                Console.WriteLine("\nChoice not found!!!\nplease select from the menu options....");
                break;
            }

            Console.Write("\nWill you like to 'PLAY' again? ");
            doActivity = Console.ReadLine();

        }

        Console.WriteLine("\nProgram has ended");
        activity.ShowSpiner(250);

        







        
    }
}