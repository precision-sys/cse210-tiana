using System;
using scripturememorizer;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 36, 1, 2);
        string text = "My son, give ear to my words; for I swear unto you, that inasmuch as ye shall keep the commandments of God ye shall prosper in the land. I would that ye should do as I have done, in remembering the captivity of our fathers; for they were in bondage, and none could deliver them except it was the God of Abraham, and the God of Isaac, and the God of Jacob; and he surely did deliver them in their afflictions.";
    

                Scripture scripture = new Scripture (reference, text);
                
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetReferencedText());
                    Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
            
                        break;

                    scripture.HideRandomWords(4);    

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.GetReferencedText());
                        Console.WriteLine("All words are hidden. Program will Exit");
                        break;
                    }
            
                }   

    }
}















