using System;
using System.Collections.Generic;
public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    //constructor
    public cardHolder(string cardNum , int pin , string firstName , string lastName , double balance)
    {
          this.cardNum = cardNum;
          this.pin = pin;
          this.firstName = firstName;
          this.lastName = lastName;
          this.balance = balance;

    }

    // intitalise the setters and getters for each variables in the classs
    public String getcardNum(){
         return cardNum;
    }
     public int getPin(){
         return pin;
    }
     public String getfirstName(){
         return firstName;
    }
     public String getlastName(){
         return lastName;
    }
    public double getbalance(){
         return balance;
    }


    public void  setCardNum(String newcardNum){
        cardNum = newcardNum;
    }
    public void setpin(int newPin){
        pin = newPin;
    }

   public void setfirstName(String newfirstName){
       firstName = newfirstName;
    }
    public void setlastName(String newlastName){
       lastName = newlastName;
    }
  public void setbalance(double newBalance){
    balance = newBalance;
  }
   
   public static void Main(String[] args){
       void printOptions(){
           Console.WriteLine("Choose the purpose: ");
           Console.WriteLine("1 -->  Deposit ");
            Console.WriteLine("2-->  Withdraw ");
             Console.WriteLine("3 -->  Check Balance");
              Console.WriteLine("4 -->  Exit ");

       }

       void deposit(cardHolder currentUser){
           Console.WriteLine("Enter the amount you want to deposit");
           double deposit = Double.Parse(Console.ReadLine());
           double currentBalance = currentUser.getbalance();
           currentUser.setbalance(deposit+currentBalance);
           Console.WriteLine("Amount Deposited");
       }
       void withdraw(cardHolder currentUser){
           Console.WriteLine("Enter the amount you want to withdraw");
           double withdraw = Double.Parse(Console.ReadLine());
           double currentBalance = currentUser.getbalance();

           if(currentBalance  >= withdraw)
               { currentUser.setbalance(currentBalance - withdraw);
                Console.WriteLine("Amount Withdrawn");}
           else {
                 Console.WriteLine("Insufficient balance" );
           }
       }

       void checkBalance(cardHolder currentUser){
         Console.WriteLine("Current Balance "  + currentUser.getbalance() );
           
       }
     
    List <cardHolder> cardHolders = new List<cardHolder>();
     //create a static db
    cardHolders.Add(new cardHolder("4532772818527395" ,1234,"John", "Griffith",150.31));
    cardHolders.Add(new cardHolder("4532761841325802", 4321 , "Ashley", "Jones", 321.13));
    cardHolders.Add(new cardHolder("45111111111111802", 4536 , "Shambhavi", "Singh", 789.13));
    cardHolders.Add(new cardHolder("4522222222225802", 4451 , "Chinny" , "Shans", 345.13));
     

     // promt the user
     Console.WriteLine("Welcome to SBI ATM - Vadala Branch");
     Console.WriteLine("Please Insert your Card");
     String userCardNum = "";
     cardHolder currentUser;

     while(true){
         try {
               userCardNum = Console.ReadLine();
               // find the appropriate match in our static db
              var result = cardHolders.FirstOrDefault(a => a.cardNum == userCardNum);
               if(currentUser!= null){break;}
               Console.WriteLine("Account not Recognised. Please Try Again");
               
               
         }
         catch{
               Console.WriteLine("Account not Recognised. Please Try Again");
         }
     }

    Console. WriteLine("Please enter your pin: ");
    int userPin = 0;
    while (true)
    {
       try
        {  
             userPin = int.Parse(Console.ReadLine());
            if (currentUser.getPin() == userPin) { break; }
            else { Console.WriteLine("Incorrect pin. Please try again."); }
        } 

        catch { Console.WriteLine("Card not recognized. Please try again"); }
     }

       
   }
}