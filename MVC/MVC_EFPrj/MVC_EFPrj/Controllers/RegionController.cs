using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EFPrj.Models;

namespace MVC_EFPrj.Controllers

{
    public class RegionController : Controller
    {
        NorthWindDBContext db = new NorthWindDBContext();
        // GET: Region
        public ActionResult Index()
        {
            return View(db.Regions.ToList());
        }

        //2. Using parameters to pass data from view to controller
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(int RegionID, string RegionDescription)
        //{
        //    Region r = new Region();
        //    r.RegionID = RegionID;
        //    r.RegionDescription = RegionDescription;
        //    db.Regions.Add(r);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //3. Using Request Object sending data from view to controller
        [HttpPost,ActionName("Create")]
        public ActionResult CreatePost()
        {
            Region r = new Region();
            r.RegionID = Convert.ToInt32(Request["RegionID"]);
            r.RegionDescription = Request["RegionDescription"].ToString();
            db.Regions.Add(r);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}