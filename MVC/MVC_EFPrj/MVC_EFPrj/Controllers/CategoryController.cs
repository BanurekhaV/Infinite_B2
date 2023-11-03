using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EFPrj.Models;

namespace MVC_EFPrj.Controllers
{
    public class CategoryController : Controller
    {
        //create an object of the contect class
        NorthWindDBContext db = new NorthWindDBContext();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        //1. Fetch the data from categories table/model

        public ActionResult GetCategoryDetails()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //2. Fetch the data from categories table/model
        //with scaffolded view
        public ActionResult GetCategoryScaffold()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        // Inserting a new category into the table
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        //passing data from view to controller using object
        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffold");
        }

    }
}