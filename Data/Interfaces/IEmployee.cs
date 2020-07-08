using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data.Interfaces
{
  public  interface IEmployee
    {
        IEnumerable<Employee> Employees { get; }
    }
}
