public class SavingsAccount : Account
{
    public DateTime DateLastWithdraw { get; set; }

    // Construct
    public SavingsAccount(string number, double balance, Person owner) : base(number, balance, owner)
    {
    }

    // Method

    public override void Withdraw(double amount) //Main Method from Account is override for this Class -> use for DateLastWithDraw
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
        DateLastWithdraw = DateTime.Now;
        Balance -= amount;
    }
}
