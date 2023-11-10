using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Tell the user what they will do
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // Create the variables that enter the loop
        List<int> daNumbs = new List<int>();
        int userInputInt;
        // The user enters the numbers
        do
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            userInputInt = int.Parse(userInput);
            daNumbs.Add(userInputInt);
        } while (userInputInt != 0);
        
        // Find the sum of the numbers in the list
        int totalDaNumbs = 0;
        foreach (int daNumb in daNumbs)
        {
            totalDaNumbs += daNumb;
        }
        Console.WriteLine($"The total is: {totalDaNumbs}");

        // Find the average of the numbers
        float daNumbsAverage = ((float)totalDaNumbs / daNumbs.Count);
        Console.WriteLine($"The average is: {daNumbsAverage}");

        // Find the largest number in the list
        int biggestNumb = 0;
        foreach (int daNumb in daNumbs)
        {
            if (daNumb > biggestNumb)
            {
                biggestNumb = daNumb;
            }
        }
        Console.WriteLine($"The biggest number is: {biggestNumb}");

    }
}