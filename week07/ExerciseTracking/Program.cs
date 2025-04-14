using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Today, 30, 3.0), // 3 km
            new Cycling(DateTime.Today, 30, 12.0), // 12 kph
            new Swimming(DateTime.Today, 30, 20)   // 20 laps
        };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}