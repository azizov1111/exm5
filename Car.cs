class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(string brand, int year, int doors)
        : base(brand, year)
    {
        Doors = doors;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, {Doors} doors";
    }
}