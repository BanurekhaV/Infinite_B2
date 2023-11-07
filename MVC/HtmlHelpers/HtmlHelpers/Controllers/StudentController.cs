using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpers.Models;

namespace HtmlHelpers.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. Strongly Typed Helper
        public ActionResult StronglyTypedHelper()
        {
            return View();
        }

        //2. Templated Helper 1
        public ActionResult TemplateHelper()
        {
            return View();
        }

        //3. Templated Helper 2 (for the entire model)
        public ActionResult TemplateForModel()
        {
            return View();
        }
    }
}