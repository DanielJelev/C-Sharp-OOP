using System;
using System.Text;

class Computer
{
    private string name;
    private Component computnents;
    private decimal price;
    public Computer(string name, Component components, decimal price)
    {
        this.Name = name;
        this.Components = components;
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null or empty");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public Component Components { get; set; }
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
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("Computer name is: {0}\nCompunent name is: {1}", this.name, this.Components.Name, this.price));
        if (!string.IsNullOrEmpty(this.Components.Detail))
        {
            sb.Append(string.Format("Component detail is: {0}\n", this.Components.Detail));
        }
        sb.Append(string.Format("Price is: {0}", this.price));
        return sb.ToString();
    }
}
