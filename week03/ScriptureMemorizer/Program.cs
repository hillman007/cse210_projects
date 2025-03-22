using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

//Created by Eric Hillman
//Added functionality to ask user how many words they would like hidden at a time.
class Program
{
    static void Main(string[] args)
    {
        
        string reference = "John 3:16";

        string text = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.";
        
        // Split the book from the rest
        string[] parts = reference.Split(' ', 2); // Split at first space
        string book = parts[0]; // Book ie "John"
        string chapterAndVerses = parts[1]; // Chapter and verse ie "3:16-17"

        // Split chapter and verses
        string[] chapterParts = chapterAndVerses.Split(':');
        int chapter = int.Parse(chapterParts[0]); // chapter ie "3"
        string[] verses = chapterParts[1].Split('-');
        int startVerse = int.Parse(verses[0]); // start verse ie "16"
        Reference scriptureReference;
        if (verses.Length > 1) // if verses has more than 1 substring
        {
            int endVerse = int.Parse(verses[1]); // endverse ie "17"
            scriptureReference = new Reference(book, chapter, startVerse, endVerse);
        }
        else{
            scriptureReference = new Reference(book, chapter, startVerse);
        }  

        Scripture scripture = new Scripture(scriptureReference, text);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        
        Console.Write("How many words would you like to hide at a time? ");
        int numberToHide = int.Parse(Console.ReadLine());

        bool quit = false;
        while (!scripture.IsCompletelyHidden() && !quit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            //Console.Write("How many words would you like to hide at a time? ");
            //int numberToHide = int.Parse(Console.ReadLine());

            Console.Write("Press enter to hide a word or type 'quit' to exit: ");
            string userinput = Console.ReadLine().ToLower();

            if (userinput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWords(numberToHide);
            }
        }
        if (quit)
            {
                Console.WriteLine("Thank you for playing!");
                
            }
        else
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("Good job! All the words are now hidden");
        }
    }
}