using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Ask the user for their first and last names
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        // Write the name in Bond, James Bond format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}