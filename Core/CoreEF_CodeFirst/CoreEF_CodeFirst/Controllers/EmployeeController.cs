using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEF_CodeFirst.Models;

namespace CoreEF_CodeFirst.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository emprepo;

        public EmployeeController(IEmployeeRepository repo)
        {
            emprepo = repo;
        }
        public IActionResult Index()
        {
            var emp = emprepo.GetAllEmployees();
            return View(emp);
        }

        public ViewResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            emprepo.AddEmployee(emp);
            return RedirectToAction("Index");
        }

        [ActionName("OneEmp")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee e = emprepo.GetEmployeeById(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Employee e = emprepo.GetEmployeeById(id);
            return View(e);
        }

        [HttpPost]

        public IActionResult Edit(Employee e)
        {
            emprepo.UpdateEmployee(e);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            emprepo.DeleteEmploye(id);
            return RedirectToAction("Index");
        }
    }
}
