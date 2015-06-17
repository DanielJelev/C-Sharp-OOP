using System;
using System.Collections.Generic;

class Employeе : Person
{
    private double salary;
    private Object department;
    public Employeе(string id, string firstName,string lastName,double salary, Object department) : base (id,firstName,lastName)
    {
        this.Salary = salary;
        this.Department = department;
    }
    public double Salary { get; set; }
    public Object Department { get; set; }
}