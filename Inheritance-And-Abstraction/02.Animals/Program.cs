using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Animal[] array =
            {
                new Cat("Pesho", 2, "male"),
                new Dog("Sharo", 12, "male"),
                new Frog("Froggy", 1, "female"),
                new Kitten("Kitty", 3),
                new Tomcat("Gosho", 5),
                new Cat("Ilyo", 7, "male"),
                new Frog("Hopper", 2, "female"),
                new Dog("Murdzho", 17, "male"),
            };
        var dogAverageAge = array.Where(x => x is Dog).Average(x => x.Age);
        var catAverageAge = array.Where(x => x is Cat).Average(x => x.Age);
        var frogAverageAge = array.Where(x => x is Frog).Average(x => x.Age);
        var kittenAverageAge = array.Where(x => x is Kitten).Average(x => x.Age);
        var tomcatAverageAge = array.Where(x => x is Tomcat).Average(x => x.Age);
        Console.WriteLine("Dog average years: "+dogAverageAge);
        Console.WriteLine("Cat average years: " + catAverageAge);
        Console.WriteLine("Frog average years: " + frogAverageAge);
        Console.WriteLine("Kitten average years: " + kittenAverageAge);
        Console.WriteLine("Tomcat average years: " + tomcatAverageAge);
    }
}