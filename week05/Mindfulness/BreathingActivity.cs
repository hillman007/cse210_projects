using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { 

    }

    public void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in... ");
            ShowCountDown(4); // Countdown for 4 seconds
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6); // Countdown for 6 seconds
            Console.WriteLine();
        }
    }
}