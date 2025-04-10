using System;
using System.IO;
using System.Numerics;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(List<Goal> goals, int score = 0)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest!");

        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    Console.WriteLine("1. List Goal Names");
                    
                    break;
                case "3":

                    break;
                case "4":
                    
                    break;
                case "5":

                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        int totalScore = 0;
        foreach (var goal in _goals)
        {
            totalScore += _score;
        }
        Console.WriteLine($"You have {totalScore} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetshortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDescription()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select a goal to record an event: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            Console.WriteLine($"Event recorded for goal: {_goals[index].GetshortName()}");
        }
        else
        {
            Console.WriteLine("Invalid selection. No event recorded.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            _goals.Add(new SimpleGoal(name, description, points));
                            if (isComplete)
                            {
                                _goals[^1].RecordEvent(); // Mark as complete
                            }
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                _goals[^1].RecordEvent(); // Mark as complete
                            }
                            break;
                        default:
                            Console.WriteLine("Unknown goal type. Skipping.");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}