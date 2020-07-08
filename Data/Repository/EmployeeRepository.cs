using Microsoft.EntityFrameworkCore;
using Qulix_Test_Task.Data.Interfaces;
using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly AppDBContent appDBContent;

        public EmployeeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Employee> Employees => appDBContent.Employee.Include(c => c.Company);
    }
}
