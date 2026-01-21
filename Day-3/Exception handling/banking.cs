

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}


class BankAccount
{
    public double Balance { get; set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        try
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient balance.");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. Remaining Balance: ₹{Balance}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine($"[LOG] Transaction attempted at {DateTime.Now}");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ₹{Balance}");
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Enter initial balance: ₹");
        double initialBalance = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(initialBalance);
        int choice;

        do
        {
            Console.WriteLine("Choose Options");
            Console.WriteLine("1. Withdraw Money");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to withdraw: ₹");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(amount);
                    break;

                case 2:
                    account.CheckBalance();
                    break;

                case 3:
                    Console.WriteLine("Thank you for banking with us.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 3);
    }
}

