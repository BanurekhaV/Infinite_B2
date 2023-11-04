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
        public ActionResult Delete(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }
        //delete option
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Category cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffold");
        }

        //edit
        public ActionResult Update(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
            Category c = db.Categories.Find(category.CategoryID);
            c.CategoryName = category.CategoryName;
            c.Description = category.Description;
            c.Picture = category.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffold");
        }

        //details
        public ActionResult Details(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        //get category by category name sorted
        public ActionResult GetCategoryByName()
        {
            List<string> c = (from cat in db.Categories
                              orderby cat.CategoryName
                              select cat.CategoryName).ToList();

           // dynamic c1 = db.Categories.OrderBy(cat => cat.CategoryName).ToList();
            return View(c);
            //List<string> ls = c1 as List<string>;
            //return View(ls);
        }

    }
}