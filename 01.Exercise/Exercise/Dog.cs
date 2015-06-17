using System;
class Dog
{
    private string name;
    private string breed;
    public Dog(string name,string breed) 
    {
        this.Name = name;
        this.Breed = breed;
    }
    public Dog() : this(null, null)
    { 
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("nemoje null ili prazno");
            }
        }
    }
    public string Breed
    {
        get
        {
            return this.breed;
        }
        set
        {
            this.breed = value;
        }
    }
    public void Bark()
    {
        Console.WriteLine("{0} ({1}) sid Bauuuuuuuuuu!",this.Name??"[unnamed dog]",this.Breed ??"[unknown dog]");
    }
}

