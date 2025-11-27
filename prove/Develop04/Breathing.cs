using System;
using System.Threading;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}
        public override void Execute()
        {
            Start();
            int timePassed = 0;
            while (timePassed < GetDuration())
            {
                Console.WriteLine("Breathe in...");
                pause(4);
                timePassed += 4;
                Console.WriteLine("Breathe out...");
                pause(6);
                timePassed += 6;
            }   
            End();
        }
    
}

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}
    public override void Execute()
    {
        Start();
        Console.WriteLine("Consider the following prompt:");
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        int timePassed = 0;
        while (timePassed < GetDuration())
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            pause(10);
            timePassed += 10;
        }
        End();
    }

}