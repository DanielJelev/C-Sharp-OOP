using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarhy.RegularEmployee.Developer
{
    class Developer : Person
    {
        private Project project;
        public Developer(string id,string firstName,string lastName): base(id,firstName,lastName)
        {
            this.Project = project;
        }
        public Project Project { get; set; }
    }
}
