using _03.CompanyHierarhy.RegularEmployee.Developer;
using System;

namespace RegularEmployee.SaleEmployee
{
    class RegularEmployee
    {
        private SaleEmployee saleEmployee;
        private Developer developer;
        public RegularEmployee(SaleEmployee saleEmployee,Developer developer)
        {
            this.saleEmployee = saleEmployee;
            this.Developer = developer;
        }
        public SaleEmployee SaleEmployee { get; set; }
        public Developer Developer { get; set; }
    }
}
