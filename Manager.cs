class Manager : Employee
{
    public Manager(string name, double baseSalary)
        : base(name, baseSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary + BaseSalary * 0.20;
    }
}