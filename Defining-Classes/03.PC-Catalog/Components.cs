using System;
class Component
{
    private string name;
    private string detail;
    private decimal price;
    public Component (string name,string detail , decimal price)
    {
        this.Name = name;
        this.Detail = detail;
        this.Price = price;
    }
    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentNullException("Name cannot be null or empty space");
            }
        }
    }
    public string Detail
    {
        get
        {
            return this.detail;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.detail = value;
            }
            else
            {
                throw new ArgumentNullException("Detail cannot be null or empty space");
            }
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price must be a positive number");
            }
            else
            {
                this.price = value;
            }
        }
    }
}
