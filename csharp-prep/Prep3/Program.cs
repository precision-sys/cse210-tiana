using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess < magicNumber)
        {
            Console.WriteLine("higher" );
        }
        else if (userGuess > magicNumber)
        {
            Console.WriteLine("lower" );
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the magic number!");
        }
    }
}