class Fish : Animal
{
    public Fish(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Bul Bul ");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} swims");
    }
}