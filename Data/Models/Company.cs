using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Models
{
    public class Company
    {
        public int id { get; set; }

        public string сompany_name { get; set; }

        public int company_size { get; set; }

        public string incorporation_form { get; set; } 

        public List<Employee> employees { get; set; }
            
    }
}
