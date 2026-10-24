class CreditAccount : BankAccount
{
    public CreditAccount(string owner, double balance)
        : base(owner, balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        if (amount > 0 && Balance - amount >= -500)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
}