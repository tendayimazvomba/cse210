//Exceeding Requirements:
//The program selects random words only from those that are still visible.
//This prevents repeatedly selecting words that have already been hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to exit.");
            string? input = Console.ReadLine();

            if (input == "quit" || input == null)
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}