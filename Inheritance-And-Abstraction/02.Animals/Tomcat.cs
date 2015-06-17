using System;

class Tomcat : Cat
{
    private const string grander = "male";
    public Tomcat(string name, int age)
        : base(name, age, grander)
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("Miau");
    }
}
