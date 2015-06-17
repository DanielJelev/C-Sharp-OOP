using System;
class Dog : Animal
{
    public Dog(string name, int age, string grander): base (name , age ,grander)
    {
        this.Name = name;
        this.Age = age;
        this.Grander = grander;
    }
    public override void ProduceSound()
    {
 	    Console.WriteLine("Bark");
    }
    
}
