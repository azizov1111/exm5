class Developer : Employee
{
    public int OvertimeHours { get; set; }

    public Developer(string name, double baseSalary, int overtimeHours)
        : base(name, baseSalary)
    {
        OvertimeHours = overtimeHours;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + OvertimeHours * 50;
    }
}