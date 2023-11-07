using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Partial_Views_Prj.Models;

namespace Partial_Views_Prj.Controllers
{
   
    public class ProductController : Controller
    {
        List<Product> productlist;
        public ProductController()
        {
             productlist = new List<Product>()
            {
                new Product{ProductId=1,
                    ProductName="Shoes",Category="Accessories",
                    Description="Smooth Soles",Price=3200
                },
                new Product{ProductId=2,
                    ProductName="Watches",Category="Accessories",
                    Description="Smart watches",Price=5200
                },
                new Product{ProductId=3,
                    ProductName="Curtains",Category="Furnishings",
                    Description="Valence",Price=1800
                },
                new Product{ProductId=4,
                    ProductName="Pillows",Category="Beddings",
                    Description="Memory Foam",Price=1000
                },
            };
        }
        // GET: Product
        public ActionResult Index()
        {
            
            return View(productlist);           
        }

        //[Authorize(Roles="Admin,Manager")]
      // [Authorize(Users ="Tester,User10")]
     
        public ActionResult AnotherMethod()
        {
            return View(productlist);
        }
      
    }
}