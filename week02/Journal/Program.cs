// Creativity and Exceeding Requirements:
// 1. Added 10 journal prompts instead of the minimum 5.
// 2. Implemented a feature that prevents the same journal prompt
//    from appearing twice consecutively.
// 3. The PromptGenerator class remembers the previously selected
//    prompt index and generates a different one for the next entry.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice;

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            else if (choice != 5)
            {
                Console.WriteLine("Invalid choice. Please select 1 to 5.");
            }
        } while (choice != 5);
    }
}