using System;

class Worker : Human
{
    private double weekSalary;
    private int workHoursPerDay;
    public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    public double WeekSalary { get; private set; }
    public int WorkHoursPerDay { get; private set; }
    public  double MoneyPerhour()
    {
        double moneyPerHours = this.WeekSalary / this.WorkHoursPerDay;
        return moneyPerHours;
    }
}

