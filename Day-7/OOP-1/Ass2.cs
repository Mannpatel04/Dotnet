using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP_1
{

    class UserProfile
    {
        private string Password;

        public string Username;
        public string Email;

        public UserProfile(string username, string email, string password)
        {

            if (!IsValidEmail(email))
            {
                Console.WriteLine("Email is not valid");
            }

            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }
    }
    class Ass2
    {
      
        public static void Main()
        {
            
                UserProfile user = new UserProfile("Mann", "patelmann655@gmail.com", "@Mannb10");

                Console.WriteLine("User Created!");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Email: {user.Email}");
        }
    }
}


//Assignment 2 Theory:-

//What breaks if everything is public:-

//You lose:
//Password rules
//Email checks
//Security
// Anyone can put your object into an invalid state.






