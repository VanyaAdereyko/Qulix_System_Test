using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> AllEmployees { get; set; }
        
        public string employeesCompany { get; set; }
    }
}
