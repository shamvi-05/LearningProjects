using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Words and Characters Counter!");
        Console.WriteLine("Enter a text:");

        
        string inputText = Console.ReadLine();

      
        int wordCount = CountWords(inputText);
        int charCount = inputText.Length;

        
        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"Number of characters: {charCount}");

        Console.ReadLine(); 
    }

    static int CountWords(string text)
    {
        // Split the text into words using space as a separator
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
