class Truck : Vehicle
{
    public double Capacity { get; set; }

    public Truck(string brand, int year, double capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, {Capacity} tons ";
    }
}