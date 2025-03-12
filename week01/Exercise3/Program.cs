using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";
        
        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int guess = -1;
            int count = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Lower");
                    count += 1;
                }
            }
            Console.WriteLine($"You guessed it! And it took you {count} tries!");
            Console.WriteLine("Would you like to play again (yes/no?)");
            keepPlaying = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thanks for playing!");
    }
}