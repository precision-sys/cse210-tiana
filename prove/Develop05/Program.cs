class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("Score: " + _score);
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) CreateGoal();
            else if (choice == 2) ListGoals();
            else if (choice == 3) SaveGoals();
            else if (choice == 4) LoadGoals();
            else if (choice == 5) RecordEvent();
        }

        Console.WriteLine("Goodbye!");
    }


    static void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }



    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you complete? ");

        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }



    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.SaveString());
            }
        }

        Console.WriteLine("Saved!");
    }




    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split("|");
            string type = p[0];

            if (type == "Simple")
            {
                SimpleGoal sg = new SimpleGoal(p[1], p[2], int.Parse(p[3]));
                sg.SetIsCompleted(bool.Parse(p[4]));
                _goals.Add(sg);
            }
            else if (type == "Eternal")
            {
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
            }
            else if (type == "Checklist")
            {
                ChecklistGoal cg = new ChecklistGoal(
                    p[1], p[2], int.Parse(p[3]),
                    int.Parse(p[5]),
                    int.Parse(p[6])
                );

                cg.SetCurrentCount(int.Parse(p[4]));
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Loaded!");
    }
}

