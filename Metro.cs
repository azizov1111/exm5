class Metro : Transport
{
    public Metro() : base("Metro")
    {
    }

    public override double CalculateFare(double km)
    {
        return km <= 10 ? 2 : 4;
    }
}