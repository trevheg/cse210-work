using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }

    // Display the message "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNum = Console.ReadLine();
        int favNumInt = int.Parse(favNum);
        return favNumInt;

    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number) 
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }

}

