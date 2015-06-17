using System;
using System.Text;
class Laptop
{
    private string model;
    private string manufactures;
    private string processor;
    private int ram;
    private string graphicCard;
    private int hdd;
    private string screen;
    private Battery battery;
    private double price;
    
    public Laptop(string model, string manufactures, string processor, int ram, string graphicCard, int hdd, string screen
        , Battery battery, double price)
    {
        this.Model = model;
        this.Manufactures = manufactures;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicCard = graphicCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;

    }
    public Laptop(string model, double price)
        
    {
        this.Model = model;
        this.Price = price;
    }
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Model name cannot be empty or null");
            }
        }
    }
    public string Manufactures
    {
        get
        {
            return this.manufactures;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.manufactures = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Manufactures name cannot be empty or null");
            }
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.processor = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Processor name cannot be empty or null");
            }
        }
    }
    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value > 0)
            {
                this.ram = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Ram must be a positive number");
            }
        }
    }
    public string GraphicCard
    {
        get
        {
            return this.graphicCard;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.graphicCard = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Graphic Card name cannot be empty or null");
            }
        }
    }
    public int HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value >0)
            {
                this.hdd = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("HDD must be a positive number");
            }
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.screen = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Screen name cannot be empty or null");
            }
        }
    }
    public Battery Battery { get; set; }

    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Price must be a positive double number");
            }
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("Model - {0}", this.Model));
        if (!string.IsNullOrEmpty(this.Manufactures))
        {
            sb.Append(string.Format("Manufactures - {0}\n", this.Manufactures));
        }
        if (!string.IsNullOrEmpty(this.Processor))
        {
            sb.Append(string.Format("Processor - {0}\n", this.Processor));
        }
        if (this.Ram>0)
        {
            sb.Append(string.Format("Ram - {0} GB\n", this.Ram));
        }
        if (!string.IsNullOrEmpty(this.GraphicCard))
        {
            sb.Append(string.Format("Graphic Card - {0}\n", this.GraphicCard));
        }
        if (this.HDD >0)
        {
            sb.Append(string.Format("HDD - {0} GB SSD\n", this.HDD));
        }
        if (!string.IsNullOrEmpty(this.Screen))
        {
            sb.Append(string.Format("Screed - {0}\n", this.Screen));
        }
        if (!string.IsNullOrEmpty(this.Battery.Type))
        {
            sb.Append(string.Format("Battery Type - {0}\n", this.Battery.Type));
        }
        if (this.Battery.Life > 0)
        {
            sb.Append(string.Format("Battery Life - {0} hours\n", this.Battery.Life));
        }
        sb.Append(string.Format("Price - {0} lv.", this.Price));
        return sb.ToString();
    }
}
