using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option by entering a number from 1 to 4: ");
            option = int.Parse(Console.ReadLine());

        
        

            if (option == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Execute();
            }

            else if (option == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Execute();
            }
            else if (option == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Execute();
            }

            else if (option == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }

            else 
            {
                Console.WriteLine("Please select a number from 1 to 4.");
            }
    
        }
    }

}





