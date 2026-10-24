class Student : Person
{
    public string Group { get; set; }

    public Student(string name, int age, string group)
        : base(name, age)
    {
        Group = group;
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"My group is {Group}.");
    }
}