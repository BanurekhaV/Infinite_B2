using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2.Controllers
{
    public class DataController : Controller
    {
        // GET: Data

        //eg 1. To pass an object to the view which can be 
        // used as a model to the view
        public ActionResult Index()
        {
            List<string> flowers = new List<string>()
            {
               "Roses","Lilies","Jasmines","Marigolds"
            };
            return View(flowers);
        }

        //eg 2: passing data using ViewBag and ViewData
        public ActionResult OfficeRules()
        {
            List<string> rule = new List<string>()
            {
                "Avoid T-Shirts", "Carry ID Card", "Be on Time",
                "Complete work as per deadlines"
            };

            //1. Data Transfer thru ViewBag Object
            // ViewBag.OffRules = rule;
            // return View();

            //2. Data Transfer thru ViewData
            ViewData["FollowRules"] = rule;
            return View();
        }

        //eg 3. Checking if ViewBag or ViewData can pass on the information
        // to other request

        public ActionResult TestTransfer()
        {
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data Two";
            //  return View(); // in this view we are able to view the data

            // return Redirect("Index"); // redirecting to another action method of the same controller
            return RedirectToAction("Contact", "Home"); // redirecting to action method of different controller
        } 

        //eg 4. Using tempdata to transfer values across pages

        public ActionResult FirstTempRequest()
        {
            List<string> stationaries = new List<string>()
            {
                "Pens","Pencils","Erasers","Markers","NoteBooks"
            };

            TempData["stores"] = stationaries;
            TempData.Keep();
            return View();
        }

        public ActionResult SecondTempRequest()
        {
            //List<string> stnlist;
            
             //   stnlist = TempData["stores"] as List<string>;          

           // TempData.Keep();
            // return View(stnlist);
            return RedirectToAction("About", "Home");
           }  
            
        }

    }
