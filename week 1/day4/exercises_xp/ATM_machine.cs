using System;
using System.Collections.Generic;
using System.Linq;

class Account
{
    public int PIN;
    public string AccountNumber;
    public double Balance;
    public List<string> Transactions = new ();

    public Account(int PIN, string AccountNumber, double Balance, List<string> Transactions)
    {
        this.PIN = PIN;
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
        this.Transactions = Transactions;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is {Balance} DH");
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        Balance += amount;
        Transactions.Add($"Deposited {amount} DH");
        Console.WriteLine($"{amount} DH added to your balance.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        Balance -= amount;
        Transactions.Add($"Withdrew {amount} DH");
        Console.WriteLine($"You withdrew {amount} DH.");
    }

    public void ShowTransactions()
    {
        if (Transactions.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
            return;
        }

        Console.WriteLine("Transaction History:");
        foreach (var t in Transactions)
        {
            Console.WriteLine("- " + t);
        }
    }
}

class ATM
{
    public Account Authenticate(List<Account> accounts)
    {
        Console.Write("Enter your account number: ");
        string accNumber = Console.ReadLine();
        Account acc = accounts.FirstOrDefault(a => a.AccountNumber == accNumber);

        if (acc == null)
        {
            Console.WriteLine("Account not found.");
            return null;
        }

        Console.Write("enter your PIN: ");
        int pin = int.Parse(Console.ReadLine());

        if (acc.PIN != pin)
        {
            Console.WriteLine("Incorrect PIN.");
            return null;
        }

        Console.WriteLine("Authentication successful!");
        return acc;
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nATM Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Show Transactions");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
    }

    public void PerformAction(Account account, string choice)
    {
        switch (choice)
        {
            case "1":
                account.CheckBalance();
                break;
            case "2":
                Console.Write("Enter deposit amount: ");
                double dep = double.Parse(Console.ReadLine());
                account.Deposit(dep);
                break;

            case "3":
                Console.Write("Enter withdrawal amount: ");
                double wd = double.Parse(Console.ReadLine());
                account.Withdraw(wd);
                break;

            case "4":
                account.ShowTransactions();
                break;

            case "5":
                Console.WriteLine("Exiting...");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        List<Account> accounts = new()
        {
            new Account(1111, "A123", 5000, new List<string>()),
            new Account(2222, "B456", 2500, new List<string>()),
            new Account(3333, "C789", 1000, new List<string>())
        };

        ATM atm = new ATM();

        Console.WriteLine("Welcome to the ATM Machine!");

        Account userAcc = atm.Authenticate(accounts);

        if (userAcc == null)
        {
            Console.WriteLine("Authentication failed. Program ending.");
            return;
        }

        while (true)
        {
            atm.ShowMenu();
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("\nThank you for using our ATM. Here’s your transaction summary:");
                userAcc.ShowTransactions();
                break;
            }
            atm.PerformAction(userAcc, choice);
        }
    }
}
