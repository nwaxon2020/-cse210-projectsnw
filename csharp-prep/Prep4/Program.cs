using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int exit = 0;
      
        while (exit == 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int convertUserInput = int.Parse(userInput);

            numbers.Add(convertUserInput);

            if (convertUserInput == exit)
            {
                exit = 1;
            }
        }

        // Remove the Zero from the list since its  an exit number
        numbers.Remove(0);
        
        // sort the list from smallest to the highest number
        numbers.Sort();

        // Variable to calculate the total of values in list
        int total = 0;

        // for loop to calculate total values in the list
        foreach (int numb in numbers)
        {
            total += numb;
        }
        Console.WriteLine($"The sum is:______ {total}\n");

        // print the sorted list to console
        Console.WriteLine($"Sorted numbers");
        foreach (int numb in numbers)
        {
            Console.WriteLine($"{numb}");
            
        }

        // Smallest number
        int smallestNumbr = numbers[0];
        Console.WriteLine($"\nSmallest number is: {smallestNumbr}");
        
        // variable to calculate average
        int ave = numbers.Count - 1;

        float average = (float)total / ave;

        Console.WriteLine($"\nAverage is_____: {average}");        

    }
}