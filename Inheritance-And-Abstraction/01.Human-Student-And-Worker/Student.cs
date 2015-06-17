using System;
 public class Student : Human
{
    private string facultyNumber;
    public  Student(string facultyNumber,string firstName,string lastName) : base (firstName,lastName)
    {
        this.FacultyNumber = facultyNumber;
        
    }
    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length >= 15)
            {
                throw new ArgumentException("Faculty Number must be not less than 5 and more than 15 symbols");
            }
            this.facultyNumber = value;
        }
    }

}
