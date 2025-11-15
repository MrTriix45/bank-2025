public abstract class Account
{
    public string Number { get; set; }
    public double Balance { get; protected set; } // ReadOnly
    public Person Owner { get; set; }
    
    // Construct
    public Account(string number, double balance, Person owner)
    {
        Number = number;
        Balance = balance;
        Owner = owner;
    }

    // Method
    public virtual void Withdraw(double amount) //This Method can be override with inheritance
    {
        if (amount <= 0)
        {
            Console.WriteLine("This amount is less or equal than 0");
            return;
        }
        if (Balance - amount <= 0)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }
        Balance -= amount;
    }

    public virtual void Deposit(double amount) //This Method can be override with inheritance
    {
        if (amount <= 0)
        {
            Console.WriteLine("You can't deposit this amount, less than 0");
            return;
        }
        Balance += amount;
    }
}
