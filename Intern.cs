class Intern : Employee
{
    public Intern(string name, double baseSalary)
        : base(name, baseSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary / 2;
    }
}