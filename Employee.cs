abstract class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void PrintInfo()
    {
        Console.WriteLine(
            $"Name: {Name}, Salary: {CalculateSalary():F2}");
    }
}