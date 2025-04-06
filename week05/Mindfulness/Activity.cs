using System;
// ADDED "Make sure no random prompts/questions are selected until they have all been used at least once in that session."
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        string[] spinner = new string[] { "|", "/", "-", "\\" };
        int counter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + spinner[counter % spinner.Length]); // Update spinner
            counter++;
            Thread.Sleep(100); // Delay for the spinner to rotate
        }
        Console.Write("\b \b");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000); // Wait for 1 second before updating
            Console.Write("\b \b"); //erase previous number
        }
        Console.WriteLine("");
    }
}