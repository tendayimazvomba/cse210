using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guessedNumber = int.Parse(userGuess);

        if (magicNumber > guessedNumber)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guessedNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}