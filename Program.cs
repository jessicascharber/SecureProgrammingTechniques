using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Mod2Lab
{
    class Program
    {
        static void ValidateEmail(string emailAddress) {
    // Reused Try/catch Statements
            try {
                MailAddress testmail = new MailAddress(emailAddress);
                Console.WriteLine("The email address you entered was in a valid format.");
            }
            catch(ArgumentNullException ex) {
                Console.WriteLine("\n\nAddress is null. - " + ex.Message);
            }
            catch(ArgumentException ex) {
                Console.WriteLine("\n\nAddress is empty. - " + ex.Message);
            }
            catch(FormatException ex) {
                Console.WriteLine("\n\nThis address is not in a valid format. - " + ex.Message);            
            }                    
        }
        static void Main(string[] args)
        {
            string emailTest;
            string password;
            int input = 0;
            string posfeed;
            string negfeed;
            int number = 0;
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("********************************************");
                Console.WriteLine("Welcome to the email and password validator!");
                Console.WriteLine("********************************************");            
                Console.WriteLine("Please enter a number option from the choices below.");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("1. Validate the format of an email address.");    
                Console.WriteLine("2. Validate the format of a password.");
                Console.WriteLine("3. Exit Program");
               
            // New options -
                Console.WriteLine("4. Leave Positive Feedback");
                Console.WriteLine("5. Leave Negative Feedback");
                
            // Try/catch statement to help with input validation-
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid numerical value!");
                    number = int.Parse(Console.ReadLine());
                }                       
                switch(number) 
                {      
                    case 1: Console.WriteLine("Enter an email address to validate its format - ");            
                        emailTest = Console.ReadLine();
                        ValidateEmail(emailTest);           
                    break;      
                    case 2: Console.WriteLine("Enter a password to validate its format - ");
                        password = Console.ReadLine();                          
            
                        var regex= new Regex("^(?=^.{10,15}$)(?=.*[1-20])(?=.*[A-Z])(?=.*[a-z])(?!.*\')(?!.*\")(?!.*[;]).*$");
                  
                        Match match = regex.Match(password);
                        
                        if (match.Success)
                        {
                            Console.WriteLine("The password you entered is in a valid format.");
                        }
                        else
                        {
                            Console.WriteLine("This password is not in a valid format. Your password must contain the following...");
                            Console.WriteLine("An uppercase and lowercase letter, a number between 1-20, 10-15 characters in length and no quotes or semi-colons.");
                        }                                                             
                    break;
                    case 3: input = 3; 
                            Environment.Exit(0);
                    break;
                // New cases - 
                    case 4: input = 4;
                            Console.WriteLine("Please enter your positive feedback.");
                            posfeed = Console.ReadLine();
                            Console.WriteLine("Thank you for your feedback!");
                    break;
                    case 5: input = 5;
                // Custom Try/catch Statement with Input Validation -                   
                        try {
                            Console.WriteLine("Please enter your negative feedback.");
                            negfeed = Console.ReadLine();
                                if (true){                            
                                    throw new customException();
                                    // Ha, ha, ha. :)
                                 }
                            }
                        catch {
                             Console.WriteLine("An exception occurred!");
                        }
                        break;
                        }            
            if (input != 3)
                continue;
            else
                break;                       
            }
        }         
           
    }
}

