using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst_Prj.Models;
using MVC_CodeFirst_Prj.Models.Repository;

namespace MVC_CodeFirst_Prj.Controllers
{
    public class ProductsController : Controller
    {
        IRepository<Product> _repository = null;

        public ProductsController()
        {
            _repository = new Repository<Product>();
        }
        // GET: Products
        public ActionResult Index()
        {
            var product = _repository.GetAll();
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(product);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        public ActionResult Edit(int Id)
        {
            var product = _repository.GetById(Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if(ModelState.IsValid)
            {
                _repository.Update(p);
                _repository.Save();
                return RedirectToAction("Index");                
            }
            else
            {
                return View(p);
            }
        }

        public ActionResult Details(int Id)
        {
            var product = _repository.GetById(Id);
            return View(product);
        }

        public ActionResult Delete(int Id)
        {
            var product = _repository.GetById(Id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            var product = _repository.GetById(Id);
            _repository.Delete(Id);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}