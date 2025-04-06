using System;
// ADDED "Make sure no random prompts/questions are selected until they have all been used at least once in that session."
class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                Thread.Sleep(500);
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new();
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.Run();
                reflectionActivity.DisplayEndingMessage();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                Thread.Sleep(2000);  // Pause for 2 seconds before clearing the screen
            }
        }
    }
}