using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry (string prompt, string response)
    {
        Entry entry = new Entry();
        entry._promptText = prompt;
        entry._entryText = response;
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayAll();
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {

            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"Date: {entry._date}");
            outputFile.WriteLine($"Prompt: {entry._promptText}");
            outputFile.WriteLine(entry._entryText);
            }    
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            Console.WriteLine(line);
        }
    }
}