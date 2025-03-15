using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Enter your response: ");
                string response = Console.ReadLine();
                theJournal.AddEntry(prompt, response);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the file name to load: ");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter the file name to save: ");
                string saveFile = Console.ReadLine();
                theJournal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == 5)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number from 1-5");
            }
        }
        Console.WriteLine("Thank you for using this Journal Program.");
    }
}