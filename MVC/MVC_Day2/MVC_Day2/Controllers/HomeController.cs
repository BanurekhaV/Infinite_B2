using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

          //  List<string> lst = TempData["stores"] as List<string>;
            //   return View(lst);
            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            List<string> lst2 = TempData["stores"] as List<string>;
            TempData.Keep();
            return View(lst2);
        }
    }
}