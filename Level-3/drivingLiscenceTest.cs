using System;
using System.Collections.Generic;
using System.Threading;

namespace DrivingLiscencetest{
    class Question{
        //designing a protype
        public string QuestionText { get;}
        public List<string> Options{ get; }
        public string CorrectAnswer {get ;}
        
        // set function
        public Question(string questionText ,  List<string> options , string correctAnswer){
            
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
    
    
    public class ProgramDrivingLiscencetest{
        
        static void Main(String [] args){
            
            Console.WriteLine("Welcome To Driving Liscence Test!");
            Console.WriteLine("Please answer the correct option for asked Queries \n");
            
            
           List<Question> questions = new List<Question>
        {
            new Question("What does a yield sign mean?", new List<string>{"A. Stop", "B. Slow down and be ready to stop", "C. Go ahead"}, "B"),
            new Question("When is it legal to make a U-turn?", new List<string>{"A. Anytime", "B. At intersections with traffic lights", "C. Only when a sign permits"}, "C"),
            new Question("A person driving a vehicle in a public place without a license is liable for:", 
                         new List<string>{"A. Penalty only", "B. Penalty for the driver and the owner and/or seizure of the vehicle", "C. A warning"}, "B"),
            new Question("When is overtaking prohibited?", 
                         new List<string>{"A. When the road is marked with a broken center line in the color white", 
                                         "B. When the vehicle is being driven on a steep hill", 
                                         "C. When the road is marked with a continuous center line in the color yellow"}, "B"),
            new Question("Maximum speed permitted for vehicles towing another vehicle?", 
                         new List<string>{"A. 20 km/hour", "B. 24 km/hour", "C. 32 km/hour"}, "B"),
            new Question("Maximum permitted weight that can be carried on a goods carriage?", 
                         new List<string>{"A. No limit", "B. 10 ton", "C. Allowed as per permit"}, "C"),
            new Question("Maximum permissible speed of a light motor vehicle?", 
                         new List<string>{"A. 60 Km/hr", "B. 70 Km/hr", "C. No limit"}, "C"),
            // Add more questions as needed
        };
        
        
        int passingScore = 69;
        int numberOfQuestions = questions.Count;
        int passingScoreThreshold = (int)Math.Ceiling((passingScore / 100.0) * numberOfQuestions);
        
        Console.WriteLine("Do wanna start ? (Y/N)");
        string ans = Console.ReadLine();
        if(ans == "Y"){
            Console.WriteLine("...Beginning\n");
            Thread.Sleep(1000);
         int score = AskQuestions(questions);
         Console.WriteLine($"Your final score is: {score}/{numberOfQuestions}");

        
                if (score >= passingScoreThreshold)
        {
            Console.WriteLine("Congratulations! You have passed the driving license test.");
        }
        else
        {
            Console.WriteLine("Sorry, you have not passed the driving license test. Please try again.");
        }
        }
        else{
            Console.WriteLine("Oops!...Exiting ");
        }
    }
    

            
            
            
        
    
     static int AskQuestions(List<Question> questions)
    {
        int score = 0;

        foreach (var question in questions)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"{question.Options[i]}");
            }

            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.Trim().Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is: {question.CorrectAnswer}\n");
            }
        }

        return score;
    }

    }
  
}