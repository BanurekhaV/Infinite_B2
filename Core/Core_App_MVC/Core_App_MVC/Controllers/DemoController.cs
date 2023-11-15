using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_App_MVC.Models;

namespace Core_App_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayPerson()
        {
            Person person = new Person();
            person.ID = 101;
            person.Name = "Chandan";
            return View(person);
        }

        public IActionResult MobileBrands()
        {
            List<string> mobiles = new List<string>()
            { "Apple","Samsung","RedMi","One Plus","Oppo","Xiomi"};
            ViewData["androids"] = mobiles;
            ViewBag.mobilebag = mobiles;
            return View();
        }

        public ContentResult Content_1()
        {
            return Content("<h1>This is Content</h1>", "text/html");
        }

        public IActionResult GetJson()
        {
            Person p = new Person();
            p.ID = 6;
            p.Name = "Arun";
            return Json(p);

        }
    }
}
