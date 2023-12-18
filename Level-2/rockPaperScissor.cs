using System;
namespace RockpaperScissor{
    public class ProgramRockPaperScissor{
    
    public static void Main(String [] args){
        start: 
        Console.WriteLine("Welcome to Rock-Paper-Scissor");
        int playerScore = 0;
        int enemyScore = 0;
        
        Console.WriteLine("Enter the Number of Rounds");
        int rounds = Convert.ToInt32(Console.ReadLine());
       
         Random rd = new Random();
         Console.WriteLine("--RULES--");
         Console.WriteLine("Enter R for ROCK ");
         Console.WriteLine("Enter S for SCISSORS ");
         Console.WriteLine("Enter P for PAPER ");
        
        Console.WriteLine("------------");
         
        Console.WriteLine("Let's Begin");
         
        while(rounds>0){
         
        string playerChoice = "";
        Console.WriteLine("Enter the choice");
        playerChoice = Console.ReadLine();
        
        int enemyChoice = rd.Next(0,3);
        // 0 -> Rock , 1-> Scissors , 2-> Paper 
        // in case of tie no one earn the points
        
        // each combinations shpuld be addressed respectively
        if(enemyChoice == 0){
            switch(playerChoice){
                case "P":
                    playerScore++;
                    Console.WriteLine("You Won :) ");
                    break;
                    
                case "S": 
                    enemyScore++;
                    Console.WriteLine("You Lost :( ");
                    break;
                    
                case "R":
                   Console.WriteLine("It's a Tie!");
                   break;
                   
                default: 
                   Console.WriteLine("Please Enter Valid choice!");
                   break;
                 
                
                   
            }
        }
        else if(enemyChoice == 1){
            switch(playerChoice){
                case "R":
                    playerScore++;
                     Console.WriteLine("You Won :) ");
                    break;
                    
                case "P": 
                    enemyScore++;
                    Console.WriteLine("You Lost :( ");
                    break;
                    
                case "S":
                 Console.WriteLine("It's a Tie ");
                   break;
                   
                default: 
                   Console.WriteLine("Please Enter Valid choice!");
                   break;
                 
                
                   
            }
        
        }
        else{
            switch(playerChoice){
                case "S":
                    playerScore++;
                     Console.WriteLine("You Won :) ");
                    break;
                    
                case "R": 
                    enemyScore++;
                     Console.WriteLine("You Lost :( ");
                    break;
                    
                case "P":
                   Console.WriteLine("It's a Tie ");
                   break;
                   
                default: 
                   Console.WriteLine("Please Enter Valid choice!");
                   break;
                 
                
                   
            }
        }
        
         Console.WriteLine("ScoreBoard" );
         
         Console.WriteLine("Your Score  -> " + playerScore  +  "pts");
         Console.WriteLine("Opponent Score  -> " + enemyScore  +  "pts");
         
         Console.WriteLine("");
         
         rounds --;
            
               }
        
       
          
        Console.WriteLine("Press Enter to play Again");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if(keyInfo.Key == ConsoleKey.Enter)
           goto start;
        }
        
    }
    
}

    
