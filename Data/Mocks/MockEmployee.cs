using Qulix_Test_Task.Data.Interfaces;
using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Mocks
{
    public class MockEmployee : IEmployee
    {
        private readonly ICompany _employeesCompany = new MockCompany();
        public IEnumerable<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee {
                        name = "Иван",
                        lastname = "Федорович",
                        surname="Петров",
                        employment_date="20.01.12",
                        position="Разработчик",
                        Company = _employeesCompany.AllCompany.First() }
                };
            }
        }


    }
}
