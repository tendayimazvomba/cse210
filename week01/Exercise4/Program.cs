using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool continueToEnterNumber = true;
        List<float> numbers = new List<float>();
        float sum = 0;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            float userNumber = float.Parse(userInput);

            if (userNumber == 0)
            {
                continueToEnterNumber = false;
            }

            else
            {
                numbers.Add(userNumber);
                sum += userNumber;
            }
        } while (continueToEnterNumber == true);

        if (numbers.Count > 0)
        {
            float average = sum / numbers.Count;
            float largest = numbers[0];

            foreach (float number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest is: {largest}");
        }

        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
