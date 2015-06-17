using System;

class Cat : Animal
{
    public Cat(string name, int age, string grander)
        : base(name, age, grander)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Miau");
    }
}