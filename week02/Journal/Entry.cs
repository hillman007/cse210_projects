using System;

public class Entry
{
    public string _date = DateTime.Now.ToString("dd-MM-yyyy");

    public string _promptText;

    public string _entryText;
    
    public void DisplayAll()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n{_entryText}");
        Console.WriteLine("");
    }

    
}