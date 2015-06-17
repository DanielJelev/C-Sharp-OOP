using System;
class GoldenEditionBook : Book
{
    private double price;
    
    public GoldenEditionBook(string title, string author, double price):base(title,author,price)
    {
        this.Price = price * 1.3;
    }

    public override double Price
    {
        get { return this.price; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentNullException("Price cannot be negative number");
            }
            this.price = value * 1.3;
        }
    }

}
