using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EFPrj.Models;

namespace MVC_EFPrj.Controllers
{
    public class ShipperController : Controller
    {
        NorthWindDBContext db = new NorthWindDBContext();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        //create 
        //1. passing data from view to controller using form collection
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frmship)
        {
            Shipper s = new Shipper();
            s.ShipperID = Convert.ToInt32(frmship["ShipperID"]);
            s.CompanyName = frmship["CompanyName"].ToString();
            s.Phone = frmship["Phone"].ToString();
            db.Shippers.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //stored procedure call
        public ActionResult SPWithParameter()
        {
            return View(db.CustOrdersOrders("BOLID"));
           // return View(db.Ten_Most_Expensive_Products());
        }

        //Action Names with different View names
        [ActionName("ExpensiveProducts")]
        public ActionResult Proc_Expensive_Products()
        {
            return View("Proc_Expensive_Products",db.Ten_Most_Expensive_Products());
        }
    }
}