public class CurrentAccount
{
    public required string Number { get; set; }
    public double Balance { get; private set; } // ReadOnly
    public double CreditLine { get; set; }
    public required Person Owner { get; set; }

    public void Withdraw(double amount)
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

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("You can't deposit this amount, less than 0");
            return;
        }
        Balance += amount;
    }
}