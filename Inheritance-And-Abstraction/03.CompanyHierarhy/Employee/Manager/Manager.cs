using System;
using System.Collections.Generic;

class Manager : Person
{
    private Employeе employee;
    public Manager(string id,string firstName,string lastName,Employeе employee): base(id,firstName,lastName)
    {
        this.Employee = employee;
    }
    public Employeе Employee { get; set; }
}

