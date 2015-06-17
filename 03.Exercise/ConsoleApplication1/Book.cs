using System;
using System.Text;
class Book
{
    private string title;
    private string author;
    private double price;
    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }
 
    public string Title
    {
        get { return this.title; }
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Title cannot be empty or null");
            }
            this.author = value;
        }
    }
    public string Author
    {
        get { return this.author; }
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Author cannot be empty or null");
            }
            this.author = value;
        }
    }
    public virtual double Price
    {
        get { return this.price; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentNullException("Price cannot be negative number");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("Title of the book is: {0}\nAuthor of the book is: {1}\nThe price of book is : {2}", this.Title, this.Author, this.Price));
        return sb.ToString();
    }
}