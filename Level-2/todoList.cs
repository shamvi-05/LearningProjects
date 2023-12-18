using System;
using System.Collections.Generic;
namespace Todo{
public class ProgramTodo
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to Todo's List");
        Console.WriteLine("Press the option you want to perform : ");
        Console.WriteLine("1-> Add a Task");
        Console.WriteLine("2-> Delete a Task");
        Console.WriteLine("3-> View the task");
        Console.WriteLine("4-> To exit" );
        Console.WriteLine(" " );
        
        
        String choice = "";
        
        List<String> Tasks = new List<String>();
        
        do{
            
            Console.WriteLine("Which operation?");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                again:
                Console.WriteLine("Enter the task");
                String task = Console.ReadLine();
                Tasks.Add(task);
                Console.WriteLine("Task added..");
                Console.WriteLine("Want to add more tasks (Y/N)?");
                if(Console.ReadLine() == "Y" ) goto again;
                
                
            }
            else if(choice == "2")
            {
                Console.WriteLine("Which task is to be removed?");
                // printing the original list
                Console.WriteLine("Task in the Todo's");
                for(int i = 0; i<Tasks.Count; i++)
                     Console.WriteLine(i + ") " + Tasks[i]);
                
                
                int position = Convert.ToInt32(Console.ReadLine());
                Tasks.RemoveAt(position);
                Console.WriteLine("Task Reamoved... ");
                
                Console.WriteLine("Do you want to remove all Tasks (Y/N)");
                String ans = Console.ReadLine();
                
                if(ans == "Y") Tasks.Clear();
            }
            
            else if(choice == "3"){
                 Console.WriteLine("The Tasks:- ");
                 for(int i = 0; i<Tasks.Count; i++)
                     Console.WriteLine(i + ") " + Tasks[i]);
            }
            else if(choice  == "4") {
                Console.WriteLine("...Exiting");
                break;
                
            }
            else
             Console.WriteLine("Invalid operation");
        }
        
        while(choice != "4");
    }
}
}