using System;
using System.Collection.Generics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string> ()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"

        };
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Consile.WriteLine("4. Load");
            Console.WriteLIne("5. Quit");

            Console.Write("Chose and option: ");
            choice = int.parse(Console.ReadLine());
            Console.Write.Line();

            if (choice == 1)
            {
                Random p = new Random();
                string prompt = prompts[p.Next(prompts.Count)];
                Console.WriteLine($"{prompt}");
                Console.write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("dd-MM-yyyy");
                entry._promt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
                Console.WriteLine("Your entry was added");
            }

            else if (choice == 2)
            {
                journal.DisplayJournal();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Your entry has been saved!");
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded!");
            }
        }
    }
}

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.Writeline($"Date: {_date}");
        Console.Writeline($"{_prompt}");
        Console.Writeline($"Response: {_response}");
    }
}

class journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry)
    }

    public void DisplayJournal()
    {
        Console.Writeline("Journal Entries");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreaWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.split("|");

            Entry entry = new Entry();
            entry._date[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}

    