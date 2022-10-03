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

    public decimal Deposit(decimal amount)
    {
        if(amount >= 0)
        {
            balance += amount;
            return balance;
        }
        else
        {
            throw new ArgumentException("Amount deposited must be greater than zero");
        }
    }

    public decimal CheckBalance()
    {
        try
        {
            return balance;
        }
        catch
        {
            throw new ArgumentException("There was an error checking your balance");
        }
    }
}