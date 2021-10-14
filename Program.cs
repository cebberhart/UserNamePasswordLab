using System;
using System.Collections.Generic;
using System.Linq;


namespace PasswordLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter a password and username.
            //Create two differnt list arrays for password and username.
            //Display prompt user to enter a password.
            //Check if requirements are met, if all conditions are met continue.
            //Display prompt user to enter a user name.
            //Check if requirments are met, if all cinditions are met continue.
            //For the user name, check.

            Dictionary<string, string> passwords = new Dictionary<string, string>();
            
            

            // set a list for the user input
            List<string> password = new List<string>();
            Console.WriteLine("Create a password with one lower and one upper case letter, one number, a minimum of 7 to 12 characters, and one special character (! @ # $ % ^ & *)");
            string userPassword = PasswordInput("Password is: ");
            

            Console.WriteLine(password);
            Password(userPassword);


            Dictionary<string, string> usernames = new Dictionary<string, string>();
            //set a list for user input for username
            List<string> username = new List<string>();
            Console.WriteLine("Please enter a username with one lower and one upper case letter, one number, and  minimun of 7 to 12 charcters");
            string userName = UsernameInput("Username is: ");
            Console.ReadLine();

            Console.WriteLine(username);
            

        }

        //Get input from password
        public static string PasswordInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        //Get input from username
        public static string UsernameInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        //checcking the password for requirements
        public static bool Password(string password)
        {
            if (password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must have at least one upper case letter");
                return true;
            }
            if (password.Any(char.IsLower))
            {
                Console.WriteLine("Password must have at least one number");
                return true;
            }
            if (password.Length < 7 || password.Length > 12)
            {
                Console.WriteLine("Please enter a password with one lower and one upper case letter, one number, and minimun of 7 to 12 charcters");
                return true;
            }
            else
            {
                Console.WriteLine("Good Job!");
                return false;
            }

            //string specialChar = '!', '@', '#', '$', '%', '^', '&', '*';
            //char[] specialChar = []specialChar.ToCharArry();
            //foreach (char character in specialChar)
            //{
            //    if (password.Contains(char))
            //    {
            //        return true;
            //    }
            //}


        }
        //checking username for requirements
        public static bool UserName(string username)
        {
            if (username.Any(char.IsUpper))
            {
                Console.WriteLine("Username must contain at least one Upper case letter");
                return true;
            }
            if (username.Any(char.IsLower))
            {
                Console.WriteLine("Username must contain at least one Upper case letter");
                return true;
            }
            if (username.Length < 7 || username.Length > 12)
            {
                Console.WriteLine("Username must contain at least 7 to 12 characters");
                return true;
            }
            else
            {
                Console.WriteLine("Good Job!");
                return false;
            }
        }
    }
}
