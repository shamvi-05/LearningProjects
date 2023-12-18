using System;
namespace ConsoleApplication
{
public class Calculator
{
    public static void display(double a, double b , int operation)
    {
        switch (operation) 
        {
            case 1:
              Console.WriteLine(a+b);
              break;
            case 2:
              Console.WriteLine(a-b);
              break;
            case 3:
              Console.WriteLine(a/b);
              break;
            case 4:
              Console.WriteLine(a*b);
              break;
            default :
              Console.WriteLine("Invalid operations");
              break;
        }
    
     }
    public static void Main(string[] args)
    {
        bool ans = true;
        while(ans) {
        Console.WriteLine ("Welcome to BinaryCalculator");
        Console.WriteLine("Operations that can be performed");
        Console.WriteLine("1-> Addition");
        
        Console.WriteLine("2-> Substraction");
        Console.WriteLine("3-> Division");
        Console.WriteLine("4-> Multiplication");
        Console.WriteLine("");
        int operation = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter First Number");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        double b = Convert.ToDouble(Console.ReadLine());
        
        
        display(a, b , operation);
        Console.WriteLine("Do you want to continue ? Y/N");
        string choice = Console.ReadLine();
        if(choice == "Y") ans =true;
        else 
        {
            ans = false;
            Console.WriteLine("Thank You For Visiting!");
        }
        
       }
   }
 }
}