using System;
namespace RegularEmployee.SaleEmployee
{
    class Sale
    {
        private string productName;
        private DateTime date;
        private double price;
        public Sale(string porductName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

    }
}


