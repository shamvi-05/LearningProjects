using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PassworddManager
{
    
    public class ProgramPasswordManager{
       static  string decryptPassword= "";
        public static void Main(String [] args){
             
             Console.WriteLine("Password Manager Console App\n");
             while(true){
                 Console.WriteLine("Options: ");
                 Console.WriteLine("1. Generate Password");
                 Console.WriteLine("2. Save Password");
                 Console.WriteLine("3. Retreive Password");
                 Console.WriteLine("4. Exit");
                 
                 Console.WriteLine("Enter your choice: ");
                 string choice = Console.ReadLine();
                 
                 switch(choice){
                     case "1" :
                         GeneratePassword();
                         break;
                     case "2" :
                         SavePassword();
                         break;
                         
                     case "3" :
                         RetrievePassword();
                         break;
                         
                     case "4" :
                         Console.WriteLine("Thanks for Visiting!");
                         Environment.Exit(0);
                         break;  
                         
                      default :
                         Console.WriteLine("Invalid operations");
                         break;
                     
                 }
                 
                 
             }
        }
        
        // now generate separate functions for each operations
        static void GeneratePassword(){
            
            Console.WriteLine("Refer the Complexity Chart");
            Console.WriteLine("1-> Easy");
            Console.WriteLine("2-> Intermediate");
            Console.WriteLine("3-> Hard");
            
            Console.WriteLine("Enter the preferred Password Complexity");
            Console.WriteLine("==========\n");
            
            
            int complexityLevel ;
            if(int.TryParse(Console.ReadLine(), out complexityLevel) &&
            complexityLevel >=1 && complexityLevel <=3){
                
                // ideal pswd length should be b/w [10,14]
                int length = 8 +  complexityLevel *2;
                string password = Guid.NewGuid().ToString("N").Substring(0, length);
                Console.WriteLine($"Generated Password : {password}");
                
            }
            
            else{
                Console.WriteLine("Invalid operations");
            }
            
        }
        
        static void SavePassword(){
            Console.WriteLine("Enter the passsword to save : ");
            string passwordToSave = Console.ReadLine();
            
            // encrypt the password
            string encryptPassword = EncryptPassword(passwordToSave);
            
            Console.WriteLine("Password saved succesfully..");
            Console.WriteLine("Need the Encrypted password (Y/N)");
            if(Console.ReadLine() == "Y")
               Console.WriteLine($"Encrypted Password : {encryptPassword} ");
            
        }
        
      static string EncryptPassword(string password){
          
           // use AES Encryption techniques
           
            Aes aes = Aes.Create();  
            aes.KeySize = 256;  
            aes.Mode = CipherMode.CBC;  
            aes.GenerateKey();  
            aes.GenerateIV();  
  
            string plaintext = password; 
            byte[] ciphertext;  
  
            using (ICryptoTransform encryptor = aes.CreateEncryptor())  
            {  
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);  
                ciphertext = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);  
            } 
            string decryptedText;  
  
            using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))  
            {  
                byte[] decryptedBytes = decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);  
                decryptedText = Encoding.UTF8.GetString(decryptedBytes);  
            }  
           
            decryptPassword = decryptedText;
            return Convert.ToBase64String(ciphertext);
      }
      
     static void RetrievePassword()
        {
            Console.WriteLine("Enter the encrypted password ");
            string encryptPswrd = Console.ReadLine();
            
            string decryptPswd = decryptPassword;
            if (decryptPswd != null)
                Console.WriteLine($"Decrypted Password is: {decryptPswd}");
            else
                Console.WriteLine("Invalid Password");
        }
        
    

      
    }
}