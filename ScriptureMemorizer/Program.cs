// Program_Additional.cs
using System;

public partial class Program
{
    public static void DisplayScripture(string scripture)
    {
        Console.Clear();
        Console.WriteLine("Complete Scripture:");
        Console.WriteLine(scripture);
    }

    public static void HideRandomWords(ref string scripture)
    {
        Random random = new Random();
        string[] words = scripture.Split(' ');

        
        int index = random.Next(words.Length);
        
        
        string selectedWord = words[index];
        string hiddenWord = new string('_', selectedWord.Length);

        words[index] = hiddenWord;

        
        scripture = string.Join(" ", words);
        
        
        Console.Clear();
        Console.WriteLine("Updated Scripture:");
        Console.WriteLine(scripture);
    }
}

