using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Model_Validations.Models;

namespace Custom_Model_Validations.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        //for viewModel
        public ActionResult FullDetails()
        {
            //details of employee object
            Employee emp = new Employee()
            {
                EId = 101,
                EName = "Deepika",
                Dept="IT",
                Salary = 28000,
                AddressId = 1
            };

            //details of address object
            Address addr = new Address()
            {
                AddressId = 1,
                City = "Hyderabad",
                State = "Telangana",
                Country = "India"
            };

            //create a viewmodel object
            EmpFullDetails efd = new EmpFullDetails()
            {
                employee = emp,
                address = addr,
                PageTitle = "Employee Full Details"
            };

            //pass the viewmodel object to the view
            return View(efd);
        }

        //using standard html helpers
        public ActionResult Standardhtml()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Standardhtml(FormCollection frm)
        {
            //string name = frm["txtname"].ToString();
            return Content("All Good..");
        }
    }
}