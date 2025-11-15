public class CurrentAccount : Account
{
    public double CreditLine { get; set; }

    // Constructor
    public CurrentAccount(string number, double balance, double creditLine, Person owner) : base(number, balance, owner)
    {
        CreditLine = creditLine;
    }
  
}