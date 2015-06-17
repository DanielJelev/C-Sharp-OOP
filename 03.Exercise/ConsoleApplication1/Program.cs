using System;

class Program
{
    static void Main(string[] args)
    {
        var book = new Book("Pod Igoto", "Ivan Vazov", 15.90);
        GoldenEditionBook golden = new GoldenEditionBook("adsa", "asd", 20.5);
        Console.WriteLine(book.ToString());
       Console.WriteLine(golden.ToString());
       Console.WriteLine(golden.Price);

    }
}   
