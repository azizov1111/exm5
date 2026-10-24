class Bird : Animal
{
    public Bird(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Tweet!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} flies");
    }
}