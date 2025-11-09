using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            
            Console.Write("Enter a number ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        double average = numbers.Average();
        Console.WriteLine($"the average is {average}");

        int max = numbers.Max();
        Console.WriteLine($"the max is {max}");

        
    }
}