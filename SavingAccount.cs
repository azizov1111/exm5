class SavingsAccount : BankAccount
{
    public SavingsAccount(string owner, double balance)
        : base(owner, balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        if (amount > 0 && Balance - amount >= 100)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
}