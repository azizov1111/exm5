abstract class Transport
{
    public string Name { get; set; }

    public Transport(string name)
    {
        Name = name;
    }

    public abstract double CalculateFare(double km);
}