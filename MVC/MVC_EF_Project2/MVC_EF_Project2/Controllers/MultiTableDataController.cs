using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_Project2.Models;

namespace MVC_EF_Project2.Controllers
{
    public class MultiTableDataController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultiTableData
        public ActionResult Index()
        {
            return View();
        }
        //To view data from multiple tables using navigation properties
        [ActionName("MultiData")]
        public ActionResult Cust_Emp_Orders_Details()
        {
            return View(db.Orders.ToList());
        }
        //earlier options of data from multiple models
        public ActionResult MultipleData_Expando()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Orderslist = db.Orders.ToList();
            mymodel.Customerlist = db.Customers.ToList();
            mymodel.Employeelist = db.Employees.ToList();
            return View(mymodel);
        }
    }
}