using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;


namespace OOP_1
{
   
    #region Procedual Programming
     
    class procedualBank
    {
         static int accountNumber;
         static string accountHolderName;
         static double balance;

        static void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited:{amount}");
        }

        static void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }

        static void Main(string[] args)
        {
            accountNumber = 123456;
            accountHolderName = "Mann Badreshiya";
            balance = 0;

            Console.WriteLine($"Account_No.:{accountNumber}, Name:{accountHolderName}, balance:{balance}");
            Deposit(500);
            Withdraw(200);
            Withdraw(400);
            Console.WriteLine($"Final balance:{balance}");

        }
    }

    #endregion


    #region Object Oriented Programming

    class BankAccount
    {
        int accountNumber;
        string accountHolderName;
        double balance;

        public BankAccount(int accNo, String accHolderName, double initialBalance)
        {
            accountNumber = accNo;
            accountHolderName = accHolderName;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited:{amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account_No.:{accountNumber}, Name:{accountHolderName}, balance:{balance}");
        }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1776, "Mann Badreshiya", 0);
            account.DisplayAccountInfo();
            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(400);
            account.DisplayAccountInfo();
        }
    }
}



//Constraints Analysis:-

//1.Code Duplication

//Procedural:
//Each new account = new variables
//Duplicate deposit/withdraw logic

//OOP:
//One class → multiple objects
//Logic reused via methods

//Ease of Extension Example (Adding Account Type):-

//Procedural:
//you must:
//-Add new variables
//-Add new functions
//-Duplicate logic

//oop:
//Inheritance makes extension clean and scalable