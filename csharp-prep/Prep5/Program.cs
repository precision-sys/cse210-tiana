using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = PromptNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    static int PromptNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your favorite number squared is {squaredNumber}.");
        Console.WriteLine($"You were born in {birthYear}.");
    }
}