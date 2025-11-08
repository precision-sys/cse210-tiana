using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!");

        }

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("YOur grade is B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }

        else
        {

            Console.WriteLine("Your grade is F");
        }

    }
}