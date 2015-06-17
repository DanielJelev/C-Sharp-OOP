using System;

class Program
{
    static void Main(string[] args)
    {
        var sharo = new Dog("Sharo", "Pomiar");
        sharo.Bark();
        var pesho = new Dog("Pesho", "Kazanterier");
        pesho.Bark();
        Console.WriteLine(pesho.Name);
        var asd = new Dog("asdas","");
        asd.Bark();

    }
}

