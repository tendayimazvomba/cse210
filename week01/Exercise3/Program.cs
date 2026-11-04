using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        bool guessedRight = false;

        do
        {
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
                guessedRight = true;
            }
        } while (guessedRight == false);

    }
}