using System;
using System.Threading;

namespace DecisionMaker
{
public class ProgramDecisionMaker
{
 public  static bool ProbablityGenerator(){
     Random rd = new Random();
        int decisionYes = 0, decisionNo = 0;
        
        for(int i =1;i<=100;i++)
        {
        
         int num = rd.Next(1,3);
         
         if(num == 1) decisionYes++;
         else decisionNo++;
         
        }
    
     double probablityNo = decisionNo  / 2;
     double probablityYes = decisionYes / 2;
     
     if(probablityYes > probablityNo) return true;
     else return false;
    
}
    public static void Main(string[] args)
    {
        
      bool ans = true;
      do{
       string statement = "";
        
       Console.WriteLine("Enter the Statement");
       statement = Console.ReadLine();
        
       bool decisionFinal = ProbablityGenerator();
       
       Console.WriteLine(".......Analysing");
       Console.WriteLine("");
       Thread.Sleep(2000);
       
       if(decisionFinal)
         Console.WriteLine("Go for it!");
       else
          Console.WriteLine("A bit Risky!");
          
          
        Console.WriteLine("");
        Console.WriteLine("Press Enter to ask again!");
        
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if(keyInfo.Key != ConsoleKey.Enter) ans = false;
          
      } while(ans);
        
        
    }
}

}