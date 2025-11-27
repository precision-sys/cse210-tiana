using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}
    public override void Execute()
    {
        Start();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        pause(5);
        int timePassed = 0;
        int itemCount = 0;
        while (timePassed < GetDuration())
        {
            Console.ReadLine();
            itemCount++;
            timePassed += 5; 
        }
        Console.WriteLine($"You listed {itemCount} items!");
        End();
    }
}

