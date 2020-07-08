using Microsoft.AspNetCore.Mvc;
using Qulix_Test_Task.Data.Interfaces;
using Qulix_Test_Task.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _allEmployee; // переменные на интерфейсы

        private readonly ICompany _allCompany;

        public EmployeeController(IEmployee iemployee, ICompany icompany)
        {
            _allEmployee = iemployee;
            _allCompany = icompany;
        }

        public ViewResult ListView()
        {
            ViewBag.Title = "Работники компании";
            EmployeeViewModel obj = new EmployeeViewModel();
            obj.AllEmployees = _allEmployee.Employees;
            obj.employeesCompany = "Qlix";
            return View(obj);
        }
    }
}
