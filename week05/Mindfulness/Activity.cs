using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {_name}:");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds for this activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        Pause(5); // Give the user 5 seconds to prepare
        EndActivity();
    }

        public void EndActivity()
    {
        Console.WriteLine("\nGood job! You've completed the activity.");
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Pause(3);
    }

    // Pause method to create a spinner animation
    public void Pause(int seconds)
    {
        string spinner = "|/-\\";
        for (int i = 0; i < seconds * 2; i++) // Spinner for duration
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}