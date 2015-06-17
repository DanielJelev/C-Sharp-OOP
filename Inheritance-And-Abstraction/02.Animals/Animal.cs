using System;
public abstract class Animal : ISoundProduceble
{
    private string name;
    private int age;
    private string grander;
    public Animal(string name, int age, string grander)
    {
        this.Name = name;
        this.Age = age;
        this.Grander = grander;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grander { get; set; }
    public abstract void ProduceSound();
}
