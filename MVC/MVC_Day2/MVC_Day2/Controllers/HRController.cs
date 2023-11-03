using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day2.Models;

namespace MVC_Day2.Controllers
{
    public class HRController : Controller
    {
       
        //1. passing an employee object to bind
        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee() { EID = 1, Ename = "Shreya", Salary = 32000 };
            return View(emp);
        }

        //2. passing a list of employees

        public ActionResult DisplayListofEmployees()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee() { EID = 10, Ename = "Anshika", Salary = 33000 },
                 new Employee() { EID = 20, Ename = "Prachi", Salary = 31000 },
                  new Employee() { EID = 30, Ename = "Soumya", Salary = 32000 },
                   new Employee() { EID = 24, Ename = "Shubangi", Salary = 33000 },
            };
            return View(emplist);
        }

        // GET: HR
        //calling another view of the same controller with an object
        //3.
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { DId = 1, Dname = "Sales" });
            d.Add(new Department { DId = 2, Dname = "IT" });
            d.Add(new Department { DId = 3, Dname = "HR" });
            d.Add(new Department { DId = 4, Dname = "Admin" });
            return View("DepartmentList", d);
        }

        //4. 

        public ActionResult DepartmentList(Department dept)
        {
            return View(dept);
        }

        //5. calling views of other controllers

        public ActionResult CallContact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }
    }
}