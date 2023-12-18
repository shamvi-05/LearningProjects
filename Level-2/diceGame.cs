using System;
using System.Threading;

namespace DiceGame{
    
    public class HelloDiceGame{
        
         public static void Main(string[] args){
            
            Console.WriteLine("Welcome Let's Play , name please");
            string name = Console.ReadLine();
            
            int player = 0 , playerPts = 0;
            int enemy  = 0 , enemyPts = 0;
            int rounds = 0;
            
            Console.WriteLine("Enter the number of rounds");
            rounds = Convert.ToInt32(Console.ReadLine());
            
            Random rd = new Random();
            
            Console.WriteLine("Let's Begin....");
            for(int i = 1;i<=rounds;i++){
               string ans = "";
               player = rd.Next(1, 7);
               Console.WriteLine(name + " you rolled " + player);
              
               Thread.Sleep(2000);
               
               enemy = rd.Next(1, 7);
               Console.WriteLine("Enemy you Rolled " + enemy);
               
               if(player > enemy) 
                  {   
                     ans = " Hurray :)" ;
                     playerPts++;
                  }
               else
                 { 
                    ans = " Whoops :(" ;
                    enemyPts++; 
                     
                 }
            
               // puts the process on sleep
               Thread.Sleep(1000);
               Console.WriteLine("Round - " + i );
               Console.WriteLine(name + ans);
               
               Console.WriteLine(".........");
               
               Console.WriteLine("Press Enter to continue");
               
               // reads the keyboard key
               ConsoleKeyInfo keyInfo = Console.ReadKey();
               if(keyInfo.Key == ConsoleKey.Enter) continue;
                
            }
            Console.WriteLine("RESULTS :- ");
            if(playerPts > enemyPts) 
            {
                Console.WriteLine(name+ " Won with total of " + playerPts + " points");
            }
            
            else
             { 
                 Console.WriteLine(name+ " lost with total of " + enemyPts + " points");
                 
             }
             
              Console.WriteLine("GAME OVER ! thanks for playing :)");
        }
    }
}