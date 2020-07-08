using Qulix_Test_Task.Data.Interfaces;
using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Mocks
{
    public class MockCompany : ICompany
    {
        public IEnumerable<Company> AllCompany
        {
            get
            {
                return new List<Company>
                {
                    new Company {company_size = 20, сompany_name = "Qulix", incorporation_form="OAO"}
                };
            }
        }
    }
}
