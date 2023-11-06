using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using MVC_Day_4.Models;

namespace MVC_Day_4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Employee employee)
        {
            if(string.IsNullOrEmpty(employee.UserName))
            {
                ModelState.AddModelError("UserName", "Give User name");
            }

            if(!string.IsNullOrEmpty(employee.Email))
            {
                string emailexp = @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$";
                Regex re = new Regex(emailexp);
                if(!re.IsMatch(employee.Email))
                {
                    ModelState.AddModelError("Email", "Not in the correct Format");
                }
            }
            if(ModelState.IsValid)
            {
                //db.Employees.Add(employee);
                //db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("Index");
            }

               return View();
            

        }
    }
}