using System;

public class PromptGenerator
{
    public static List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was a small act of kindness I witnessed or experienced today?",
        "Reflect on a challenge or obstacle you faced today and how you overcame it.",
        "Write about something new you learned today.",
        "Reflect on a moment of gratitude for something or someone in your life.",
        "Write about a future adventure or travel destination you're excited about.",
        "Write about something new you learned in the last general conference."
    };


    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}