using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        // Loop to generate list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculate sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate avg (set to 2 decimal places)
        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {avg:F2}");

        // Display max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        // Find smallest positive number
        List<int> positiveNumbers = new List<int>();
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
        }
        Console.WriteLine($"The smallest positive number is: {Min(positiveNumbers)}");

        // Sort numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    // Function to find the min value in a list
    static int Min(List<int> list)
    {
        int minValue = list[0];
        foreach (int num in list)
        {
            if (num < minValue)
            {
                minValue = num;
            }
        }
        return minValue;
    }
}