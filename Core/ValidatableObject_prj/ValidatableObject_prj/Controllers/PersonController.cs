using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidatableObject_prj.Models;

namespace ValidatableObject_prj.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonData pd)
        {
            if(ModelState.IsValid)
            {
                return View(pd);
            }
            return View();
        }
    }
}
