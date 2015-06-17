using System;
using System.Collections.Generic;


namespace RegularEmployee.SaleEmployee
{
    class SaleEmployee : Person
    {
        private Sale sales;
        public SaleEmployee(string id, string firstName, string lastName,Sale sales): base(id,firstName,lastName)
        {
            this.Sales = sales;
        }
        public Sale Sales { get; set; }
    }
}
