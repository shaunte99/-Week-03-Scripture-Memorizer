// Program.cs
using System;

public partial class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizer");

        
        string scripture = "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        
        DisplayScripture(scripture);

        
        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

            
            HideRandomWords(ref scripture);
        }
    }
}
