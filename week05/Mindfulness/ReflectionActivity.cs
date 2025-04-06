using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { 

    }

    public void Run()
    {
        DisplayPrompt();
        DisplayQuestion();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex); //removes used prompt
        return randomPrompt;
    }
    public string GetrandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        _questions.RemoveAt(randomIndex); //removes used question
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to contiune.");
        Console.ReadKey();
    }
    public void DisplayQuestion()
    {
        Console.WriteLine("\nNow PONDER on each of the following questions as they relate to this experience.\n");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
          Console.WriteLine(GetrandomQuestion());
          ShowSpinner(10);  
        }
        
    }
}