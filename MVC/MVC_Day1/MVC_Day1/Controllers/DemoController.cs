using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        //1. normal method, does not require views
        public string NormalMethod()
        {
            return "Hello All !";
        }

        //2. ViewResult
        public ViewResult ViewresultMethod()
        {
            return View();
        }

        //3. contentresult 
        public ContentResult ContentResultMethod()
        {
            // return Content("Good Morning to All of You", "text/plain");
            return Content("<h1>Good Morning to All of You</h1>", "text/html");
        }

        //4. EmptyResult
        [NonAction]
        public EmptyResult EmptyResultMethod()
        {
            int amount = 45000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. JSonResult

        public JsonResult JsonResultMethod()
        {
            Employee emp = new Employee();
            emp.EId = 100;
            emp.EName = "Anil";
            emp.Age = 28;
            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        //6. redirect
        public RedirectResult RedirectResultMethod()
        {
            return Redirect("~/Home/Contact");
        }

        //7. RedirectToAction
        public ActionResult RedirectToActionmethod()
        {
            return RedirectToAction("Contact", "Home");
        }
    }
}