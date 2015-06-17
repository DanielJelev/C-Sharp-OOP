using System;
class Kitten : Cat
{
    private const string grander = "female";
    public Kitten(string name, int age)
        : base(name, age, grander)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Miau");
    }
}