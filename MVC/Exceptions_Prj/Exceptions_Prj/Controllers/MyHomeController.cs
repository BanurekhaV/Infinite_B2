using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exceptions_Prj.Controllers
{
  //  [HandleError(ExceptionType =typeof(NullReferenceException),View ="NullReference")]
   // [HandleError(ExceptionType=typeof(DivideByZeroException),View ="DivideByZero")]
   // [HandleError]
   
    public class MyHomeController : Controller
    {
        // GET: MyHome
       // [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Some Error Occurred..");
           // return View();
        }

        public ActionResult ExceptionMethod1()
        {
            throw new NullReferenceException();
        }

        public ActionResult ExceptionMethod2()
        {
            throw new DivideByZeroException();
        }
    }
}