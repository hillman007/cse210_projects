using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        String Usergrade = Console.ReadLine();
        
        int grade = int.Parse (Usergrade);

        String letter = "";

        if (grade >= 90)
        { 
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        String sign = "";

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }



    }
}