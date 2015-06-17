using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarhy.RegularEmployee.Developer
{
    class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private bool state = true;
        public Project(string projectName, DateTime projectStartDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
        }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public string Details { get; set; }
        public bool State { get; set; }
        public  void CloseProject()
        {
            this.State = false;
        }
    }
    

}
