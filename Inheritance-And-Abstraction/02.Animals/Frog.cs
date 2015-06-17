using System;
class Frog : Animal
{
    public Frog(string name, int age, string grander)
        : base(name, age, grander)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Cvak");
    }
}