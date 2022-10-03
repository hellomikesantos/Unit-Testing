Console.WriteLine("Run");


public class BankAccount
{
    private decimal _balance;
    public decimal balance
    {
        get { return _balance; }
        set { _balance = value; }
    } 
    
    public decimal Withdraw(decimal amount)
    {
        if(balance >= amount)
        {
            balance -= amount;
            return balance;
        }
        else
        {
            throw new ArgumentException("Withdraw exceeds available funds.");
        }
    }
}