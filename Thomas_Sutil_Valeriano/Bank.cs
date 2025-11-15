
using System.Collections.Generic;

public class Bank
{
    public Dictionary<string, CurrentAccount> Accounts { get; } = new Dictionary<string, CurrentAccount>();
    public string Name { get; set; }

    // Constructor
    public Bank (string name)
    {
        Name = name; 
    }

    // Method for Add New Account
    public void AddAccount(CurrentAccount account)
    {
        // Check if the number account is empy or null
        if (string.IsNullOrEmpty(account.Number))
        {
            Console.WriteLine("Number Account is empty");
            return;
        }
        // Check if Number Account EXIST
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("This number account already exist");
            return;
        }
        Accounts.Add(account.Number, account);
        Console.WriteLine($"Account {account.Number} added successfully !");
    }
    // Method for Delete Account
    public void DeleteAccount(CurrentAccount account)
    {
        if (string.IsNullOrEmpty(account.Number))
        {
            Console.WriteLine("Number Account is empty");
        }
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("This number account already exist");
        }
        Accounts.Remove(account.Number);
        Console.WriteLine($"Account {account.Number} deleted successfully !");
    }
    // Method for return the Balance Account

    public double BalanceGet(CurrentAccount account)
    {
        Console.WriteLine($"Total Balance for the {account.Number} : {account.Balance}");
        return account.Balance;
    }

    // Method for return the SUM of Balance for all Account with the name
    public double GetTotalBalanceAll(Person person)
    {
        if (person == null)
        {
            Console.WriteLine("I can't see ghosts !");
            return 0;
        }

        double totalBalance = 0;
        foreach (var account in Accounts.Values)
        {
            if (account.Owner == person)
            {
                totalBalance += account.Balance;
            }
        }
        Console.WriteLine($"Total Balance for {person.FirstName} {person.LastName} : {totalBalance}");
        return totalBalance;
    }
}