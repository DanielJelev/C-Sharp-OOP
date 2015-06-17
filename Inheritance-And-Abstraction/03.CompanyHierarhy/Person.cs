using System;
public abstract class Person
{
    private string id;
    private string firstName;
    private string lastName;
    public Person(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
