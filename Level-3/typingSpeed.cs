using System;
using System.Diagnostics;

class TypingSpeedTest
{
    static void Main()
    {
        Console.WriteLine("Welcome to ShamviType!\n");
        start:
        Console.WriteLine("Choose difficulty level (1-3):");
        int difficultyLevel = GetDifficultyLevel();

        string randomSentence = GenerateRandomSentence(difficultyLevel);
        Console.WriteLine("\nType the following sentence:\n");
        Console.WriteLine(randomSentence);

        Stopwatch stopwatch = Stopwatch.StartNew();
        string userTypedSentence = Console.ReadLine();
        stopwatch.Stop();

        double typingSpeed = CalculateTypingSpeed(stopwatch.Elapsed.TotalSeconds, randomSentence.Length);
        double accuracy = CalculateAccuracy(randomSentence, userTypedSentence);

        Console.WriteLine($"\nTyping Speed: {typingSpeed} words per minute");
        Console.WriteLine($"Accuracy: {accuracy}%");
        
        
         Console.WriteLine("Press Y to continue");
        
         if(Console.ReadLine()!= "Y")
        {
             Console.WriteLine("Thanks for Visiting us :)");
             Environment.Exit(0);
             
         }
         else 
           goto start;
    }

    static int GetDifficultyLevel()
    {
        int difficultyLevel;
        while (!int.TryParse(Console.ReadLine(), out difficultyLevel) || difficultyLevel < 1 || difficultyLevel > 3)
        {
            Console.WriteLine("Invalid input. Please choose a difficulty level between 1 and 3:");
        }
        return difficultyLevel;
    }

    static string GenerateRandomSentence(int difficultyLevel)
    {
        //creating a static db for complexity enhancement
        string[] sentencesEasy = {
            "The quick brown fox jumps over the lazy dog.",
            "Programming is fun and challenging.",
            "Hello, world! Welcome to the coding world."
        };

       string[] sentencesModerate = {
            "The quick brown fox jumps over the lazy dog , Programming is fun and challenging.",
            "Elevate your writing experience and watch your ideas come alive. Let AISEO redefine the way you articulate your thoughts.",
            "Sentences play a pivotal role in content writing, serving as the building blocks of communication.",
            "They are the bridges that connect ideas and enable effective expression and hence guide"
        };
        
        string[] sentencesHard = {
            "Beneath a canopy of stars, the ancient forest embraced the night, where shadows whispered tales of time. A lone owl hooted, adding melody to the symphony of nature's nocturnal serenade." ,
            "Amidst rolling hills, a river murmured secrets to ancient stones, as wildflowers swayed to a gentle breeze, embracing the timeless dance of nature's harmony.",
            "The city's heartbeat echoed through crowded streets, where diverse stories intermingled in a cacophony of sounds, creating a vibrant tapestry of urban life."
        };


        Random random = new Random();

        // Adjust sentence length based on difficulty level
        if(difficultyLevel == 1)
            return sentencesEasy[random.Next(0,3)];
        else if(difficultyLevel == 2)
            return sentencesModerate[random.Next(0,4)];
        else
          return sentencesHard[random.Next(0,3)];
    }

   static double CalculateTypingSpeed(double elapsedSeconds, int sentenceLength)
    {
        // Assume an average word length of 5 characters
        int wordsTyped = sentenceLength / 5;
        double wordsPerMinute = (wordsTyped / elapsedSeconds) * 60;
        return Math.Round(wordsPerMinute, 2);
    }
 static double CalculateAccuracy(string original, string typed)
    {
        int correctCharacters = 0;

        for (int i = 0; i < Math.Min(original.Length, typed.Length); i++)
        {
            if (original[i] == typed[i])
            {
                correctCharacters++;
            }
        }

        double accuracy = (correctCharacters / (double)original.Length) * 100;
        return Math.Round(accuracy, 2);
    }
}
