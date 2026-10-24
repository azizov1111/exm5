class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public virtual bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
}