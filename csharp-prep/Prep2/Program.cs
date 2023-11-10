using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // Prompt the user for their grade as a percentage and take input
        Console.Write("Please enter your grade percentage as an integer: ");
        string gpaString = Console.ReadLine();
        // Convert the input to an integer
        int gpaInt = int.Parse(gpaString);
        // Display their grade
        string gradeLetter = "";
        if (gpaInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gpaInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gpaInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gpaInt >= 60)
        {
            gradeLetter = "D";
        }
        else 
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your grade is {gradeLetter}.");


        // Say whether the student passed or not
        if (gpaInt >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Try harder next time.");
        }
    }
}