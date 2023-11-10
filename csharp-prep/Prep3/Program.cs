using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        
        // generate the magic number
        Random myRandomGenerator = new Random();
        int magicNumber = myRandomGenerator.Next(1, 100);
        // The loop that leads the user to the magic number
        int userGuessInt = 0;
        while (magicNumber != userGuessInt)
        {
            // ask the user for their magic number guess
            Console.WriteLine("What do you think the Magic Number is?");
            string userGuess = Console.ReadLine();
            userGuessInt = int.Parse(userGuess);
            if (userGuessInt < magicNumber)
            {
                Console.WriteLine("Too low, guess again.");
            }
            else if (userGuessInt > magicNumber)
            {
                Console.WriteLine("Too high, guess again.");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }



    }
}