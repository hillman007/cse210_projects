using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Activity> activities = new Dictionary<int, Activity>
        {
            { 1, new BreathingActivity() },
            { 2, new ReflectionActivity() },
            { 3, new ListingActivity() }
        };

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

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (activities.ContainsKey(int.Parse(choice)))
            {
                activities[int.Parse(choice)].StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                Thread.Sleep(2000);  // Pause for 2 seconds before clearing the screen
            }
        }
    }
}