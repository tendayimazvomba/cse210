using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        bool passTheCourse = false;
        string grade;

        if (number >= 90)
        {
            grade = "A";
            passTheCourse = true;
        }

        else if (number >= 80)
        {
            grade = "B";
            passTheCourse = true;
        }

        else if (number >= 70)
        {
            grade = "C";
            passTheCourse = true;
        }

        else if (number >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        } 

        Console.WriteLine($"The student's grade for the course is {grade}.");

        if (passTheCourse == true)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed the course.");
        }
    }
}