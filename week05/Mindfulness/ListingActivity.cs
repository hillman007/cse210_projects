using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { 

    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        GetRandomPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items.");
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex); //removes used prompt
        Console.WriteLine($"--- {randomPrompt} ---");
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) //doesn't count empty inputs
            {
                items.Add(input);
            }
        }
        return items;
    }

}