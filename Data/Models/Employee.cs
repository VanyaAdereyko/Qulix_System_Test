using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Models
{
    public class Employee
    {
        public int id { set; get; }

        public string surname { set; get; }

        public string name { set; get; }

        public string lastname { set; get; }

        public string employment_date { set; get; }

        public string position { set; get; }

        public int companyID { get; set; }

        public virtual Company Company { set; get; }
    }
}
