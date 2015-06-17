using System;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer("Acer",new Component("name","sadada",2000),200);
        Console.WriteLine(computer);
    }
}
